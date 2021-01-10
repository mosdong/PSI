using System.Collections.Generic;

namespace PSI.Models.APIModels
{
    public class ReqQueryInfo
    {
        public int KeyID { set; get; }

        public string Name { set; get; }

        public string KeyWords { set; get; }

        public List<int> KeyIds { set; get; }

        public List<int> TemKeyIds { set; get; }

        public bool BlShow { set; get; }
        public int TypeId { set; get; }
    }
}
