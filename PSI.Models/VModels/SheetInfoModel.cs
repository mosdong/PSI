﻿using System;

namespace PSI.Models.VModels
{
    /// <summary>
    /// 单据信息实体
    /// </summary>
    public class SheetInfoModel
    {
        //Id
        public int Id { get; set; }
        //单据Id
        public int SheetId { get; set; }
        //单据编号
        public string SheetNo { get; set; }
        //类型
        public int ShType { get; set; }
        //类型名称
        public string ShTypeName { get; set; }
        //审核状态
        public int IsChecked { get; set; }
        //单核状态值说明
        public string CheckState { get; set; }
        //制单时间
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 单位编号
        /// </summary>
        public int? UnitId { get; set; }
        //单位名称
        public string UnitName { get; set; }
        //仓库编号
        public int StoreId { get; set; }
        //应付金额
        public decimal? YHAmount { get; set; }
        //经手人
        public string DealPerson { get; set; }
        //制单人
        public string Creator { get; set; }
        //审核人
        public string CheckPerson { get; set; }
        //审核时间
        public DateTime? CheckTime { get; set; }

    }
}
