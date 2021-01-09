using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPSI.FModels
{
       public   class StockSetMoreModel
        {
                public List<ViewStoreStockUpDownModel> StoreUpDownList { get; set; }
                //选择的仓库
                public string StoreName { get; set; }
        }
}
