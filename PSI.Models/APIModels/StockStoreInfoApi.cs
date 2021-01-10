using PSI.Models.DModels;
using PSI.Models.VModels;
using System.Collections.Generic;

namespace PSI.Models.APIModels
{
    public class StockStoreInfoApi
    {
        public StockStoreInfoModel stockStoreInfoModel { set; get; }
        public List<ViewStStockGoodsInfoModel> stockGoodsList { set; get; }
    }
}
