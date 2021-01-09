using PSI.Common;
using PSI.Models.DModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Perchase;
using WinPSI.QM;
using WinPSI.Request;
using WinPSI.Sale;
using WinPSI.Stock;

namespace WinPSI.BM
{
    public partial class FrmChooseStores : Form
    {
        public FrmChooseStores()
        {
            InitializeComponent();
        } 
        public event Action SetStore;//设置选择的仓库
        private string typeName = "";
        private string uName = "";
        ChooseModel cModel = null;//信息页面到选择仓库页面的实体
        private void FrmChooseStores_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                {
                    cModel = this.Tag as ChooseModel;
                    typeName = cModel.TypeCode;
                    uName = cModel.UName;
                }
                if (string.IsNullOrEmpty(uName))
                {
                    btnAdd.Enabled = false;
                }
                LoadTvSTypes();//仓库类别信息 treeView
                            LoadStoreList();//条件查询仓库列表
                        };
            act.TryCatch("加载仓库信息出现异常");
        }

        /// <summary>
        /// 加载仓库列表
        /// </summary>
        private void LoadStoreList()
        {
            string keywords = txtKeyWords.Text.Trim();
            //仓库类别编号
            int sTypeId = 0;
            if (tvStoreTypes.SelectedNode != null)
                sTypeId = tvStoreTypes.SelectedNode.Name.GetInt();
            dgvStoreList.AutoGenerateColumns = false;
            dgvStoreList.DataSource = RequestStar.LoadStoreList(sTypeId, keywords, false);
        }

        /// <summary>
        /// 加载仓库类别
        /// </summary>
        private void LoadTvSTypes()
        {
            tvStoreTypes.Nodes.Clear();
            TreeNode root = FormUtility.CreateNode("0", "仓库类别");
            List<StoreTypeInfoModel> stList = RequestStar.LoadAllDrpStoreTypes();
            if (stList.Count > 0)
            {
                FormUtility.AddTvSTypesNode(stList, root);
            }
            tvStoreTypes.Nodes.Add(root);
            tvStoreTypes.SelectedNode = root;
            tvStoreTypes.ExpandAll();
        }

        /// <summary>
        /// 加载选择类别下的仓库列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvStoreTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadStoreList();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadStoreList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmStoreInfo fStore = new FrmStoreInfo();
            fStore.Tag = new FInfoModel()
            {
                ActType = 1,
                UName = uName,
                FId = 0
            };
            fStore.ReLoadHandler += LoadStoreList;
            fStore.ShowDialog();
        }

        /// <summary>
        /// 选择仓库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoose_Click(object sender, EventArgs e)
        {
            ViewStoreInfoModel selInfo = null;
            if (dgvStoreList.SelectedRows.Count == 0)
            {
                selInfo = dgvStoreList.Rows[0].DataBoundItem as ViewStoreInfoModel;
            }
            else
            {
                selInfo = dgvStoreList.SelectedRows[0].DataBoundItem as ViewStoreInfoModel;
            }

            StoreInfoModel storeInfo = new StoreInfoModel()
            {
                StoreId = selInfo.StoreId,
                StoreName = selInfo.StoreName
            };
            //typecode   区分要返回的页面
            switch (typeName)
            {
                case "Store-StartStock"://期初入库单页面
                    FrmStartStockInfo fStartStockInfo = cModel.FGet as FrmStartStockInfo;
                    fStartStockInfo.store = storeInfo;
                    break;
                case "Store-PerchaseInStore"://采购单页面
                    FrmPerchaseInStore fPerchaseInStoreInfo = cModel.FGet as FrmPerchaseInStore;
                    fPerchaseInStoreInfo.store = storeInfo;
                    break;
                case "Store-SaleOutStore"://销售单页面
                    FrmSaleOutStore fSaleOutStoreInfo = cModel.FGet as FrmSaleOutStore;
                    fSaleOutStoreInfo.store = storeInfo;
                    break;
                case "Store-SheetQuery"://单据选择页面
                    FrmSheetQuery fSheetQuery = cModel.FGet as FrmSheetQuery;
                    fSheetQuery.store = storeInfo;
                    break;
                case "Store-PerQueryBySupplier"://采购统计按供应商选择页面
                    FrmPerchaseQueryBySupplier fPerBySupplier = cModel.FGet as FrmPerchaseQueryBySupplier;
                    fPerBySupplier.store = storeInfo;
                    break;
                case "Store-PerQueryByStore"://采购统计按仓库选择页面
                    FrmPerchaseQueryByStore fPerByStore = cModel.FGet as FrmPerchaseQueryByStore;
                    fPerByStore.store = storeInfo;
                    break;
                case "Store-PerQueryByGoods"://采购统计按商品选择页面
                    FrmPerchaseQueryByGoods fPerByGoods = cModel.FGet as FrmPerchaseQueryByGoods;
                    fPerByGoods.store = storeInfo;
                    break;
                case "Store-SaleQueryByCustomer"://销售统计按客户选择页面
                    FrmSaleQueryByCustomer fSaleByCustomer = cModel.FGet as FrmSaleQueryByCustomer;
                    fSaleByCustomer.store = storeInfo;
                    break;
                case "Store-SaleQueryByStore"://销售统计按客户选择页面
                    FrmSaleQueryByStore fSaleByStore = cModel.FGet as FrmSaleQueryByStore;
                    fSaleByStore.store = storeInfo;
                    break;
                case "Store-SaleQueryByGoods"://销售统计按商品选择页面
                    FrmSaleQueryByGoods fSaleByGoods = cModel.FGet as FrmSaleQueryByGoods;
                    fSaleByGoods.store = storeInfo;
                    break;
                case "Store-StoreStockQuery"://仓库库存查询页面
                    FrmStoreStockQuery fStoreStockQuery = cModel.FGet as FrmStoreStockQuery;
                    fStoreStockQuery.store = storeInfo;
                    break;
            }
            this.SetStore?.Invoke();
            this.Close();
        }
    }
}
