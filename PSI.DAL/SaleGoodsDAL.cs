﻿using PSI.Models.DModels;

namespace PSI.DAL
{
    /// <summary>
    /// 销售明细信息处理类
    /// </summary>
    public class SaleGoodsDAL : BQuery<SaleGoodsInfoModel>
    {
        /// <summary>
        /// 判断指定的销售单中是否已存在指定的商品
        /// </summary>
        /// <param name="saleId"></param>
        /// <param name="goodsId"></param>
        /// <returns></returns>
        public bool ExistsGoods(int saleId, int goodsId)
        {
            string strWhere = $"SaleId={saleId} and GoodsId={goodsId}";
            return Exists(strWhere);
        }
    }
}
