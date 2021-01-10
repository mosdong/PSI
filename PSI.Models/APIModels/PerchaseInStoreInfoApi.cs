using PSI.Models.DModels;
using PSI.Models.VModels;
using System.Collections.Generic;

namespace PSI.Models.APIModels
{
    public class PerchaseInStoreInfoApi
    {
        public PerchaseInStoreInfoModel perchaseInStoreInfoModel { set; get; }
        public List<ViewPerGoodsInfoModel> viewPerGoodsInfoModels { set; get; }
    }
}
