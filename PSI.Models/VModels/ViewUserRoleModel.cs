using PSI.Common.CustomAttributes;

namespace PSI.Models.VModels
{
    /// <summary>
    /// 用户角色视图模型
    /// </summary>
    [Table("ViewUserRoleInfos")]
    public class ViewUserRoleModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int IsAdmin { get; set; }
    }
}
