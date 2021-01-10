using PSI.Models.VModels;
using System.Collections.Generic;

namespace PSI.Models.APIModels
{
    public class ViewStoreStockUpDownApi
    {
        public List<ViewStoreStockUpDownModel> viewStoreStockUpDownModels { set; get; }
        public int up { set; get; }
        public int down { set; get; }
    }
}
