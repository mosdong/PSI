using PSI.Models.UIModels;

namespace PSI.Models.APIModels
{
    public class PageInfo
    {
        public QueryParaModel QueryParaModel { set; get; }

        public ShQueryParaModel ShQueryParaModel { set; get; }
        public int KeyId { set; get; }
        public string KeyWord { set; get; }
        public bool IsStopped { set; get; }
        public bool IsShowDel { set; get; }
        public int StartIndex { set; get; }
        public int PageSize { set; get; }
    }
}
