using PSI.Models.VModels;
using System.Collections.Generic;

namespace PSI.Models.APIModels
{
    public class ViewSaleGoodsInfoApi
    {
        public List<ViewSaleGoodsInfoModel> ViewSaleGoodsInfoModels { set; get; }
        public int StoreId { set; get; }
    }
}
