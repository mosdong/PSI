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
           bool rsult= goodsBLL.DeleteGoodsInfos(reqQueryInfo.KeyIds);
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
        [Route("RemoveGoodsInfos")]
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
            return MessageResult.Success("ok",rsult);
        }


        [HttpPost]
        [Route("GetGoodsListByTypeId")]
        public MessageResult GetGoodsListByTypeId(int typeId)
        {
            List<GoodsInfoModel> rsult = goodsBLL.GetGoodsListByTypeId(typeId);
            if (rsult!=null)
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

        #endregion
    }
}
