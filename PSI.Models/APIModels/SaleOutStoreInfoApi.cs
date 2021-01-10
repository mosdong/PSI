using PSI.Models.DModels;
using PSI.Models.VModels;
using System.Collections.Generic;

namespace PSI.Models.APIModels
{
    public class SaleOutStoreInfoApi
    {
        public SaleOutStoreInfoModel saleOutStoreInfoModel { set; get; }
        public List<ViewSaleGoodsInfoModel> viewSaleGoodsInfoModels { set; get; }
    }
}
