using PSI.Models.VModels;
using System.Collections.Generic;

namespace WinPSI.FModels
{
    /// <summary>
    /// 用于登录页面向主页面传递参数的实体
    /// </summary>
    public class LoginModel
    {
        public List<ViewUserRoleModel> URList { get; set; }
        public FrmLogin LoginForm { get; set; }
    }
}
