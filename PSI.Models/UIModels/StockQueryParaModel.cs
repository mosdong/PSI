namespace PSI.Models.UIModels
{
    /// <summary>
    /// 库存查询页面条件信息实体
    /// </summary>
    public class StockQueryParaModel
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public int GTypeId { get; set; }
        public string GoodsName { get; set; }
    }
}
