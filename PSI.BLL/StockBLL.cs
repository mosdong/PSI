using PSI.Common;
using PSI.DAL;
using PSI.Models.DModels;
using PSI.Models.UIModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI.BLL
{
      public  class StockBLL
        {
                StockStoreDAL stockStoreDAL = new StockStoreDAL();
                ViewStStockGoodsDAL vssgDAL = new ViewStStockGoodsDAL();
                StoreGoodsStockDAL sgsDAL = new StoreGoodsStockDAL();
                StockChangeDAL sgDAL = new StockChangeDAL();
                ViewStoreStockUpDownDAL vssudDAL = new ViewStoreStockUpDownDAL();
                /// <summary>
                /// 获取指定的入库单信息
                /// </summary>
                /// <param name="stockId"></param>
                /// <returns></returns>
                public StockStoreInfoModel GetStockInfo(int stockId)
                {
                        return stockStoreDAL.GetStockInfo(stockId);
                }

                /// <summary>
                /// 获取指定单据的商品明细列表
                /// </summary>
                /// <param name="stockId"></param>
                /// <returns></returns>
                public List<ViewStStockGoodsInfoModel> GetStockGoodsList(int stockId)
                {
                        return vssgDAL.GetStockGoodsList(stockId);
                }

                /// <summary>
                /// 添加入库单
                /// </summary>
                /// <param name="stockInfo"></param>
                /// <param name="stockGoodsList"></param>
                /// <returns></returns>
                public  string AddStockInfo(StockStoreInfoModel stockInfo,List<ViewStStockGoodsInfoModel> stockGoodsList)
                {
                        List<StStockGoodsInfoModel> listGoods = ViewToStStockGoodsInfoModelList(stockGoodsList);
                        return stockStoreDAL.AddStockInfo(stockInfo, listGoods);
                }

                /// <summary>
                /// 修改入库单
                /// </summary>
                /// <param name="stockInfo"></param>
                /// <param name="stockGoodsList"></param>
                /// <returns></returns>
                public bool UpdateStockInfo(StockStoreInfoModel stockInfo, List<ViewStStockGoodsInfoModel> stockGoodsList)
                {
                        List<StStockGoodsInfoModel> listGoods = ViewToStStockGoodsInfoModelList(stockGoodsList);
                        return stockStoreDAL.UpdateStockInfo(stockInfo, listGoods);
                }

                /// <summary>
                /// 审核指定的入库单
                /// </summary>
                /// <param name="stockId"></param>
                /// <param name="checkPerson"></param>
                /// <param name="storeId"></param>
                /// <returns></returns>
                public bool CheckStockInfo(int stockId,string checkPerson,int storeId)
                {
                        return stockStoreDAL.CheckStockInfo(stockId, checkPerson, storeId, 1);
                }

                /// <summary>
                /// 作废入库单
                /// </summary>
                /// <param name="stockId"></param>
                /// <returns></returns>
                public bool NoUseStockInfo(int stockId)
                {
                        return stockStoreDAL.CheckStockInfo(stockId, "", 0, 2);
                }

                /// <summary>
                /// 红冲
                /// </summary>
                /// <param name="stockId"></param>
                /// <param name="storeId"></param>
                /// <returns></returns>
                public bool RedCheckStockInfo(int stockId,int storeId)
                {
                        return stockStoreDAL.CheckStockInfo(stockId, "", storeId, 3);
                }

                /// <summary>
                /// 检查商品（多个）库存量
                /// </summary>
                /// <param name="listGoods"></param>
                /// <param name="storeId"></param>
                /// <returns></returns>
                public string CheckGoodsCurCount(List<ViewSaleGoodsInfoModel> listGoods,int storeId)
                {
                        string reStr = "";
                        List<int> goodsIds = listGoods.Select(vg => vg.GoodsId).ToList();
                        List<StoreGoodsStockInfoModel> curCountList = sgsDAL.GetGoodsCurCountList(goodsIds, storeId);
                        if(curCountList.Count >0)
                        {
                                foreach(var vg in listGoods)
                                {
                                        StoreGoodsStockInfoModel curModel = curCountList.Where(c => c.GoodsId == vg.GoodsId).FirstOrDefault();
                                        if(curModel!=null)
                                        {
                                                if (reStr.Length > 0) reStr += ";";
                                                if (curModel.CurCount == 0)
                                                        reStr += $"{vg.GoodsName} -0";  //没有库存
                                                else if (curModel.CurCount > 0 && curModel.CurCount < vg.Count)
                                                        reStr += $"{vg.GoodsName} -1"; //库存不足
                                                else
                                                        reStr += $"{vg.GoodsName} -2"; //库存足够
                                        }
                                }
                        }
                        return reStr;
                }

                /// <summary>
                /// 将List<ViewStStockGoodsInfoModel>转换为 List<StStockGoodsInfoModel>
                /// </summary>
                /// <param name="vList"></param>
                /// <returns></returns>
                private List<StStockGoodsInfoModel> ViewToStStockGoodsInfoModelList(List<ViewStStockGoodsInfoModel> vList)
                {
                        List<StStockGoodsInfoModel> list = new List<StStockGoodsInfoModel>();
                        foreach (var vsg in vList)
                        {
                                list.Add(ViewToStStockGoodsInfoModel(vsg));
                        }
                        return list;
                }

                /// <summary>
                /// 将ViewStStockGoodsInfoModel 转换为 StStockGoodsInfoModel
                /// </summary>
                /// <param name="vsg"></param>
                /// <returns></returns>
                private StStockGoodsInfoModel ViewToStStockGoodsInfoModel(ViewStStockGoodsInfoModel vModel)
                {
                        StStockGoodsInfoModel sg = new StStockGoodsInfoModel()
                        {
                                StockId = vModel.StockId,
                                GoodsId = vModel.GoodsId,
                                StCount = vModel.StCount,
                                StPrice = vModel.StPrice,
                                StAmount = vModel.StAmount,
                                Remark = vModel.Remark
                        };
                        return sg;
                }

                #region 库存查询统计

                /// <summary>
                /// 获取商品库存统计数据
                /// </summary>
                /// <param name="qModel"></param>
                /// <returns></returns>
                public List<StoreStockQueryModel> GetStoreStockData(StockQueryParaModel qModel)
                {
                        DataTable dt = sgsDAL.GetStoreStockData(qModel);
                        List<StoreStockQueryModel> list = new List<StoreStockQueryModel>();
                        if(dt.Rows.Count >0)
                        {
                                list = DbConvert.DataTableToList<StoreStockQueryModel>(dt, "");
                        }
                        return list;
                }

                /// <summary>
                /// 获取指定商品的库存分布
                /// </summary>
                /// <param name="goodsId"></param>
                /// <param name="storeId"></param>
                /// <param name="storeName"></param>
                /// <returns></returns>
                public List<GoodsStoreStockModel> GetGoodsStoreStock(int goodsId,int storeId,string storeName)
                {
                        DataTable dt = sgsDAL.GetGoodsStoreStockData(goodsId, storeId, storeName);
                        List<GoodsStoreStockModel> list = new List<GoodsStoreStockModel>();
                        if (dt.Rows.Count > 0)
                        {
                                list = DbConvert.DataTableToList<GoodsStoreStockModel>(dt, "");
                        }
                        return list;
                }

                /// <summary>
                /// 获取指定商品的库存变动明细
                /// </summary>
                /// <param name="goodsId"></param>
                /// <param name="storeId"></param>
                /// <param name="storeName"></param>
                /// <returns></returns>
                public List<StockChangeInfoModel> GetGoodsStockChangeList(int goodsId, int storeId, string storeName)
                {
                        List<StockChangeInfoModel> list = sgDAL.GetGoodsStockChangeList(goodsId, storeId, storeName);
                        if(list.Count >0)
                        {
                                foreach(var sc in list)
                                {
                                        sc.ShTypeName = GetShTypeName(sc.ShType);
                                        sc.CheckState = GetCheckState(sc.IsChecked);
                                }
                        }
                        return list;
                }
                #endregion

                #region 库存上下限设置

                /// <summary>
                /// 获取商品上下限列表
                /// </summary>
                /// <param name="gTypeId"></param>
                /// <param name="storeId"></param>
                /// <returns></returns>
                public List<ViewStoreStockUpDownModel> GetGoodsStockUpDownList(int gTypeId, int storeId)
                {
                        return vssudDAL.GetGoodsStockUpDownList(gTypeId, storeId);
                }

                /// <summary>
                /// 保存库存上下限
                /// </summary>
                /// <param name="goodsStockUpdownList"></param>
                /// <returns></returns>
                public bool SetGoodsStockUpDown(List<ViewStoreStockUpDownModel> goodsStockUpdownList)
                {
                        List<StoreGoodsStockInfoModel> list = ChangeViewToStoreGoodsStockInfoModelList(goodsStockUpdownList);
                        return sgsDAL.SetGoodsStockUpDown(list);
                }

                /// <summary>
                /// 批量保存库存上下限设置（设置统一的上限下限）
                /// </summary>
                /// <param name="goodsStockUpdownList"></param>
                /// <param name="up"></param>
                /// <param name="down"></param>
                /// <returns></returns>
                public bool SetMoreGoodsStockUpDown(List<ViewStoreStockUpDownModel> goodsStockUpdownList,int up,int down)
                {
                        List<StoreGoodsStockInfoModel> list = ChangeViewToStoreGoodsStockInfoModelList(goodsStockUpdownList);
                        foreach(var gupdown in list)
                        {
                                gupdown.StockUp = up;
                                gupdown.StockDown = down;
                        }
                        return sgsDAL.SetGoodsStockUpDown(list);
                }


                /// <summary>
                /// 将List<ViewStoreStockUpDownModel>转换成List<StoreGoodsStockInfoModel>
                /// </summary>
                /// <param name="goodsStockUpdownList"></param>
                /// <returns></returns>
                private List<StoreGoodsStockInfoModel> ChangeViewToStoreGoodsStockInfoModelList(List<ViewStoreStockUpDownModel> goodsStockUpdownList)
                {
                        List<StoreGoodsStockInfoModel> list = new List<StoreGoodsStockInfoModel>();
                        foreach (var vInfo in goodsStockUpdownList)
                        {
                                list.Add(new StoreGoodsStockInfoModel()
                                {
                                        StoreGoodsId = vInfo.StoreGoodsId,
                                        StoreId = vInfo.StoreId,
                                        GoodsId = vInfo.GoodsId,
                                        StockUp = vInfo.StockUp,
                                        StockDown = vInfo.StockDown
                                });
                        }
                        return list;
                }

                #endregion

                /// <summary>
                /// 获取审核状态说明
                /// </summary>
                /// <param name="isChecked"></param>
                /// <returns></returns>
                private string GetCheckState(int isChecked)
                {
                        string cState = "";
                        switch (isChecked)
                        {
                                case 0:
                                        cState = "待审核";
                                        break;
                                case 1:
                                        cState = "已审核";
                                        break;
                                case 2:
                                        cState = "已作废";
                                        break;
                                case 3:
                                        cState = "已红冲";
                                        break;
                        }
                        return cState;
                }

                /// <summary>
                /// 获取单据类型说明
                /// </summary>
                /// <param name="shType"></param>
                /// <returns></returns>
                private string GetShTypeName(int shType)
                {
                        string shTypeName = "";
                        switch (shType)
                        {
                                case 1:
                                        shTypeName = "采购入库单";
                                        break;
                                case 2:
                                        shTypeName = "销售出库单";
                                        break;
                                case 3:
                                        shTypeName = "期初入库单";
                                        break;
                        }
                        return shTypeName;
                }
        }
}
