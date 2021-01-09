using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI.Models.APIModels
{
    public class PageInfo
    {
        public int KeyId { set; get; }
        public string KeyWord { set; get; }
        public bool IsStopped { set; get; }
        public bool IsShowDel { set; get; }
        public int StartIndex { set; get; }
        public int PageSize { set; get; }
    }
}
