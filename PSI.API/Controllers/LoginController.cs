using PSI.API.Filter;
using PSI.BLL;
using PSI.Models.APIModels;
using PSI.Models.VModels;
using System.Collections.Generic;
using System.Web.Http;

namespace PSI.API.Controllers
{
    [ActionLog]
    [RoutePrefix("api/login")]
    public class LoginController : ApiController
    {
        [HttpPost]
        [Route("CheckUser")]
        public MessageResult CheckUser(UserInfo userInfo)
        {
            UserBLL userBLL = new UserBLL();
            List<ViewUserRoleModel> urList = userBLL.Login(userInfo.UserName, userInfo.UserPwd);//登录
            return MessageResult.Success(urList);
        }
    }
}
