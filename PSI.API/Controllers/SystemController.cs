using PSI.API.Filter;
using PSI.BLL;
using PSI.Models.APIModels;
using PSI.Models.DModels;
using System;
using System.Web.Http;

namespace PSI.API.Controllers
{
    [ActionLog]
    [RoutePrefix("api/system")]
    public class SystemController : ApiController
    {
        MenuBLL menuBLL = new MenuBLL();
        SysBLL sysBLL = new SysBLL();
        RegionBLL regionBLL = new RegionBLL();
        RoleBLL roleBLL = new RoleBLL();
        UserBLL userBLL = new UserBLL();
        SheetQueryBLL sheetQueryBLL = new SheetQueryBLL();
        #region Menu
        /// <summary>
        /// 获取角色菜单列表
        /// </summary>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetMenuList")]
        public MessageResult GetMenuList(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = menuBLL.GetMenuList(reqQueryInfo.KeyIds);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定角色的菜单编号集合
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetRoleMenuIds")]
        public MessageResult GetRoleMenuIds(int roleId)
        {
            try
            {
                var result = menuBLL.GetRoleMenuIds(roleId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }


        /// <summary>
        /// 关键字查询菜单列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMenuListByKeyWords")]
        public MessageResult GetMenuListByKeyWords(string keywords)
        {
            try
            {
                var result = menuBLL.GetMenuListByKeyWords(keywords);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取所有菜单信息（编号，名称） 用于下拉框或列表的绑定
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllMenus")]
        public MessageResult GetAllMenus()
        {
            try
            {
                var result = menuBLL.GetAllMenus();
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取所有菜单列表（绑定TreeView）
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetTvMenus")]
        public MessageResult GetTvMenus()
        {
            try
            {
                var result = menuBLL.GetTvMenus();
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定的菜单信息
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMenuInfo")]
        public MessageResult GetMenuInfo(int menuId)
        {
            try
            {
                var result = menuBLL.GetMenuInfo(menuId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }



        /// <summary>
        /// 判断菜单名称是否已存在
        /// </summary>
        /// <param name="mName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ExistMenu")]
        public MessageResult ExistMenu(string mName)
        {
            try
            {
                var result = menuBLL.ExistMenu(mName);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 新增菜单信息
        /// </summary>
        /// <param name="menuInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddMenuInfo")]
        public MessageResult AddMenuInfo(MenuInfoModel menuInfo)
        {
            try
            {
                var result = menuBLL.AddMenuInfo(menuInfo);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 修改菜单信息
        /// </summary>
        /// <param name="menuInfo"></param>
        /// <param name="blUpdate"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateMenuInfo")]
        public MessageResult UpdateMenuInfo(MenuInfoApi menuInfoApi)
        {
            try
            {
                var result = menuBLL.UpdateMenuInfo(menuInfoApi.MenuInfoModel, menuInfoApi.BlUpdate);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 删除菜单信息
        /// </summary>
        /// <param name="menuIds"></param>
        /// <param name="delType"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteMenu")]
        public MessageResult DeleteMenu(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = menuBLL.DeleteMenu(reqQueryInfo.KeyIds, reqQueryInfo.TypeId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion

        #region Sys
        /// <summary>
        /// 获取系统开账状态
        /// </summary>
        /// <param name="sysId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetOpenState")]
        public MessageResult GetOpenState(int sysId)
        {
            try
            {
                var result = sysBLL.GetOpenState(sysId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 备份数据
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("BackupData")]
        public MessageResult BackupData(string path)
        {
            try
            {
                var result = sysBLL.BackupData(path);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion

        #region Region
        /// <summary>
        /// 根据区域编号获取区域完整信息
        /// </summary>
        /// <param name="regionId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetRegionAddress")]
        public MessageResult GetRegionAddress(int regionId)
        {
            try
            {
                var result = regionBLL.GetRegionAddress(regionId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetRegion")]
        public MessageResult GetRegion(int regionId)
        {
            try
            {
                var result = regionBLL.GetRegion(regionId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取省区域列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetProvinces")]
        public MessageResult GetProvinces()
        {
            try
            {
                var result = regionBLL.GetProvinces();
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取市区域列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCities")]
        public MessageResult GetCities(int provinceId)
        {
            try
            {
                var result = regionBLL.GetCities(provinceId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取县/区 区域列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCountries")]
        public MessageResult GetCountries(int cityId)
        {
            try
            {
                var result = regionBLL.GetCountries(cityId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion

        #region Role
        /// <summary>
        /// 获取绑定的角色列表（主要用于绑定下拉框或列表框）
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllRoles")]
        public MessageResult GetAllRoles()
        {
            try
            {
                var result = roleBLL.GetAllRoles();
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取所有角色列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllRoleList")]
        public MessageResult GetAllRoleList()
        {
            try
            {
                var result = roleBLL.GetAllRoleList();
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 判断角色名称是否已存在
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ExistRoleName")]
        public MessageResult ExistRoleName(string roleName)
        {
            try
            {
                var result = roleBLL.ExistRoleName(roleName);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 添加角色信息
        /// </summary>
        /// <param name="roleInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddRoleInfo")]
        public MessageResult AddRoleInfo(RoleInfoModel roleInfo)
        {
            try
            {
                var result = roleBLL.AddRoleInfo(roleInfo);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 修改角色信息
        /// </summary>
        /// <param name="roleInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateRoleInfo")]
        public MessageResult UpdateRoleInfo(RoleInfoModel roleInfo)
        {
            try
            {
                var result = roleBLL.UpdateRoleInfo(roleInfo);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }


        /// <summary>
        /// 获取指定的角色信息
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetRole")]
        public MessageResult GetRole(int roleId)
        {
            try
            {
                var result = roleBLL.GetRole(roleId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 删除单个角色信息
        /// </summary>
        /// <param name="roleId"></param>
        ///  <param name="delType">0 ---logic   1= real</param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteRoleLogic")]
        public MessageResult DeleteRoleLogic(int roleId)
        {
            try
            {
                var result = roleBLL.DeleteRoleLogic(roleId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 删除角色信息（真删除）
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteRoleReal")]
        public MessageResult DeleteRoleReal(int roleId)
        {
            try
            {
                var result = roleBLL.DeleteRoleReal(roleId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 删除多个角色信息
        /// </summary>
        /// <param name="roleIds"></param>
        /// <param name="delType"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteRoles")]
        public MessageResult DeleteRoles(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = roleBLL.DeleteRoles(reqQueryInfo.KeyIds, reqQueryInfo.TypeId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 保存权限设置
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="menuIds"></param>
        /// <param name="tmenuIds"></param>
        /// <param name="uName"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("SetRoleRight")]
        public MessageResult SetRoleRight(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = roleBLL.SetRoleRight(reqQueryInfo.KeyID, reqQueryInfo.KeyIds, reqQueryInfo.TemKeyIds, reqQueryInfo.Name);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion

        #region User


        /// <summary>
        /// 条件查询用户列表
        /// </summary>
        /// <param name="uName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUserList")]
        public MessageResult GetUserList(string uName)
        {
            try
            {
                var result = userBLL.GetUserList(uName);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 启用用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("EnableUser")]
        public MessageResult EnableUser(int userId)
        {
            try
            {
                var result = userBLL.EnableUser(userId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        /// <summary>
        /// 停用用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("StopUser")]
        public MessageResult StopUser(int userId)
        {
            try
            {
                var result = userBLL.StopUser(userId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 多用户停用
        /// </summary>
        /// <param name="userIds"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("StopUsers")]
        public MessageResult StopUsers(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = userBLL.StopUsers(reqQueryInfo.KeyIds);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 多用户启用
        /// </summary>
        /// <param name="userIds"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("EnableUsers")]
        public MessageResult EnableUsers(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = userBLL.EnableUsers(reqQueryInfo.KeyIds);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUserInfo")]
        public MessageResult GetUserInfo(int userId)
        {
            try
            {
                var result = userBLL.GetUserInfo(userId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取用户角色列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUserRoleList")]
        public MessageResult GetUserRoleList(int userId)
        {
            try
            {
                var result = userBLL.GetUserRoleList(userId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 添加用户 信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="urList"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddUserInfo")]
        public MessageResult AddUserInfo(UserInfoApi userInfoApi)
        {
            try
            {
                var result = userBLL.AddUserInfo(userInfoApi.UserInfoModel, userInfoApi.UserRoleInfoModels);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="urList"></param>
        /// <param name="urListNew"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateUserInfo")]
        public MessageResult UpdateUserInfo(UserInfoApi userInfoApi)
        {
            try
            {
                var result = userBLL.UpdateUserInfo(userInfoApi.UserInfoModel, userInfoApi.UserRoleInfoModels, userInfoApi.NewUserRoleInfoModels);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取用户原始密码
        /// </summary>
        /// <param name="uName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetOldPwd")]
        public MessageResult GetOldPwd(string uName)
        {
            try
            {
                var result = userBLL.GetOldPwd(uName);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="enNewPwd"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("UpdateUserPwd")]
        public MessageResult UpdateUserPwd(string uName, string enNewPwd)
        {
            try
            {
                var result = userBLL.UpdateUserPwd(uName, enNewPwd);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion
        #region Sheet
        /// <summary>
        /// 分页查询单据列表
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetSheetList")]
        public MessageResult GetSheetList(PageInfo pageInfo)
        {
            try
            {
                var result = sheetQueryBLL.GetSheetList(pageInfo.ShQueryParaModel, pageInfo.StartIndex, pageInfo.PageSize);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定 供应商/客户 、 仓库 、商品的相关单据明细列表
        /// </summary>
        /// <param name="shType"></param>
        /// <param name="typeId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSheetGoodsInfoList")]
        public MessageResult GetSheetGoodsInfoList(int shType, int typeId, int id)
        {
            try
            {
                var result = sheetQueryBLL.GetSheetGoodsInfoList(shType, typeId, id);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取审核状态列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCheckList")]
        public MessageResult GetCheckList()
        {
            try
            {
                var result = sheetQueryBLL.GetCheckList();
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }




        #endregion
    }
}
