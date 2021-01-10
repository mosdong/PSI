using PSI.Models.DModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.Request;

namespace WinPSI.Stock
{
    public partial class FrmGoodsStockInfo : Form
    {
        public FrmGoodsStockInfo()
        {
            InitializeComponent();
        } 
        public StoreInfoModel storeInfo = null;//传过来的仓库条件
        private StoreStockQueryModel goodsStockInfo = null;//商品的库存数据
        private List<GoodsStoreStockModel> storeStockData = null;
        private void FrmGoodsStockInfo_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                    goodsStockInfo = this.Tag as StoreStockQueryModel;
                if (goodsStockInfo != null)
                {
                    initGoodsInfo();//初始化商品信息
                                LoadGoodsStockData();//加载商品的仓库分布数据
                            }

            };
            act.TryCatch("加载商品库存查询异常！");
        }

        private void LoadGoodsStockData()
        {
            int storeId = 0;
            string storeName = "";
            if (storeInfo != null)
            {
                storeId = storeInfo.StoreId;
                storeName = storeInfo.StoreName;
            }
            storeStockData = RequestStar.GetGoodsStoreStock(goodsStockInfo.GoodsId, storeId, storeName);
            if (storeStockData.Count > 0)
            {
                dgvList.AutoGenerateColumns = false;
                dgvList.DataSource = storeStockData;
            }
            else
            {
                dgvList.DataSource = null;
                dgvList.AllowUserToAddRows = false;
            }
        }

        /// <summary>
        /// 加载商品信息（库存总计数据）
        /// </summary>
        private void initGoodsInfo()
        {
            lblGoodsName.Text = goodsStockInfo.GoodsName;
            lblGUnit.Text = goodsStockInfo.GUnit;
            lblTotalCount.Text = goodsStockInfo.CurCount.ToString();
            lblTotalAmount.Text = goodsStockInfo.StockAmount.ToString();
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcel_Click(object sender, EventArgs e)
        {
            string fileName = $"{goodsStockInfo.GoodsName} 的仓库分布";
            FormUtility.DataToExcel<GoodsStoreStockModel>(storeStockData, dgvList.Columns, fileName + ".xls", fileName, fileName, "导出商品仓库分布数据");
        }
    }
}
