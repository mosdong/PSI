using PSI.Models.DModels;
using System.Collections.Generic;

namespace PSI.Models.APIModels
{
    public class UserInfoApi
    {
        public UserInfoModel UserInfoModel { set; get; }
        public List<UserRoleInfoModel> UserRoleInfoModels { set; get; }

        public List<UserRoleInfoModel> NewUserRoleInfoModels { set; get; }
    }
}
