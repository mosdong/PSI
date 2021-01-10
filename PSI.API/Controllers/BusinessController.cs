using PSI.BLL;
using PSI.Models.APIModels;
using PSI.Models.UIModels;
using System;
using System.Web.Http;

namespace PSI.API.Controllers
{
    [RoutePrefix("api/business")]
    public class BusinessController : ApiController
    {
        PerchaseInStoreBLL perchaseInStoreBLL = new PerchaseInStoreBLL();
        SaleOutStoreBLL saleOutStoreBLL = new SaleOutStoreBLL();
        StockBLL stockBLL = new StockBLL();

        #region PerchaseInStore
        /// <summary>
        /// 获取指定的采购单信息
        /// </summary>
        /// <param name="perId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetPerchaseInfo")]
        public MessageResult GetPerchaseInfo(int perId)
        {
            try
            {
                var result = perchaseInStoreBLL.GetPerchaseInfo(perId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定单据的商品明细列表
        /// </summary>
        /// <param name="perId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetPerGoodsList")]
        public MessageResult GetPerGoodsList(int perId)
        {
            try
            {
                var result = perchaseInStoreBLL.GetPerGoodsList(perId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 添加采购单
        /// </summary>
        /// <param name="perInfo"></param>
        /// <param name="perGoodsList"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddPerchaseInfo")]
        public MessageResult AddPerchaseInfo(PerchaseInStoreInfoApi perchaseInStoreInfoApi)
        {
            try
            {
                var result = perchaseInStoreBLL.AddPerchaseInfo(perchaseInStoreInfoApi.perchaseInStoreInfoModel, perchaseInStoreInfoApi.viewPerGoodsInfoModels);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 修改采购单
        /// </summary>
        /// <param name="perInfo"></param>
        /// <param name="perGoodsList"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdatePerchaseInfo")]
        public MessageResult UpdatePerchaseInfo(PerchaseInStoreInfoApi perchaseInStoreInfoApi)
        {
            try
            {
                var result = perchaseInStoreBLL.UpdatePerchaseInfo(perchaseInStoreInfoApi.perchaseInStoreInfoModel, perchaseInStoreInfoApi.viewPerGoodsInfoModels);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 审核指定的采购单
        /// </summary>
        /// <param name="perId"></param>
        /// <param name="checkPerson"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("CheckPerchaseInfo")]
        public MessageResult CheckPerchaseInfo(int perId, string checkPerson, int storeId)
        {
            try
            {
                var result = perchaseInStoreBLL.CheckPerchaseInfo(perId, checkPerson, storeId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 作废采购单
        /// </summary>
        /// <param name="perId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("NoUsePerchaseInfo")]
        public MessageResult NoUsePerchaseInfo(int perId)
        {
            try
            {
                var result = perchaseInStoreBLL.NoUsePerchaseInfo(perId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 红冲
        /// </summary>
        /// <param name="perId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("RedCheckPerchaseInfo")]
        public MessageResult RedCheckPerchaseInfo(int perId, int storeId)
        {
            try
            {
                var result = perchaseInStoreBLL.RedCheckPerchaseInfo(perId, storeId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }





        #region 采购统计

        /// <summary>
        /// 按供应商统计采购数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetPerDataBySupplier")]
        public MessageResult GetPerDataBySupplier(PageInfo pageInfo)
        {
            try
            {
                var result = perchaseInStoreBLL.GetPerDataBySupplier(pageInfo.QueryParaModel, pageInfo.StartIndex, pageInfo.PageSize);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 按仓库统计采购数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetPerDataByStore")]
        public MessageResult GetPerDataByStore(PageInfo pageInfo)
        {
            try
            {
                var result = perchaseInStoreBLL.GetPerDataByStore(pageInfo.QueryParaModel, pageInfo.StartIndex, pageInfo.PageSize);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 按商品统计采购数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetPerDataByGoods")]
        public MessageResult GetPerDataByGoods(PageInfo pageInfo)
        {
            try
            {
                var result = perchaseInStoreBLL.GetPerDataByGoods(pageInfo.QueryParaModel, pageInfo.StartIndex, pageInfo.PageSize);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion
        #endregion

        #region SaleOutStore
        /// <summary>
        /// 获取指定的销售单信息
        /// </summary>
        /// <param name="saleId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSaleInfo")]
        public MessageResult GetSaleInfo(int saleId)
        {
            try
            {
                var result = saleOutStoreBLL.GetSaleInfo(saleId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定销售单据的商品明细列表
        /// </summary>
        /// <param name="saleId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSaleGoodsList")]
        public MessageResult GetSaleGoodsList(int saleId)
        {
            try
            {
                var result = saleOutStoreBLL.GetSaleGoodsList(saleId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 添加销售单
        /// </summary>
        /// <param name="saleInfo"></param>
        /// <param name="saleGoodsList"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddSaleInfo")]
        public MessageResult AddSaleInfo(SaleOutStoreInfoApi saleOutStoreInfoApi)
        {
            try
            {
                var result = saleOutStoreBLL.AddSaleInfo(saleOutStoreInfoApi.saleOutStoreInfoModel, saleOutStoreInfoApi.viewSaleGoodsInfoModels);
                return MessageResult.Success(result, result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 修改销售单
        /// </summary>
        /// <param name="saleInfo"></param>
        /// <param name="saleGoodsList"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateSaleInfo")]
        public MessageResult UpdateSaleInfo(SaleOutStoreInfoApi saleOutStoreInfoApi)
        {
            try
            {
                var result = saleOutStoreBLL.UpdateSaleInfo(saleOutStoreInfoApi.saleOutStoreInfoModel, saleOutStoreInfoApi.viewSaleGoodsInfoModels);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 审核指定的销售单
        /// </summary>
        /// <param name="saleId"></param>
        /// <param name="checkPerson"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("CheckSaleInfo")]
        public MessageResult CheckSaleInfo(int saleId, string checkPerson, int storeId)
        {
            try
            {
                var result = saleOutStoreBLL.CheckSaleInfo(saleId, checkPerson, storeId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 作废销售单
        /// </summary>
        /// <param name="saleId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("NoUseSaleInfo")]
        public MessageResult NoUseSaleInfo(int saleId)
        {
            try
            {
                var result = saleOutStoreBLL.NoUseSaleInfo(saleId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 红冲
        /// </summary>
        /// <param name="saleId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("RedCheckSaleInfo")]
        public MessageResult RedCheckSaleInfo(int saleId, int storeId)
        {
            try
            {
                var result = saleOutStoreBLL.RedCheckSaleInfo(saleId, storeId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }





        #region 销售数据统计

        /// <summary>
        /// 按客户统计销售数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetSaleDataByCustomer")]
        public MessageResult GetSaleDataByCustomer(PageInfo pageInfo)
        {
            try
            {
                var result = saleOutStoreBLL.GetSaleDataByCustomer(pageInfo.QueryParaModel, pageInfo.StartIndex, pageInfo.PageSize);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 按仓库统计销售数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetSaleDataByStore")]
        public MessageResult GetSaleDataByStore(PageInfo pageInfo)
        {
            try
            {
                var result = saleOutStoreBLL.GetSaleDataByStore(pageInfo.QueryParaModel, pageInfo.StartIndex, pageInfo.PageSize);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 按商品统计销售数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetSaleDataByGoods")]
        public MessageResult GetSaleDataByGoods(PageInfo pageInfo)
        {
            try
            {
                var result = saleOutStoreBLL.GetSaleDataByGoods(pageInfo.QueryParaModel, pageInfo.StartIndex, pageInfo.PageSize);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion
        #endregion

        #region Stock
        /// <summary>
        /// 获取指定的入库单信息
        /// </summary>
        /// <param name="stockId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStockInfo")]
        public MessageResult GetStockInfo(int stockId)
        {
            try
            {
                var result = stockBLL.GetStockInfo(stockId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定单据的商品明细列表
        /// </summary>
        /// <param name="stockId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStockGoodsList")]
        public MessageResult GetStockGoodsList(int stockId)
        {
            try
            {
                var result = stockBLL.GetStockGoodsList(stockId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 添加入库单
        /// </summary>
        /// <param name="stockInfo"></param>
        /// <param name="stockGoodsList"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddStockInfo")]
        public MessageResult AddStockInfo(StockStoreInfoApi stockStoreInfoApi)
        {
            try
            {
                var result = stockBLL.AddStockInfo(stockStoreInfoApi.stockStoreInfoModel, stockStoreInfoApi.stockGoodsList);
                return MessageResult.Success(result, result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 修改入库单
        /// </summary>
        /// <param name="stockInfo"></param>
        /// <param name="stockGoodsList"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateStockInfo")]
        public MessageResult UpdateStockInfo(StockStoreInfoApi stockStoreInfoApi)
        {
            try
            {
                var result = stockBLL.UpdateStockInfo(stockStoreInfoApi.stockStoreInfoModel, stockStoreInfoApi.stockGoodsList);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 审核指定的入库单
        /// </summary>
        /// <param name="stockId"></param>
        /// <param name="checkPerson"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("CheckStockInfo")]
        public MessageResult CheckStockInfo(int stockId, string checkPerson, int storeId)
        {
            try
            {
                var result = stockBLL.CheckStockInfo(stockId, checkPerson, stockId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 作废入库单
        /// </summary>
        /// <param name="stockId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("NoUseStockInfo")]
        public MessageResult NoUseStockInfo(int stockId)
        {
            try
            {
                var result = stockBLL.NoUseStockInfo(stockId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 红冲
        /// </summary>
        /// <param name="stockId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("RedCheckStockInfo")]
        public MessageResult RedCheckStockInfo(int stockId, int storeId)
        {
            try
            {
                var result = stockBLL.RedCheckStockInfo(stockId, storeId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 检查商品（多个）库存量
        /// </summary>
        /// <param name="listGoods"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CheckGoodsCurCount")]
        public MessageResult CheckGoodsCurCount(ViewSaleGoodsInfoApi viewSaleGoodsInfoApi)
        {
            try
            {
                var result = stockBLL.CheckGoodsCurCount(viewSaleGoodsInfoApi.ViewSaleGoodsInfoModels, viewSaleGoodsInfoApi.StoreId);
                return MessageResult.Success(result, result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }



        #region 库存查询统计

        /// <summary>
        /// 获取商品库存统计数据
        /// </summary>
        /// <param name="qModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetStoreStockData")]
        public MessageResult GetStoreStockData(StockQueryParaModel qModel)
        {
            try
            {
                var result = stockBLL.GetStoreStockData(qModel);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定商品的库存分布
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="storeId"></param>
        /// <param name="storeName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetGoodsStoreStock")]
        public MessageResult GetGoodsStoreStock(int goodsId, int storeId, string storeName)
        {
            try
            {
                var result = stockBLL.GetGoodsStoreStock(goodsId, storeId, storeName);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 获取指定商品的库存变动明细
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="storeId"></param>
        /// <param name="storeName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetGoodsStockChangeList")]
        public MessageResult GetGoodsStockChangeList(int goodsId, int storeId, string storeName)
        {
            try
            {
                var result = stockBLL.GetGoodsStockChangeList(goodsId, storeId, storeName);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }
        #endregion

        #region 库存上下限设置

        /// <summary>
        /// 获取商品上下限列表
        /// </summary>
        /// <param name="gTypeId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetGoodsStockUpDownList")]
        public MessageResult GetGoodsStockUpDownList(int gTypeId, int storeId)
        {
            try
            {
                var result = stockBLL.GetGoodsStockUpDownList(gTypeId, storeId);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 保存库存上下限
        /// </summary>
        /// <param name="goodsStockUpdownList"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("SetGoodsStockUpDown")]
        public MessageResult SetGoodsStockUpDown(ViewStoreStockUpDownApi viewStoreStockUpDownApi)
        {
            try
            {
                var result = stockBLL.SetGoodsStockUpDown(viewStoreStockUpDownApi.viewStoreStockUpDownModels);
                return MessageResult.Success(result);
            }
            catch (Exception ex)
            {
                return MessageResult.Fail(ex.Message);
            }
        }

        /// <summary>
        /// 批量保存库存上下限设置（设置统一的上限下限）
        /// </summary>
        /// <param name="goodsStockUpdownList"></param>
        /// <param name="up"></param>
        /// <param name="down"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("SetMoreGoodsStockUpDown")]
        public MessageResult SetMoreGoodsStockUpDown(ViewStoreStockUpDownApi viewStoreStockUpDownApi)
        {
            try
            {
                var result = stockBLL.SetMoreGoodsStockUpDown(viewStoreStockUpDownApi.viewStoreStockUpDownModels, viewStoreStockUpDownApi.up, viewStoreStockUpDownApi.down);
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
