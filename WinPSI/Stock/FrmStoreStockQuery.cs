using PSI.Common;
using PSI.Models.DModels;
using PSI.Models.UIModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.BM;
using WinPSI.FModels;
using WinPSI.Request;

namespace WinPSI.Stock
{
    public partial class FrmStoreStockQuery : Form
    {
        public FrmStoreStockQuery()
        {
            InitializeComponent();
        }  
        public StoreInfoModel store = null;//选择的仓库信息
        private void FrmStoreStockQuery_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {

                LoadGoodsTypes();//加载商品类别节点树
                            ClearInfo();//清空条件
                            LoadGoodsStoreStockData();//加载商品库存数据
                        };
            act.TryCatch("加载商品库存查询异常！");
        }

        /// <summary>
        /// 清空条件
        /// </summary>
        private void ClearInfo()
        {
            txtGoodsName.Clear();
            txtInStore.Clear();
        }

        /// <summary>
        /// 加载商品类别
        /// </summary>
        private void LoadGoodsTypes()
        {
            tvGoodsType.Nodes.Clear();
            TreeNode rootNode = FormUtility.CreateNode("0", "商品类别");
            tvGoodsType.Nodes.Add(rootNode);
            //获取节点数据
            List<GoodsTypeInfoModel> typeList = RequestStar.LoadAllGoodsTypes();
            FormUtility.AddTvGTypesNode(typeList, rootNode, 0);//递归加载节点
            tvGoodsType.SelectedNode = rootNode;
            tvGoodsType.ExpandAll();//展开所有节点
        }

        /// <summary>
        /// 加载商品库存数据
        /// </summary>
        private void LoadGoodsStoreStockData()
        {
            StockQueryParaModel qModel = GetParaModel();
            List<StoreStockQueryModel> stockData = RequestStar.GetStoreStockData(qModel);
            if (stockData.Count > 0)
            {
                dgvList.AutoGenerateColumns = false;
                dgvList.DataSource = stockData;
                tsbtnStoreDistribute.Enabled = true;
            }
            else
            {
                dgvList.DataSource = null;
                dgvList.AllowUserToAddRows = false;
                tsbtnStoreDistribute.Enabled = false;
            }
        }

        /// <summary>
        /// 条件获取与封装
        /// </summary>
        /// <returns></returns>
        private StockQueryParaModel GetParaModel()
        {
            //获取条件
            int storeId = 0;
            if (store != null)
                storeId = store.StoreId;
            string storeName = txtInStore.Text.Trim();
            string goodsName = txtGoodsName.Text.Trim();
            int gTypeId = 0;
            if (tvGoodsType.SelectedNode != null)
                gTypeId = tvGoodsType.SelectedNode.Name.GetInt();
            StockQueryParaModel qModel = new StockQueryParaModel()
            {
                StoreId = storeId,
                StoreName = storeName,
                GoodsName = goodsName,
                GTypeId = gTypeId
            };
            return qModel;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnQuery_Click(object sender, EventArgs e)
        {
            LoadGoodsStoreStockData();
        }

        private void tvGoodsType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadGoodsStoreStockData();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }

        /// <summary>
        /// 查看商品库存分布
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnStoreDistribute_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (dgvList.CurrentRow != null)
                {
                    StoreStockQueryModel model = dgvList.CurrentRow.DataBoundItem as StoreStockQueryModel;
                    if (model != null)
                    {
                        FrmGoodsStockInfo fGoodsStock = new FrmGoodsStockInfo();
                        fGoodsStock.Tag = model;
                        fGoodsStock.storeInfo = new StoreInfoModel()
                        {
                            StoreId = store == null ? 0 : store.StoreId,
                            StoreName = txtInStore.Text.Trim()
                        };
                        fGoodsStock.ShowDialog();
                    }
                }
            };
            act.TryCatch("查看商品仓库分布出现异常！");
        }

        /// <summary>
        /// 导出数据 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnOutToExcel_Click(object sender, EventArgs e)
        {
            //获取所有数据
            List<StoreStockQueryModel> stockData = RequestStar.GetStoreStockData(GetParaModel());
            string fileName = "商品库存统计";
            FormUtility.DataToExcel<StoreStockQueryModel>(stockData, dgvList.Columns, fileName + ".xls", fileName, fileName, "导出商品库存统计数据");
        }

        /// <summary>
        /// 仓库选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void storeList_Click(object sender, EventArgs e)
        {
            FrmChooseStores fChooseStore = new FrmChooseStores();
            fChooseStore.Tag = new ChooseModel()
            {
                FGet = this,
                TypeCode = "Store-StoreStockQuery"
            };
            fChooseStore.SetStore += () =>
            {
                txtInStore.Text = store.StoreName;
            };
            fChooseStore.ShowDialog();
        }

        /// <summary>
        /// 双击行查看商品库存变动明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                StoreStockQueryModel model = dgvList.Rows[e.RowIndex].DataBoundItem as StoreStockQueryModel;
                FrmGoodsStockChangeList fGoodsChangeList = new FrmGoodsStockChangeList();
                fGoodsChangeList.Tag = model;
                fGoodsChangeList.storeInfo = new StoreInfoModel()
                {
                    StoreId = store == null ? 0 : store.StoreId,
                    StoreName = txtInStore.Text.Trim()
                };
                //打开方式
                TabControl tab = this.Parent.Parent as TabControl;
                if (FormUtility.CheckOpenForm(fGoodsChangeList.Name))
                {
                    tab.TabPages.RemoveByKey(fGoodsChangeList.Name);
                }
                tab.AddTabFormPage(fGoodsChangeList);
                tab.SelectedTab = tab.TabPages[fGoodsChangeList.Name];
            }
        }

        private void txtInStore_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInStore.Text.Trim()))
            {
                store = null;
            }
        }
    }
}
