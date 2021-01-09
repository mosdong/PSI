using PSI.DbUtility;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI.DAL
{
   public  class ToolMenuDAL:BaseDAL<ToolMenuInfoModel>
    {
        /// <summary>
        /// 获取角色工具栏菜单项数据
        /// </summary>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        public List<ToolMenuInfoModel> GetToolMenuList(string roleIds)
        {
            string strWhere = "IsDeleted=0";
            string cols = "TMenuId,TMenuName,TMPic,TMOrder,TGroupId,TMUrl,IsTop,TMDesp";
            if (!string.IsNullOrEmpty(roleIds))
            {
                strWhere += $" and TMenuId in (select TMenuId from RoleTMenuInfos where RoleId in ({roleIds})) ";
            }
            strWhere += " order by TGroupId, TMOrder";
            return GetModelList(strWhere, cols);
        }

        /// <summary>
        /// 获取所有的工具菜单项（绑定TreeView）
        /// </summary>
        /// <returns></returns>
        public  List<ToolMenuInfoModel> GetToolMenuList()
        {
            string cols = "TMenuId,TMenuName";
            return GetModelList(cols);
        }

        /// <summary>
        /// 关键字查询工具菜单项列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public List<ToolMenuInfoModel> GetToolMenuInfos(string keywords,bool blShow)
        {
            string strWhere = "1=1";
            if (blShow)
                strWhere += "  and IsDeleted=1";
            else
                strWhere += " and IsDeleted=0";
            string cols = "TMenuId,TMenuName,TMPic,TMOrder,TMUrl,TGroupId";
            if (!string.IsNullOrEmpty(keywords))
            {
                strWhere += " and TMenuName like @keywords";
                SqlParameter para = new SqlParameter("@keywords", $"%{keywords}%");
                return GetModelList(strWhere, cols, para);
            }
            else
                return GetModelList(strWhere, cols);

        }

        /// <summary>
        /// 删除工具菜单项信息  多个
        /// </summary>
        /// <param name="delIds"></param>
        /// <returns></returns>
        public bool UpdateToolMenusDelState(List<int> delIds,int delType,int isDeleted)
        {
            List<string> listSql = new List<string>();
            foreach(int id in delIds)
            {
                listSql.AddRange(GetDeleteTMenuSql(delType, id,isDeleted));
            }
            return SqlHelper.ExecuteTrans(listSql);
        }

        /// <summary>
        /// isDeleted的值针对 delType=0时候    delType=1---  isDeleted=2
        /// </summary>
        /// <param name="delType"></param>
        /// <param name="tmenuId"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        private List<string> GetDeleteTMenuSql(int delType, int tmenuId,int isDeleted)
        {
            List<string> listSqls = new List<string>();
            string[] tables = { "ToolMenuInfos", "RoleTMenuInfos" };
            string strWhere = $"TMenuId={tmenuId}";
            if (delType == 0)
            {
                foreach (string tName in tables)
                {
                    listSqls.Add($"update {tName} set IsDeleted = {isDeleted} where {strWhere}");
                }
            }
            else if (delType == 1)
            {
                foreach (string tName in tables)
                {
                    listSqls.Add($"delete from {tName}  where {strWhere}");
                }
            }
            return listSqls;
        }

        /// <summary>
        /// 判断指定工具组下是否已添加工具菜单项
        /// </summary>
        /// <param name="tgId"></param>
        /// <returns></returns>
        public bool HasToolMenus(List<int> tgIds)
        {
            string ids = string.Join(",", tgIds);
            string strWhere = $"TGroupId in ({ids})";
            return Exists(strWhere);
        }



    }
}
