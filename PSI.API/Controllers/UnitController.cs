using PSI.API.Filter;
using PSI.BLL;
using PSI.Models.APIModels;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace PSI.API.Controllers
{
    [ActionLog]
    [RoutePrefix("api/unit")]
    public class UnitController : ApiController
    {
        UnitTypeBLL utBLL = new UnitTypeBLL();
        UnitBLL unitBLL = new UnitBLL();
        #region Unit

        #region 删除
        /// <summary>
        /// 根据Id删除  这里id是主键  假删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("UnitLogicDelete")]
        public MessageResult UnitLogicDelete(int id)
        {
            try
            {
                var result = unitBLL.LogicDelete(id);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 根据Id真删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="delType"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("UnitDelete")]
        public MessageResult UnitDelete(int id)
        {
            try
            {
                var result = unitBLL.Delete(id);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 批量删除(真删除)
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UnitDeleteList")]
        public MessageResult UnitDeleteList(List<int> idList)
        {
            try
            {
                var result = unitBLL.DeleteList(idList);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        [HttpPost]
        [Route("UnitLogicDeleteList")]
        public MessageResult UnitLogicDeleteList(List<int> idList)
        {
            try
            {
                var result = unitBLL.LogicDeleteList(idList);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }




        #endregion

        #region 恢复
        /// <summary>
        /// 根据Id恢复  这里id是主键 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("UnitRecover")]
        public MessageResult UnitRecover(int id)
        {
            try
            {
                var result = unitBLL.Recover(id);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 批量恢复  这里id是主键 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UnitRecoverList")]
        public MessageResult UnitRecoverList(List<int> ids)
        {
            try
            {
                var result = unitBLL.DeleteList(ids);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion


        /// <summary>
        /// 条件查询单位信息列表（分页）
        /// </summary>
        /// <param name="uTypeId"></param>
        /// <param name="keywords"></param>
        /// <param name="isDeleted"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetUnitListByPage")]
        public MessageResult GetUnitList(PageInfo pageInfo)
        {
            try
            {
                var result = unitBLL.GetUnitList(pageInfo.KeyId, pageInfo.KeyWord, pageInfo.IsShowDel, pageInfo.StartIndex, pageInfo.PageSize);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        [HttpPost]
        [Route("GetUnitList")]
        public MessageResult GetUnitList(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var result = unitBLL.GetUnitList(reqQueryInfo.KeyID, reqQueryInfo.Name, reqQueryInfo.KeyWords);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 检查单位是否在使用中
        /// </summary>
        /// <param name="unitId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("CheckUnitUse")]
        public MessageResult CheckUnitUse(int unitId)
        {
            try
            {
                var result = unitBLL.CheckUnitUse(unitId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定的单位信息
        /// </summary>
        /// <param name="unitId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUnitInfo")]
        public MessageResult GetUnitInfo(int unitId)
        {
            try
            {
                var result = unitBLL.GetUnitInfo(unitId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 添加单位信息
        /// </summary>
        /// <param name="unitInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddUnitInfo")]
        public MessageResult AddUnitInfo(UnitInfoModel unitInfo)
        {
            try
            {
                var result = unitBLL.AddUnitInfo(unitInfo);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 修改单位信息
        /// </summary>
        /// <param name="unitInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateUnitInfo")]
        public MessageResult UpdateUnitInfo(UnitInfoModel unitInfo)
        {
            try
            {
                var result = unitBLL.UpdateUnitInfo(unitInfo);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 判断单位是否已存在
        /// </summary>
        /// <param name="unitName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ExistUnit")]
        public MessageResult ExistUnit(string unitName, int uTypeId)
        {
            try
            {
                var result = unitBLL.ExistUnit(unitName, uTypeId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 关键词获取单位信息
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUnitNameByKeywords")]
        public MessageResult GetUnitNameByKeywords(string keywords)
        {
            try
            {
                var result = unitBLL.GetUnitNameByKeywords(keywords);
                return MessageResult.Success(result, result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        #endregion

        #region UnitType


        #region 删除
        /// <summary>
        /// 根据Id删除  这里id是主键  假删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("UnitTypeLogicDelete")]
        public MessageResult UnitTypeLogicDelete(int id)
        {
            try
            {
                var result = utBLL.LogicDelete(id);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 根据Id真删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="delType"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("UnitTypeDelete")]
        public MessageResult UnitTypeDelete(int id)
        {
            try
            {
                var result = utBLL.Delete(id);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 批量删除(真删除)
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UnitTypeDeleteList")]
        public MessageResult UnitTypeDeleteList(List<int> idList)
        {
            try
            {
                var result = utBLL.DeleteList(idList);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        [HttpPost]
        [Route("UnitTypeLogicDeleteList")]
        public MessageResult UnitTypeLogicDeleteList(List<int> idList)
        {
            try
            {
                var result = utBLL.LogicDeleteList(idList);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }




        #endregion

        #region 恢复
        /// <summary>
        /// 根据Id恢复  这里id是主键 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("UnitTypeRecover")]
        public MessageResult UnitTypeRecover(int id)
        {
            try
            {
                var result = utBLL.Recover(id);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 批量恢复  这里id是主键 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UnitTypeRecoverList")]
        public MessageResult UnitTypeRecoverList(List<int> ids)
        {
            try
            {
                var result = utBLL.DeleteList(ids);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion

        /// <summary>
        /// 获取所有的往来单位类别列表（绑定下拉框）
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("LoadAllDrpUnitTypes")]
        public MessageResult LoadAllDrpUnitTypes()
        {
            try
            {
                List<UnitTypeInfoModel> list = utBLL.LoadAllDrpUnitTypes();
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取所有的往来单位类别列表（绑定TreeView）
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("LoadAllTVUnitTypes")]
        public MessageResult LoadAllTVUnitTypes()
        {
            try
            {
                var list = utBLL.LoadAllTVUnitTypes();
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }

        }

        /// <summary>
        /// 获取指定的子类别列表
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllUnitTypes")]
        public MessageResult GetAllUnitTypes(string typeName)
        {
            try
            {
                var list = utBLL.GetAllUnitTypes(typeName);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 条件查询往来单位列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("LoadUnitTypeList")]
        public MessageResult LoadUnitTypeList(string keywords, bool blShowDel)
        {
            try
            {
                var list = utBLL.LoadUnitTypeList(keywords, blShowDel);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定的类别信息实体
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUnitType")]
        public MessageResult GetUnitType(int typeId)
        {
            try
            {
                var list = utBLL.GetUnitType(typeId);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 判断名称是否已存在
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ExistsUnitType")]
        public MessageResult ExistsUnitType(string typeName)
        {
            try
            {
                var list = utBLL.ExistsUnitType(typeName);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 添加往来单位类别信息
        /// </summary>
        /// <param name="utInfo"></param>
        /// <returns>类别编号</returns>
        [HttpPost]
        [Route("AddUnitType")]
        public MessageResult AddUnitType(UnitTypeInfoModel utInfo)
        {
            try
            {
                var list = utBLL.AddUnitType(utInfo);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 修改往来单位类别信息
        /// </summary>
        /// <param name="utInfo"></param>
        /// <param name="blUpdate"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateUnitType")]
        public MessageResult UpdateUnitType(UnitTypeInfoModelApi utInfo)
        {
            try
            {
                var list = utBLL.UpdateUnitType(utInfo.TypeInfoModel, utInfo.OldName);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 指定类别是否添加了子类别
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("IsAddChilds")]
        public MessageResult IsAddChilds(int typeId)
        {
            try
            {
                var result = utBLL.IsAddChilds(typeId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 是否添加了单位信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("IsAddUnits")]
        public MessageResult IsAddUnits(int typeId)
        {
            try
            {
                var result = utBLL.IsAddUnits(typeId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 关键词获取单位信息
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUTypeNameByKeywords")]
        public MessageResult GetUTypeNameByKeywords(string keywords)
        {
            try
            {
                var result = utBLL.GetUTypeNameByKeywords(keywords);
                return MessageResult.Success("单位信息", result);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion


    }
}
