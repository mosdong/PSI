using PSI.Models.DModels;

namespace PSI.Models.APIModels
{
    public class GoodsUnitInfoApi
    {
        public GoodsUnitInfoModel GoodsUnitInfoModel { set; get; }

        public bool IsUpdateName { set; get; }

        public string OldName { set; get; }
    }
}
