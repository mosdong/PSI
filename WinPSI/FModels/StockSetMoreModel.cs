using PSI.Models.VModels;
using System.Collections.Generic;

namespace WinPSI.FModels
{
    public class StockSetMoreModel
    {
        public List<ViewStoreStockUpDownModel> StoreUpDownList { get; set; }
        //选择的仓库
        public string StoreName { get; set; }
    }
}
