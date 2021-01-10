using PSI.Common;
using PSI.Models.DModels;
using PSI.Models.UIModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.BM;
using WinPSI.FModels;
using WinPSI.QM;
using WinPSI.Request;

namespace WinPSI.Sale
{
    public partial class FrmSaleQueryByCustomer : Form
    {
        public FrmSaleQueryByCustomer()
        {
            InitializeComponent();
        } 
        public UnitInfoModel unit = null;//选择的客户
        public StoreInfoModel store = null;//选择的仓库
        public GoodsTypeInfoModel gtInfo = null;//选择的商品类别
        private void FrmSaleQueryByCustomer_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                ClearInfo();
                InitUnitTypes();
                LoadSaleDataByCustomer();
            };
            act.TryCatch("按客户统计销售数据页面初始化异常！");
        }

        private void LoadSaleDataByCustomer()
        {
            QueryParaModel pModel = GetParaModel();
            PageModel<SaleQueryCustomerModel> pageModel = RequestStar.GetSaleDataByCustomer(pModel, ucPager1.StartRecord, ucPager1.PageSize);
            if (pageModel != null)
            {
                if (pageModel.ReList.Count > 0)
                {
                    dgvGoodsList.AutoGenerateColumns = false;
                    dgvGoodsList.DataSource = pageModel.ReList;
                    ucPager1.Visible = true;
                    ucPager1.Record = pageModel.TotalCount;
                }
                else
                {
                    dgvGoodsList.DataSource = null;
                    dgvGoodsList.AllowUserToAddRows = false;
                    ucPager1.Visible = false;
                }
            }
        }

        /// <summary>
        /// 获取查询条件并封装
        /// </summary>
        /// <returns></returns>
        private QueryParaModel GetParaModel()
        {
            //条件获取与封装
            int unitId = 0;
            if (unit != null)
                unitId = unit.UnitId;
            string unitName = txtCustomerName.Text.Trim();
            int storeId = 0;
            if (store != null)
                storeId = store.StoreId;
            string storeName = txtStore.Text.Trim();
            int gTypeId = 0;
            if (gtInfo != null)
                gTypeId = gtInfo.GTypeId;
            string goodsName = txtGoodsName.Text.Trim();
            string dealPerson = txtDealPerson.Text.Trim();
            int uTypeId = 0;
            if (tvCustomerType.SelectedNode != null)
                uTypeId = tvCustomerType.SelectedNode.Name.GetInt();
            //封装查询条件实体
            QueryParaModel pModel = new QueryParaModel()
            {
                UnitId = unitId,
                UnitName = unitName,
                StoreId = storeId,
                StoreName = storeName,
                GTypeId = gTypeId,
                GoodsName = goodsName,
                DealPerson = dealPerson,
                UTypeId = uTypeId
            };
            return pModel;
        }

        /// <summary>
        /// 加载客户类型节点树
        /// </summary>
        private void InitUnitTypes()
        {
            tvCustomerType.Nodes.Clear();
            TreeNode root = null;
            string typeText = "客户";
            List<UnitTypeInfoModel> utList = RequestStar.GetAllUnitTypes(typeText);
            root = FormUtility.CreateNode("0", typeText);
            foreach (UnitTypeInfoModel ut in utList)
            {
                TreeNode node = FormUtility.CreateNode(ut.UTypeId.ToString(), ut.UTypeName);
                root.Nodes.Add(node);
                FormUtility.AddTvUTypesNode(utList, node, ut.UTypeId);
            }
            tvCustomerType.Nodes.Add(root);
            tvCustomerType.SelectedNode = root;
            tvCustomerType.ExpandAll();
        }

        private void ClearInfo()
        {
            txtDealPerson.Clear();
            txtGoodsName.Clear();
            txtGoodsType.Clear();
            txtStore.Clear();
            txtCustomerName.Clear();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnQuery_Click(object sender, EventArgs e)
        {
            LoadSaleDataByCustomer();
        }

        /// <summary>
        /// 选择客户类别加载销售统计列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvCustomerType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadSaleDataByCustomer();
        }

        /// <summary>
        /// 翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucPager1_BindSource(object sender, EventArgs e)
        {
            LoadSaleDataByCustomer();
        }

        /// <summary>
        /// 客户选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suppliersList_Click(object sender, EventArgs e)
        {
            FrmChooseUnits fChooseUnits = new FrmChooseUnits();
            fChooseUnits.Tag = new ChooseModel()
            {
                FGet = this,
                TypeCode = "Customer-SaleQueryByCustomer"
            };
            fChooseUnits.SetUnit += () =>
            {
                txtCustomerName.Text = unit.UnitName;
            };
            fChooseUnits.ShowDialog();
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
                TypeCode = "Store-SaleQueryByCustomer"
            };
            fChooseStore.SetStore += () =>
            {
                txtStore.Text = store.StoreName;
            };
            fChooseStore.ShowDialog();
        }

        /// <summary>
        /// 商品类别选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gtypeList_Click(object sender, EventArgs e)
        {
            FrmChooseTypes fCTypes = new FrmChooseTypes();
            fCTypes.Tag = new ChooseModel()
            {
                TypeCode = "Goods-SaleQueryByCustomer",
                FGet = this
            };
            fCTypes.SetType += () =>
            {
                txtGoodsType.Text = gtInfo.GTypeName;
            };
            fCTypes.ShowDialog();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnOutToExcel_Click(object sender, EventArgs e)
        {
            //获取查询条件并封装
            QueryParaModel paraModel = GetParaModel();
            //条件查询出来的所有数据
            List<SaleQueryCustomerModel> saleData = RequestStar.GetSaleDataByCustomer(paraModel, 1, 100000000).ReList;
            string fileName = "销售统计——按客户";
            FormUtility.DataToExcel<SaleQueryCustomerModel>(saleData, dgvGoodsList.Columns, fileName + ".xls", fileName, fileName, "导出按客户销售统计数据");
        }

        /// <summary>
        /// 双击查看明细列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGoodsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex != -1)
            {
                SaleQueryCustomerModel saleInfo = dgvGoodsList.Rows[rowIndex].DataBoundItem as SaleQueryCustomerModel;
                if (saleInfo != null)
                {
                    FrmSheetInfo fSheetInfo = new FrmSheetInfo();
                    //shType   typeId  id  infoName
                    fSheetInfo.Tag = new ShInfoModel()
                    {
                        ShType = 2,
                        TypeId = 1,
                        Id = saleInfo.UnitId,
                        InfoName = saleInfo.UnitName
                    };
                    TabControl tab = this.Parent.Parent as TabControl;
                    if (FormUtility.CheckOpenForm(fSheetInfo.Name))
                    {
                        tab.TabPages.RemoveByKey(fSheetInfo.Name);
                    }
                    tab.AddTabFormPage(fSheetInfo);
                    tab.SelectedTab = tab.TabPages[fSheetInfo.Name];
                }
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                if (unit != null)
                {
                    unit.UnitId = 0;
                    unit.UnitName = null;
                }
            }
        }

        private void txtStore_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStore.Text.Trim()))
            {
                if (store != null)
                {
                    store.StoreId = 0;
                    store.StoreName = null;
                }
            }
        }

        private void txtGoodsType_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGoodsType.Text.Trim()))
            {
                if (gtInfo != null)
                {
                    gtInfo.GTypeId = 0;
                    gtInfo.GTypeName = null;
                }
            }
        }

        private void txtGoodsType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
