using System;

namespace PSI.Models.DModels
{
    /// <summary>
    /// 系统开账信息
    /// </summary>
    public class SysInfoModel
    {
        public int SysId { get; set; }
        public string SysName { get; set; }
        public int IsOpened { get; set; }
        public DateTime OpenTime { get; set; }
    }
}
