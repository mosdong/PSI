using PSI.BLL;
using PSI.Models.APIModels;
using PSI.Models.DModels;
using System;
using System.Web.Http;

namespace PSI.API.Controllers
{
    [RoutePrefix("api/tool")]
    public class ToolController : ApiController
    {
        ToolGroupBLL toolGroupBLL = new ToolGroupBLL();
        ToolMenuBLL toolMenuBLL = new ToolMenuBLL();

        PayBLL payBLL = new PayBLL();

        #region ToolGroup
        /// <summary>
        /// 获取所有的工具组（绑定下拉框）
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetToolGroups")]
        public MessageResult GetToolGroups()
        {
            try
            {
                var result = toolGroupBLL.GetToolGroups();
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 加载所有的工具组数据（未删除 或 已删除）
        /// </summary>
        /// <param name="blShow"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetToolGroups")]
        public MessageResult GetToolGroups(bool blShow)
        {
            try
            {
                var result = toolGroupBLL.GetToolGroups(blShow);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 检查组名是否已存在
        /// </summary>
        /// <param name="gName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ExistName")]
        public MessageResult ExistName(string gName)
        {
            try
            {
                var result = toolGroupBLL.ExistName(gName);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 添加工具组
        /// </summary>
        /// <param name="tgInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddToolGroup")]
        public MessageResult AddToolGroup(ToolGroupInfoModel tgInfo)
        {
            try
            {
                var result = toolGroupBLL.AddToolGroup(tgInfo);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        /// <summary>
        /// 修改工具组
        /// </summary>
        /// <param name="tgInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateToolGroup")]
        public MessageResult UpdateToolGroup(ToolGroupInfoModel tgInfo)
        {
            try
            {
                var result = toolGroupBLL.UpdateToolGroup(tgInfo);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        [HttpPost]
        [Route("ConfirmToolGroup")]
        public MessageResult ConfirmToolGroup(ToolGroupInfoModel tgInfo)
        {
            try
            {
                var result = toolGroupBLL.ConfirmToolGroup(tgInfo);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 删除工具组（多个）逻辑删除
        /// </summary>
        /// <param name="tgIds"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("LogicDeleteToolGroups")]
        public MessageResult LogicDeleteToolGroups(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = toolGroupBLL.LogicDeleteToolGroups(reqQueryInfo.KeyIds);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 恢复工具组数据（多个）
        /// </summary>
        /// <param name="tgIds"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RecoverToolGroups")]
        public MessageResult RecoverToolGroups(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = toolGroupBLL.RecoverToolGroups(reqQueryInfo.KeyIds);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 删除工具组（单个）逻辑删除
        /// </summary>
        /// <param name="tgId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("LogicDeleteToolGroup")]
        public MessageResult LogicDeleteToolGroup(int tgId)
        {
            try
            {
                var result = toolGroupBLL.LogicDeleteToolGroup(tgId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 恢复工具组数据（单个）
        /// </summary>
        /// <param name="tgIds"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("RecoverToolGroup")]
        public MessageResult RecoverToolGroup(int tgId)
        {
            try
            {
                var result = toolGroupBLL.RecoverToolGroup(tgId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 永久删除工具组(单个)
        /// </summary>
        /// <param name="tgId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteToolGroup")]
        public MessageResult DeleteToolGroup(int tgId)
        {
            try
            {
                var result = toolGroupBLL.DeleteToolGroup(tgId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion

        #region ToolMenu
        /// <summary>
        /// 获取工具栏菜单项数据
        /// </summary>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetToolMenuList")]
        public MessageResult GetToolMenuList(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = toolMenuBLL.GetToolMenuList(reqQueryInfo.KeyIds);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取所有的工具菜单项（绑定TreeView）
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetToolMenuList")]
        public MessageResult GetToolMenuList()
        {
            try
            {
                var result = toolMenuBLL.GetToolMenuList();
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }



        /// <summary>
        /// 获取指定角色的工具栏菜单编号集合
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetRoleTMenuIds")]
        public MessageResult GetRoleTMenuIds(int roleId)
        {
            try
            {
                var result = toolMenuBLL.GetRoleTMenuIds(roleId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 关键字查询工具菜单项列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetToolMenuInfos")]
        public MessageResult GetToolMenuInfos(string keywords, bool blShow)
        {
            try
            {
                var result = toolMenuBLL.GetToolMenuInfos(keywords, blShow);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 删除工具菜单项（假删除）
        /// </summary>
        /// <param name="tmenuId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteToolMenuLogic")]
        public MessageResult DeleteToolMenuLogic(int tmenuId)
        {
            try
            {
                var result = toolMenuBLL.DeleteToolMenuLogic(tmenuId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        ///  删除工具菜单项（真删除）
        /// </summary>
        /// <param name="tmenuId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteToolMenu")]
        public MessageResult DeleteToolMenu(int tmenuId)
        {
            try
            {
                var result = toolMenuBLL.DeleteToolMenu(tmenuId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        ///  删除多个工具菜单项（真删除）
        /// </summary>
        /// <param name="delIds"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteToolMenus")]
        public MessageResult DeleteToolMenus(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = toolMenuBLL.DeleteToolMenus(reqQueryInfo.KeyIds);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        ///  删除多个工具菜单项（假删除）
        /// </summary>
        /// <param name="delIds"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteToolMenusLogic")]
        public MessageResult DeleteToolMenusLogic(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = toolMenuBLL.DeleteToolMenusLogic(reqQueryInfo.KeyIds);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 工具菜单数据恢复  多条
        /// </summary>
        /// <param name="delIds"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RecoverToolMenus")]
        public MessageResult RecoverToolMenus(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = toolMenuBLL.RecoverToolMenus(reqQueryInfo.KeyIds);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 工具菜单数据恢复 单条
        /// </summary>
        /// <param name="tmenuId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("RecoverToolMenu")]
        public MessageResult RecoverToolMenu(int tmenuId)
        {
            try
            {
                var result = toolMenuBLL.RecoverToolMenu(tmenuId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 判断指定工具组下是否已添加工具菜单项
        /// </summary>
        /// <param name="tgId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("HasToolMenus")]
        public MessageResult HasToolMenus(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = toolMenuBLL.HasToolMenus(reqQueryInfo.KeyIds);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion

        #region Pay
        /// <summary>
        /// 进入付款页面,获取付款 列表
        /// </summary>
        /// <param name="payType"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetFirstPayInfos")]
        public MessageResult GetFirstPayInfos(string payType, string strPayFor)
        {
            try
            {
                var result = payBLL.GetFirstPayInfos(payType, strPayFor);
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
