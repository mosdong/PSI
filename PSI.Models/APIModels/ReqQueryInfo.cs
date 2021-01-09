using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI.Models.APIModels
{
    public class ReqQueryInfo
    {
        public int KeyID { set; get; }

        public string Name { set; get; }

        public string KeyWords { set; get; }

        public List<int> KeyIds { set; get; }
    }
}
