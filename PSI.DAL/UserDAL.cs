﻿using PSI.Common;
using PSI.DbUtility;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI.DAL
{
    public  class UserDAL:BaseDAL<UserInfoModel>
    {
        /// <summary>
        /// 登录，返回UserId
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="uPwd"></param>
        /// <returns></returns>
        public int Login(string uName,string uPwd)
        {
            string strWhere = "UserName=@UserName and UserPwd=@UserPwd and UserState=1";
            SqlParameter[] paras =
            {
                new SqlParameter("@UserName",uName),
                 new SqlParameter("@UserPwd",uPwd)
            };
            UserInfoModel user = GetModel(strWhere, "UserId", paras);
            if (user != null)
                return user.UserId;
            else
                return 0;
        }

        /// <summary>
        /// 条件查询用户列表
        /// </summary>
        /// <param name="uName"></param>
        /// <returns></returns>
        public List<UserInfoModel> GetUserList(string uName)
        {
            string strWhere = " 1=1 and UserName <> (select UserName from UserInfos where UserId in (select UserId from UserRoleInfos where RoleId = (select RoleId from RoleInfos where IsAdmin=1))) and IsDeleted=0";
            if (!string.IsNullOrEmpty(uName))
                strWhere += " and UserName like @uName";
            SqlParameter paraName = new SqlParameter("@uName", "%"+uName+"%");
            string cols = "UserId,UserName,UserState,CreateTime";
            return GetModelList(strWhere,cols,paraName);
        }

        /// <summary>
        /// 修改用户状态
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userState"></param>
        /// <returns></returns>
        public bool UpdateUserState(int userId,int userState)
        {
            string sql = "update UserInfos set UserState=@userState where UserId=@userId";
            SqlParameter[] paras =
            {
                new SqlParameter("@userId",userId),
                new SqlParameter("@userState",userState)
            };
            return SqlHelper.ExecuteNonQuery(sql, 1, paras) > 0;
        }

        /// <summary>
        /// 修改多用户状态
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="userState"></param>
        /// <returns></returns>
        public bool UpdateUserSate(List<int> userIds,int userState)
        {
            //string strids = string.Join(",", userIds);
            //string sql = $"update UserInfos set UserState=@userState where UserId in ({strids})";
            //SqlParameter[] paras =
            //{
            //    new SqlParameter("@userState",userState)
            //};
            //List<CommandInfo> comList = new List<CommandInfo>();
            //comList.Add(new CommandInfo()
            //{
            //    CommandText = sql,
            //    IsProc = false,
            //    Paras = paras
            //});
            //return SqlHelper.ExecuteTrans(comList);

            List<CommandInfo> comList = new List<CommandInfo>();
            foreach (int userId in userIds)
            {
                string sql = $"update UserInfos set UserState=@userState where UserId = @userId";
                SqlParameter[] paras =
                 {
                    new SqlParameter("@userState", userState),
                    new SqlParameter("@userId", userId)
                 };
                comList.Add(new CommandInfo()
                {
                    CommandText = sql,
                    IsProc = false,
                    Paras = paras
                });
            }
            return SqlHelper.ExecuteTrans(comList);
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserInfoModel GetUserInfo(int userId)
        {
            string cols = "UserId,UserName,UserState";
            return GetById(userId, cols);
        }

        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="urList"></param>
        /// <returns></returns>
        public bool AddUserInfo(UserInfoModel userInfo,List<UserRoleInfoModel> urList)
        {
            string colUsers = "UserName,UserPwd,UserState,Creator";
            SqlModel inUser = CreateSql.GetInsertSqlAndParas(userInfo, colUsers, 1);
            return SqlHelper.ExecuteTrans<bool>(cmd =>
            {
                try
                {
                    cmd.CommandText = inUser.Sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Clear();
                    foreach (var p in inUser.SqlParaArray)
                    {
                        cmd.Parameters.Add(p);
                    }
                    object oId = cmd.ExecuteScalar();
                    cmd.Parameters.Clear();
                    if(oId!=null && oId.ToString()!="")
                    {
                        int userId = oId.GetInt();
                        if(urList.Count>0)
                        {
                            string colsUserRole = "UserId,RoleId,Creator";
                            foreach (var ur in urList)
                            {
                                ur.UserId = userId;
                                SqlModel inUserRole = CreateSql.GetInsertSqlAndParas<UserRoleInfoModel>(ur, colsUserRole, 0);
                                cmd.CommandText = inUserRole.Sql;
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.Clear();
                                foreach (var p in inUserRole.SqlParaArray)
                                {
                                    cmd.Parameters.Add(p);
                                }
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                            }
                        }
                       
                    }
                    cmd.Transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    cmd.Transaction.Rollback();
                    throw new Exception("添加用户执行异常！", ex);                  
                }
             
            });
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="urList"></param>
        /// <param name="urListNew"></param>
        /// <returns></returns>
        public bool UpdateUserInfo(UserInfoModel userInfo, List<UserRoleInfoModel> urList,List<UserRoleInfoModel> urListNew)
        {
            List<CommandInfo> comList = new List<CommandInfo>();
            string colsUser = "UserId,UserName";
            if (!string.IsNullOrEmpty(userInfo.UserPwd))
                colsUser += ",UserPwd";
            colsUser += ",UserState";
            SqlModel upUser = CreateSql.GetUpdateSqlAndParas(userInfo, colsUser, "");
            //修改用户信息
            comList.Add(new CommandInfo()
            {
                CommandText = upUser.Sql,
                IsProc = false,
                Paras = upUser.SqlParaArray
            });
            if(urList.Count >0)
            {
                //删除取消的角色关系数据
                string roleIds = string.Join(",", urList.Select(ur => ur.RoleId));
                comList.Add(new CommandInfo()
                {
                    CommandText = $"delete from UserRoleInfos where RoleId not in ({roleIds}) and UserId={userInfo.UserId}",
                    IsProc = false
                });
            }
            if (urListNew.Count > 0)
            {
                //新增新设置的角色关系  
                string colsUserRole = "UserId,RoleId,Creator";
                foreach (var ur in urListNew)
                {
                    SqlModel inUserRole = CreateSql.GetInsertSqlAndParas<UserRoleInfoModel>(ur, colsUserRole, 0);
                    comList.Add(new CommandInfo()
                    {
                        CommandText = inUserRole.Sql,
                        IsProc = false,
                        Paras = inUserRole.SqlParaArray
                    });
                }
            }
           
            return SqlHelper.ExecuteTrans(comList);
        }


        /// <summary>
        /// 获取用户原始密码
        /// </summary>
        /// <param name="uName"></param>
        /// <returns></returns>
        public string GetOldPwd(string uName)
        {
            string strWhere = "UserName=@uName";
            SqlParameter paraName = new SqlParameter("@uName", uName);
            UserInfoModel userInfo = GetModel(strWhere, "UserPwd", paraName);
            if (userInfo != null)
                return userInfo.UserPwd;
            else
                return null;
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="enNewPwd"></param>
        /// <returns></returns>
        public bool UpdateUserPwd(string uName,string enNewPwd)
        {
            string sql = "update UserInfos set UserPwd=@userPwd where UserName=@uName";
            SqlParameter[] paras = {
                new SqlParameter("@userPwd", enNewPwd),
                new SqlParameter("@uName", uName)
            };
            return SqlHelper.ExecuteNonQuery(sql, 1, paras)>0;
        }
    }
}
