using PSI.DAL;
using PSI.Models.DModels;
using PSI.Models.UIModels;
using PSI.Models.VModels;
using System.Collections.Generic;
using System.Data;

namespace PSI.BLL
{
    public class SaleOutStoreBLL
    {
        SaleOutStoreDAL saleDAL = new SaleOutStoreDAL();
        ViewSaleGoodsDAL vsgDAL = new ViewSaleGoodsDAL();


        /// <summary>
        /// 获取指定的销售单信息
        /// </summary>
        /// <param name="saleId"></param>
        /// <returns></returns>
        public SaleOutStoreInfoModel GetSaleInfo(int saleId)
        {
            return saleDAL.GetSaleOutStoreInfo(saleId);
        }

        /// <summary>
        /// 获取指定销售单据的商品明细列表
        /// </summary>
        /// <param name="saleId"></param>
        /// <returns></returns>
        public List<ViewSaleGoodsInfoModel> GetSaleGoodsList(int saleId)
        {
            return vsgDAL.GetSaleGoodsList(saleId);
        }

        /// <summary>
        /// 添加销售单
        /// </summary>
        /// <param name="saleInfo"></param>
        /// <param name="saleGoodsList"></param>
        /// <returns></returns>
        public string AddSaleInfo(SaleOutStoreInfoModel saleInfo, List<ViewSaleGoodsInfoModel> saleGoodsList)
        {
            List<SaleGoodsInfoModel> listGoods = ViewToSaleGoodsInfoModelList(saleGoodsList);
            return saleDAL.AddSaleOutStoreInfo(saleInfo, listGoods);
        }

        /// <summary>
        /// 修改销售单
        /// </summary>
        /// <param name="saleInfo"></param>
        /// <param name="saleGoodsList"></param>
        /// <returns></returns>
        public bool UpdateSaleInfo(SaleOutStoreInfoModel saleInfo, List<ViewSaleGoodsInfoModel> saleGoodsList)
        {
            List<SaleGoodsInfoModel> listGoods = ViewToSaleGoodsInfoModelList(saleGoodsList);
            return saleDAL.UpdateSaleOutStoreInfo(saleInfo, listGoods);
        }

        /// <summary>
        /// 审核指定的销售单
        /// </summary>
        /// <param name="saleId"></param>
        /// <param name="checkPerson"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool CheckSaleInfo(int saleId, string checkPerson, int storeId)
        {
            return saleDAL.CheckSaleInfo(saleId, checkPerson, storeId, 1);
        }

        /// <summary>
        /// 作废销售单
        /// </summary>
        /// <param name="saleId"></param>
        /// <returns></returns>
        public bool NoUseSaleInfo(int saleId)
        {
            return saleDAL.CheckSaleInfo(saleId, "", 0, 2);
        }

        /// <summary>
        /// 红冲
        /// </summary>
        /// <param name="saleId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool RedCheckSaleInfo(int saleId, int storeId)
        {
            return saleDAL.CheckSaleInfo(saleId, "", storeId, 3);
        }



        /// <summary>
        /// 将List<ViewSaleGoodsInfoModel>转换为 List<SaleGoodsInfoModel>
        /// </summary>
        /// <param name="vList"></param>
        /// <returns></returns>
        private List<SaleGoodsInfoModel> ViewToSaleGoodsInfoModelList(List<ViewSaleGoodsInfoModel> vList)
        {
            List<SaleGoodsInfoModel> list = new List<SaleGoodsInfoModel>();
            foreach (var vsg in vList)
            {
                list.Add(ViewToSaleGoodsInfoModel(vsg));
            }
            return list;
        }

        /// <summary>
        /// ViewSaleGoodsInfoModel 转换为 SaleGoodsInfoModel
        /// </summary>
        /// <param name="vsg"></param>
        /// <returns></returns>
        private SaleGoodsInfoModel ViewToSaleGoodsInfoModel(ViewSaleGoodsInfoModel vModel)
        {
            SaleGoodsInfoModel sg = new SaleGoodsInfoModel()
            {
                SaleId = vModel.SaleId,
                GoodsId = vModel.GoodsId,
                Count = vModel.Count,
                GUnit = vModel.GUnit,
                SalePrice = vModel.SalePrice,
                Amount = vModel.Amount,
                Remark = vModel.Remark
            };
            return sg;
        }

        #region 销售数据统计

        ViewSaleGoodsQueryDAL vsgqDAL = new ViewSaleGoodsQueryDAL();
        /// <summary>
        /// 按客户统计销售数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageModel<SaleQueryCustomerModel> GetSaleDataByCustomer(QueryParaModel paraModel, int startIndex, int pageSize)
        {
            DataSet ds = vsgqDAL.GetSaleData(1, paraModel, startIndex, pageSize);
            BQuery<SaleQueryCustomerModel> bq = new BQuery<SaleQueryCustomerModel>();
            PageModel<SaleQueryCustomerModel> pageModel = bq.DsToPageModel<SaleQueryCustomerModel>(ds, "");
            return pageModel;
        }

        /// <summary>
        /// 按仓库统计销售数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageModel<SaleQueryStoreModel> GetSaleDataByStore(QueryParaModel paraModel, int startIndex, int pageSize)
        {
            DataSet ds = vsgqDAL.GetSaleData(2, paraModel, startIndex, pageSize);
            BQuery<SaleQueryStoreModel> bq = new BQuery<SaleQueryStoreModel>();
            PageModel<SaleQueryStoreModel> pageModel = bq.DsToPageModel<SaleQueryStoreModel>(ds, "");
            return pageModel;
        }

        /// <summary>
        /// 按商品统计销售数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageModel<SaleQueryGoodsModel> GetSaleDataByGoods(QueryParaModel paraModel, int startIndex, int pageSize)
        {
            DataSet ds = vsgqDAL.GetSaleData(3, paraModel, startIndex, pageSize);
            BQuery<SaleQueryGoodsModel> bq = new BQuery<SaleQueryGoodsModel>();
            PageModel<SaleQueryGoodsModel> pageModel = bq.DsToPageModel<SaleQueryGoodsModel>(ds, "");
            return pageModel;
        }
        #endregion
    }
}
