using PSI.DAL;
using PSI.Models.DModels;
using PSI.Models.VModels;
using System.Collections.Generic;

namespace PSI.BLL
{
    public class UserBLL : BaseBLL<UserInfoModel>
    {
        UserDAL userDAL = new UserDAL();
        ViewUserRoleDAL vurDAL = new ViewUserRoleDAL();
        /// <summary>
        /// 登录系统，返回用户角色列表
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="uPwd"></param>
        /// <returns></returns>
        public List<ViewUserRoleModel> Login(string uName, string uPwd)
        {
            List<ViewUserRoleModel> roleList = new List<ViewUserRoleModel>();
            int userId = userDAL.Login(uName, uPwd);
            if (userId > 0)
            {
                //获取用户角色列表
                roleList = vurDAL.GetUserRoles(userId);
            }
            return roleList;
        }

        /// <summary>
        /// 条件查询用户列表
        /// </summary>
        /// <param name="uName"></param>
        /// <returns></returns>
        public List<UserInfoModel> GetUserList(string uName)
        {
            return userDAL.GetUserList(uName);
        }

        /// <summary>
        /// 启用用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool EnableUser(int userId)
        {
            return userDAL.UpdateUserState(userId, 1);
        }
        /// <summary>
        /// 停用用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool StopUser(int userId)
        {
            return userDAL.UpdateUserState(userId, 0);
        }

        /// <summary>
        /// 多用户停用
        /// </summary>
        /// <param name="userIds"></param>
        /// <returns></returns>
        public bool StopUsers(List<int> userIds)
        {
            return userDAL.UpdateUserSate(userIds, 0);
        }

        /// <summary>
        /// 多用户启用
        /// </summary>
        /// <param name="userIds"></param>
        /// <returns></returns>
        public bool EnableUsers(List<int> userIds)
        {
            return userDAL.UpdateUserSate(userIds, 1);
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserInfoModel GetUserInfo(int userId)
        {
            return userDAL.GetUserInfo(userId);
        }

        /// <summary>
        /// 获取用户角色列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<ViewUserRoleModel> GetUserRoleList(int userId)
        {
            return vurDAL.GetUserRoles(userId);
        }

        /// <summary>
        /// 添加用户 信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="urList"></param>
        /// <returns></returns>
        public bool AddUserInfo(UserInfoModel userInfo, List<UserRoleInfoModel> urList)
        {
            return userDAL.AddUserInfo(userInfo, urList);
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="urList"></param>
        /// <param name="urListNew"></param>
        /// <returns></returns>
        public bool UpdateUserInfo(UserInfoModel userInfo, List<UserRoleInfoModel> urList, List<UserRoleInfoModel> urListNew)
        {
            return userDAL.UpdateUserInfo(userInfo, urList, urListNew);
        }

        /// <summary>
        /// 获取用户原始密码
        /// </summary>
        /// <param name="uName"></param>
        /// <returns></returns>
        public string GetOldPwd(string uName)
        {
            return userDAL.GetOldPwd(uName);
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="enNewPwd"></param>
        /// <returns></returns>
        public bool UpdateUserPwd(string uName, string enNewPwd)
        {
            return userDAL.UpdateUserPwd(uName, enNewPwd);
        }
    }
}
