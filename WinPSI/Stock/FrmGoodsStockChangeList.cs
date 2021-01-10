using PSI.Models.DModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.Request;

namespace WinPSI.Stock
{
    public partial class FrmGoodsStockChangeList : Form
    {
        public FrmGoodsStockChangeList()
        {
            InitializeComponent();
        } 
        public StoreInfoModel storeInfo = null;//传过来的仓库条件
        private StoreStockQueryModel goodsStockInfo = null;//商品库存数据
        List<StockChangeInfoModel> stockChangeList = null;//商品库存变动记录
        private void FrmGoodsStockChangeList_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                    goodsStockInfo = this.Tag as StoreStockQueryModel;
                if (goodsStockInfo != null)
                {
                    initGoodsInfo();//初始化商品信息
                                LoadGoodsStockChangeData();//加载商品的库存变动记录
                            }

            };
            act.TryCatch("加载商品库存查询异常！");
        }

        private void LoadGoodsStockChangeData()
        {
            int storeId = 0;
            string storeName = "";
            if (storeInfo != null && !string.IsNullOrEmpty(storeInfo.StoreName))
                storeName = storeInfo.StoreName;
            stockChangeList = RequestStar.GetGoodsStockChangeList(goodsStockInfo.GoodsId, storeId, storeName);
            if (stockChangeList.Count > 0)
            {
                dgvList.AutoGenerateColumns = false;
                dgvList.DataSource = stockChangeList;
            }
            else
            {
                dgvList.DataSource = null;
                dgvList.AllowUserToAddRows = false;
            }
        }

        /// <summary>
        /// 初始化商品名称与仓库
        /// </summary>
        private void initGoodsInfo()
        {
            lblGoodsName.Text = goodsStockInfo.GoodsName;
            if (storeInfo != null && !string.IsNullOrEmpty(storeInfo.StoreName))
                lblStoreName.Text = storeInfo.StoreName;
            else
                lblStoreName.Text = "";
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnOutToExcel_Click(object sender, EventArgs e)
        {
            string fileName = $"{goodsStockInfo.GoodsName} 的库存变动明细列表";
            FormUtility.DataToExcel<StockChangeInfoModel>(stockChangeList, dgvList.Columns, fileName + ".xls", fileName, fileName, "导出商品库存变动明细数据");
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }
    }
}
