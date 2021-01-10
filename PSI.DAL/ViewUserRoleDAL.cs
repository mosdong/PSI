using PSI.Models.VModels;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PSI.DAL
{
    public class ViewUserRoleDAL : BQuery<ViewUserRoleModel>
    {
        /// <summary>
        /// 获取用户角色列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<ViewUserRoleModel> GetUserRoles(int userId)
        {
            string strWhere = "UserId=@UserId";
            SqlParameter paraId = new SqlParameter("@UserId", userId);
            return GetModelList(strWhere, "UserId,UserName,RoleId,RoleName,IsAdmin", paraId);
        }
    }
}
