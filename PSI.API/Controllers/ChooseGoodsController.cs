using PSI.BLL;
using PSI.Models.APIModels;
using PSI.Models.DModels;
using PSI.Models.UIModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace PSI.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/choose")]
    public class ChooseGoodsController : ApiController
    {
        private GoodsBLL goodsBLL = new GoodsBLL();
        private GoodsTypeBLL gtBLL = new GoodsTypeBLL();
        private StoreBLL storeBLL = new StoreBLL();
        private StoreTypeBLL stBLL = new StoreTypeBLL();
        private GoodsUnitBLL goodsUnitBLL = new GoodsUnitBLL();

        #region Goods商品


        [HttpPost]
        [Route("GoodsList")]
        public MessageResult GoodsList(PageInfo pageInfo)
        {
            try
            {
                PageModel<ViewGoodsInfoModel> list = goodsBLL.LoadGoodsList(pageInfo.KeyId, pageInfo.KeyWord, pageInfo.IsStopped, pageInfo.IsShowDel, pageInfo.StartIndex, pageInfo.PageSize);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }


        /// <summary>
        /// 获取商品列表
        /// </summary>
        /// <param name="gtypeId"></param>
        /// <param name="keywords"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetGoodsList")]
        public MessageResult GetGoodsList(int gtypeId, string keywords)
        {
            try
            {
                List<ViewGoodsInfoModel> list = goodsBLL.GetGoodsList(gtypeId, keywords);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }

        }

        [HttpGet]
        [Route("GetGoodsInfo")]
        public MessageResult GetGoodsInfo(int goodsId)
        {
            try
            {
                GoodsInfoModel info = goodsBLL.GetGoodsInfo(goodsId); ;
                return MessageResult.Success(info);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }

        }
        /// <summary>
        /// 删除多个商品
        /// </summary>
        /// <param name="goodsIds"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteGoodsInfos")]
        public MessageResult DeleteGoodsInfos(ReqQueryInfo reqQueryInfo)
        {
            bool rsult = goodsBLL.DeleteGoodsInfos(reqQueryInfo.KeyIds);
            if (rsult)
            {
                return MessageResult.Success("删除成功");
            }
            else
            {
                return MessageResult.Fail("删除失败");
            }
        }

        /// <summary>
        /// 单个商品删除
        /// </summary>
        /// <param name="goodsIds"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteGoodsInfo")]
        public MessageResult DeleteGoodsInfo(int goodsId)
        {
            bool rsult = goodsBLL.DeleteGoodsInfo(goodsId);
            if (rsult)
            {
                return MessageResult.Success("删除成功");
            }
            else
            {
                return MessageResult.Fail("删除失败");
            }
        }

        /// <summary>
        /// 批量恢复商品信息
        /// </summary>
        /// <param name="goodsIds"></param>
        /// <param name="uName"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RecoverGoodsInfos")]
        public MessageResult RecoverGoodsInfos(ReqQueryInfo reqQueryInfo)
        {
            bool rsult = goodsBLL.RecoverGoodsInfos(reqQueryInfo.KeyIds, reqQueryInfo.Name);
            if (rsult)
            {
                return MessageResult.Success();
            }
            else
            {
                return MessageResult.Fail();
            }
        }

        /// <summary>
        /// 恢复单个信息
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="uName"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RecoverGoodsInfo")]
        public MessageResult RecoverGoodsInfo(int goodsId, string uName)
        {
            bool rsult = goodsBLL.RecoverGoodsInfo(goodsId, uName);
            if (rsult)
            {
                return MessageResult.Success();
            }
            else
            {
                return MessageResult.Fail();
            }
        }


        [HttpPost]
        [Route("RemoveGoodsInfos")]
        public MessageResult RemoveGoodsInfos(List<int> goodsIds)
        {
            bool rsult = goodsBLL.RemoveGoodsInfos(goodsIds);
            if (rsult)
            {
                return MessageResult.Success();
            }
            else
            {
                return MessageResult.Fail();
            }
        }


        [HttpPost]
        [Route("RemoveGoodsInfo")]
        public MessageResult RemoveGoodsInfo(int goodsId)
        {
            bool rsult = goodsBLL.RemoveGoodsInfo(goodsId);
            if (rsult)
            {
                return MessageResult.Success();
            }
            else
            {
                return MessageResult.Fail();
            }
        }

        [HttpPost]
        [Route("CheckIsGoodsUse")]
        public MessageResult CheckIsGoodsUse(int goodsId)
        {
            bool rsult = goodsBLL.CheckIsGoodsUse(goodsId);
            if (rsult)
            {
                return MessageResult.Success();
            }
            else
            {
                return MessageResult.Fail();
            }
        }

        [HttpPost]
        [Route("AddGoodsInfo")]
        public MessageResult AddGoodsInfo(GoodsInfoModel goodsInfo)
        {
            bool rsult = goodsBLL.AddGoodsInfo(goodsInfo);
            if (rsult)
            {
                return MessageResult.Success();
            }
            else
            {
                return MessageResult.Fail();
            }
        }

        [HttpPost]
        [Route("UpdateGoodsInfo")]
        public MessageResult UpdateGoodsInfo(GoodsInfoModel goodsInfo)
        {
            bool rsult = goodsBLL.UpdateGoodsInfo(goodsInfo);
            if (rsult)
            {
                return MessageResult.Success();
            }
            else
            {
                return MessageResult.Fail();
            }
        }


        [HttpPost]
        [Route("ExistGoodsName")]
        public MessageResult ExistGoodsName(string goodsName)
        {
            bool rsult = goodsBLL.ExistGoodsName(goodsName);
            if (rsult)
            {
                return MessageResult.Success();
            }
            else
            {
                return MessageResult.Fail();
            }
        }


        [HttpPost]
        [Route("GetGoodsInfoByKeywords")]
        public MessageResult GetGoodsInfoByKeywords(string keywords)
        {
            var rsult = goodsBLL.GetGoodsInfoByKeywords(keywords);
            return MessageResult.Success("ok", rsult);
        }


        [HttpPost]
        [Route("GetGoodsListByTypeId")]
        public MessageResult GetGoodsListByTypeId(int typeId)
        {
            List<GoodsInfoModel> rsult = goodsBLL.GetGoodsListByTypeId(typeId);
            if (rsult != null)
            {
                return MessageResult.Success(rsult);
            }
            else
            {
                return MessageResult.Fail();
            }
        }

        /// <summary>
        /// 加载所有商品类别
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllGoodsTypes")]
        public MessageResult GetAllGoodsTypes()
        {
            try
            {
                var list = gtBLL.LoadAllGoodsTypes();
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }



        /// <summary>
        /// 加载商品类别信息（模糊查询）
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("LoadAllGoodsTypeList")]
        public MessageResult LoadAllGoodsTypeList(string keywords, bool blShow)
        {
            try
            {
                var list = gtBLL.LoadAllGoodsTypeList(keywords, blShow);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }



        /// <summary>
        /// 获取指定商品类别信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetGoodsType")]
        public MessageResult GetGoodsType(int typeId)
        {
            try
            {
                var list = gtBLL.GetGoodsType(typeId);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 检查该商品类别是否已添加商品
        /// </summary>
        /// <param name="gtypeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("CheckIsAddGoods")]
        public MessageResult CheckIsAddGoods(int gtypeId)
        {
            try
            {
                var list = gtBLL.CheckIsAddGoods(gtypeId);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 检查该商品类别是否已添加子类别
        /// </summary>
        /// <param name="gTypeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("HasChildTypes")]
        public MessageResult HasChildTypes(int gTypeId)
        {
            try
            {
                var list = gtBLL.HasChildTypes(gTypeId);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 检查类别名称是否已存在
        /// </summary>
        /// <param name="gtypeName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ExistName")]
        public MessageResult ExistName(string gtypeName)
        {
            try
            {
                var list = gtBLL.ExistName(gtypeName);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 添加商品类别
        /// </summary>
        /// <param name="gtInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddGoodsType")]
        public MessageResult AddGoodsType(GoodsTypeInfoModel gtInfo)
        {
            try
            {
                var list = gtBLL.AddGoodsType(gtInfo);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 更新商品类别信息
        /// </summary>
        /// <param name="gtInfo"></param>
        /// <param name="blUpdate"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateGoodsType")]
        public MessageResult UpdateGoodsType(GoodsTypeInfoApi goodsTypeInfoApi)
        {
            try
            {
                var list = gtBLL.UpdateGoodsType(goodsTypeInfoApi.TypeInfoModel, goodsTypeInfoApi.OldName);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        //GoodsType 删除恢复

        #region 删除
        /// <summary>
        /// 根据Id删除  这里id是主键  假删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GoodsTypeLogicDelete")]
        public MessageResult GoodsTypeLogicDelete(int id)
        {
            try
            {
                var result = gtBLL.LogicDelete(id);
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
        [Route("GoodsTypeDelete")]
        public MessageResult GoodsTypeDelete(int id)
        {
            try
            {
                var result = gtBLL.Delete(id);
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
        [Route("GoodsTypeDeleteList")]
        public MessageResult GoodsTypeDeleteList(List<int> idList)
        {
            try
            {
                var result = gtBLL.DeleteList(idList);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        [HttpPost]
        [Route("GoodsTypeLogicDeleteList")]
        public MessageResult GoodsTypeLogicDeleteList(List<int> idList)
        {
            try
            {
                var result = gtBLL.LogicDeleteList(idList);
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
        [Route("GoodsTypeRecover")]
        public MessageResult GoodsTypeRecover(int id)
        {
            try
            {
                var result = gtBLL.Recover(id);
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
        [Route("GoodsTypeRecoverList")]
        public MessageResult GoodsTypeRecoverList(List<int> ids)
        {
            try
            {
                var result = gtBLL.DeleteList(ids);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion



        #endregion


        #region GoodsUnit
        /// <summary>
        ///  获取所有的单位列表
        /// </summary>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllUnits")]
        public MessageResult GetAllUnits(int isDeleted)
        {
            try
            {
                var result = goodsUnitBLL.GetAllUnits(isDeleted);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        //删除（真假 多个 、单个）  恢复   
        #region 删除
        /// <summary>
        /// 根据Id删除  这里id是主键  假删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GoodsUnitLogicDelete")]
        public MessageResult GoodsUnitLogicDelete(int id)
        {
            try
            {
                var result = gtBLL.LogicDelete(id);
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
        [Route("GoodsUnitDelete")]
        public MessageResult GoodsUnitDelete(int id)
        {
            try
            {
                var result = gtBLL.Delete(id);
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
        [Route("GoodsUnitDeleteList")]
        public MessageResult GoodsUnitDeleteList(List<int> idList)
        {
            try
            {
                var result = gtBLL.DeleteList(idList);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        [HttpPost]
        [Route("GoodsUnitLogicDeleteList")]
        public MessageResult GoodsUnitLogicDeleteList(List<int> idList)
        {
            try
            {
                var result = gtBLL.LogicDeleteList(idList);
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
        [Route("GoodsUnitRecover")]
        public MessageResult GoodsUnitRecover(int id)
        {
            try
            {
                var result = gtBLL.Recover(id);
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
        [Route("GoodsUnitRecoverList")]
        public MessageResult GoodsUnitRecoverList(List<int> ids)
        {
            try
            {
                var result = gtBLL.DeleteList(ids);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion



        /// <summary>
        /// 检查是否有商品已应用该单位
        /// </summary>
        /// <param name="unitName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetGoodsUnitUse")]
        public MessageResult GetGoodsUnitUse(string unitName)
        {
            try
            {
                var result = goodsUnitBLL.GetGoodsUnitUse(unitName);
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
        /// <param name="guInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddGoodsUnit")]
        public MessageResult AddGoodsUnit(GoodsUnitInfoModel guInfo)
        {
            try
            {
                var result = goodsUnitBLL.AddGoodsUnit(guInfo);
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
        /// <param name="guInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdatGoodsUnit")]
        public MessageResult UpdatGoodsUnit(GoodsUnitInfoApi goodsUnitInfoApi)
        {
            try
            {
                var result = goodsUnitBLL.UpdatGoodsUnit(goodsUnitInfoApi.GoodsUnitInfoModel, goodsUnitInfoApi.IsUpdateName, goodsUnitInfoApi.OldName);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 判断单位名称是否已存在
        /// </summary>
        /// <param name="unitName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GoodsUnitExistName")]
        public MessageResult GoodsUnitExistName(string unitName)
        {
            try
            {
                var result = goodsUnitBLL.ExistName(unitName);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion

        #region Store商店

        [HttpGet]
        [Route("GetStoreList")]
        public MessageResult GetStoreList(int sTypeId, string keywords, bool isShowDel)
        {
            try
            {
                var list = storeBLL.LoadStoreList(sTypeId, keywords, isShowDel);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }


        [HttpGet]
        [Route("GetAllDrpStoreTypes")]
        public MessageResult GetAllDrpStoreTypes()
        {
            try
            {
                var list = stBLL.LoadAllDrpStoreTypes();
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }



        [HttpGet]
        [Route("LoadAllStores")]
        public MessageResult LoadAllStores()
        {
            try
            {
                var list = storeBLL.LoadAllStores();
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 检查仓库是否在使用中
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("CheckStoreUse")]
        public MessageResult CheckStoreUse(int storeId)
        {
            try
            {
                var list = storeBLL.CheckStoreUse(storeId);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定的仓库信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStoreInfo")]
        public MessageResult GetStoreInfo(int storeId)
        {
            try
            {
                var list = storeBLL.GetStoreInfo(storeId);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 单个仓库的删除 
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteStoreInfo")]
        public MessageResult DeleteStoreInfo(int storeId)
        {
            try
            {
                var list = storeBLL.DeleteStoreInfo(storeId);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 批量仓库的删除 
        /// </summary>
        /// <param name="storeIds"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteStoreInfos")]
        public MessageResult DeleteStoreInfos(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var list = storeBLL.DeleteStoreInfos(reqQueryInfo.KeyIds);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }


        /// <summary>
        /// 批量恢复仓库信息
        /// </summary>
        /// <param name="goodsIds"></param>
        /// <param name="uName"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RecoverStoreInfos")]
        public MessageResult RecoverStoreInfos(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var list = storeBLL.RecoverStoreInfos(reqQueryInfo.KeyIds, reqQueryInfo.Name);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 单个仓库的恢复
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("RecoverStoreInfo")]
        public MessageResult RecoverStoreInfo(int storeId, string uName)
        {
            try
            {
                var list = storeBLL.RecoverStoreInfo(storeId, uName);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 批量移除仓库信息
        /// </summary>
        /// <param name="storeIds"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RemoveStoreInfos")]
        public MessageResult RemoveStoreInfos(ReqQueryInfo reqQueryInfo)
        {
            try
            {
                var list = storeBLL.RemoveStoreInfos(reqQueryInfo.KeyIds);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 单个仓库的移除
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("RemoveStoreInfo")]
        public MessageResult RemoveStoreInfo(int storeId)
        {
            try
            {
                var list = storeBLL.RemoveStoreInfo(storeId);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 判断仓库是否已存在（同一类别下不能重名）
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="sTypeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ExistsStore")]
        public MessageResult ExistsStore(string storeName, int sTypeId)
        {
            try
            {
                var list = storeBLL.ExistsStore(storeName, sTypeId);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 修改仓库信息
        /// </summary>
        /// <param name="storeInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateStoreInfo")]
        public MessageResult UpdateStoreInfo(StoreInfoModel storeInfo)
        {
            try
            {
                var list = storeBLL.UpdateStoreInfo(storeInfo);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 添加仓库信息
        /// </summary>
        /// <param name="storeInfo"></param>
        /// <param name="goodsIds">所有商品的编号集合</param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddStoreInfo")]
        public MessageResult AddStoreInfo(StoreInfoModel storeInfo)
        {
            try
            {
                var list = storeBLL.AddStoreInfo(storeInfo);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }



        //StoreType stBLL
        /// <summary>
        /// 判断指定类别是否添加了仓库
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("IsAddStores")]
        public MessageResult IsAddStores(int typeId)
        {
            try
            {
                var list = stBLL.IsAddStores(typeId);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 加载所有的仓库类别信息
        /// </summary>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("LoadAllStoreTypes")]
        public MessageResult LoadAllStoreTypes(bool isShowDel)
        {
            try
            {
                var list = stBLL.LoadAllStoreTypes(isShowDel);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取所有有效的类别（编号、名称）---用于绑定下拉框或TreeView
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("LoadAllDrpStoreTypes")]
        public MessageResult LoadAllDrpStoreTypes()
        {
            try
            {
                var list = stBLL.LoadAllDrpStoreTypes();
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定类别信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStoreType")]
        public MessageResult GetStoreType(int typeId)
        {
            try
            {
                var list = stBLL.GetStoreType(typeId);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 判断类别名称是否已存在
        /// </summary>
        /// <param name="storeName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ExistsStoreType")]
        public MessageResult ExistsStoreType(string storeName)
        {
            try
            {
                var list = stBLL.ExistsStoreType(storeName);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 新增仓库类别信息
        /// </summary>
        /// <param name="storeTypeInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddStoreType")]
        public MessageResult AddStoreType(StoreTypeInfoModel storeTypeInfo)
        {
            try
            {
                var list = stBLL.AddStoreType(storeTypeInfo);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 修改仓库类别信息
        /// </summary>
        /// <param name="storeTypeInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateStoreType")]
        public MessageResult UpdateStoreType(StoreTypeInfoModel storeTypeInfo)
        {
            try
            {
                var list = stBLL.UpdateStoreType(storeTypeInfo);
                return MessageResult.Success(list);
            }
            catch (Exception ex)
            {

                return MessageResult.Fail(ex.Message);
            }
        }

        //删除（真假 多个 、单个）  恢复   
        #region 删除
        /// <summary>
        /// 根据Id删除  这里id是主键  假删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("StoreTypeLogicDelete")]
        public MessageResult StoreTypeLogicDelete(int id)
        {
            try
            {
                var result = stBLL.LogicDelete(id);
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
        [Route("StoreTypeDelete")]
        public MessageResult StoreTypeDelete(int id)
        {
            try
            {
                var result = stBLL.Delete(id);
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
        [Route("StoreTypeDeleteList")]
        public MessageResult StoreTypeDeleteList(List<int> idList)
        {
            try
            {
                var result = stBLL.DeleteList(idList);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        [HttpPost]
        [Route("StoreTypeLogicDeleteList")]
        public MessageResult StoreTypeLogicDeleteList(List<int> idList)
        {
            try
            {
                var result = stBLL.LogicDeleteList(idList);
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
        [Route("StoreTypeRecover")]
        public MessageResult StoreTypeRecover(int id)
        {
            try
            {
                var result = stBLL.Recover(id);
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
        [Route("StoreTypeRecoverList")]
        public MessageResult StoreTypeRecoverList(List<int> ids)
        {
            try
            {
                var result = stBLL.DeleteList(ids);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion


        #endregion
    }
}
