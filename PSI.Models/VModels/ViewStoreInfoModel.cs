using PSI.Common.CustomAttributes;

namespace PSI.Models.VModels
{
    [Table("ViewStoreInfos")]
    public class ViewStoreInfoModel
    {
        /// <summary>
        /// StoreId
        /// </summary>		
        public int StoreId { get; set; }
        /// <summary>
        /// StoreNo
        /// </summary>		
        public string StoreNo { get; set; }
        /// <summary>
        /// StoreName
        /// </summary>		
        public string StoreName { get; set; }
        /// <summary>
        /// STypeId
        /// </summary>		
        public int STypeId { get; set; }
        /// <summary>
        /// STypeName
        /// </summary>		
        public string STypeName { get; set; }
        /// <summary>
        /// StorePYNo
        /// </summary>		
        public string StorePYNo { get; set; }
        /// <summary>
        /// StoreOrder
        /// </summary>		
        public int StoreOrder { get; set; }
        /// <summary>
        /// StoreRemark
        /// </summary>		
        public string StoreRemark { get; set; }
        /// <summary>
        /// IsDeleted
        /// </summary>		
        public int IsDeleted { get; set; }
    }
}
