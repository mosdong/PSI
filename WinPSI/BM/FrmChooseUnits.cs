using PSI.Common;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Perchase;
using WinPSI.QM;
using WinPSI.Request;
using WinPSI.Sale;

namespace WinPSI.BM
{
    public partial class FrmChooseUnits : Form
    {
        public FrmChooseUnits()
        {
            InitializeComponent();
        }
        public event Action SetUnit;//设置选择的单位信息
        private string typeName = "";
        private string uName = "";
        ChooseModel cModel = null;

        private void FrmChooseUnits_Load(object sender, EventArgs e)
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
                    btnAdd.Enabled = false;
                            //选择页面标题
                            if (typeName.Contains("Supplier"))
                    this.Text = "选择供应商";
                else if (typeName.Contains("Customer"))
                    this.Text = "选择客户";
                else if (typeName.Contains("Unit"))
                    this.Text = "选择往来单位";
                LoadTvUTypes();
                LoadUnitList();
            };
            act.TryCatch("加载单位信息出现异常");
        }

        /// <summary>
        /// 单位列表的加载
        /// </summary>
        private void LoadUnitList()
        {
            //查询关键字
            string keywords = txtKeyWords.Text.Trim();
            //单位类别编号
            int uTypeId = 0;
            string uTypeName = "";
            if (tvUnitTypes.SelectedNode != null)
                uTypeId = tvUnitTypes.SelectedNode.Name.GetInt();
            if (typeName != "Unit")
                uTypeName = tvUnitTypes.SelectedNode.Text;
            dgvUnitList.AutoGenerateColumns = false;
            dgvUnitList.DataSource = RequestStar.GetUnitList(uTypeId, uTypeName, keywords);
        }

        private void LoadTvUTypes()
        {
            tvUnitTypes.Nodes.Clear();
            string typeText = "";
            if (typeName.Contains("Supplier"))
                typeText = "供应商";
            else if (typeName.Contains("Customer"))
                typeText = "客户";
            else if (typeName.Contains("Unit"))
                typeText = "往来单位";
            List<UnitTypeInfoModel> utList = new List<UnitTypeInfoModel>();
            TreeNode root = null;
            if (typeText == "往来单位")
            {
                root = FormUtility.CreateNode("0", "全部");
                utList = RequestStar.LoadAllTVUnitTypes();
                if (utList.Count > 0)
                {
                    FormUtility.AddTvUTypesNode(utList, root, 0);
                }
            }
            else
            {
                utList = RequestStar.GetAllUnitTypes(typeText);
                root = FormUtility.CreateNode("0", typeText);
                foreach (UnitTypeInfoModel ut in utList)
                {
                    TreeNode node = FormUtility.CreateNode(ut.UTypeId.ToString(), ut.UTypeName);
                    root.Nodes.Add(node);
                    FormUtility.AddTvUTypesNode(utList, node, ut.UTypeId);
                }
            }
            tvUnitTypes.Nodes.Add(root);
            tvUnitTypes.SelectedNode = root;
            tvUnitTypes.ExpandAll();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadUnitList();
        }

        private void tvUnitTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadUnitList();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            FrmUnitInfo fUnit = new FrmUnitInfo();
            fUnit.Tag = new FInfoModel()
            {
                ActType = 1,
                UName = uName,
                FId = 0
            };
            fUnit.ReLoadHandler += LoadUnitList;
            fUnit.ShowDialog();
        }

        /// <summary>
        /// 选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoose_Click(object sender, EventArgs e)
        {
            UnitInfoModel selInfo = null;
            if (dgvUnitList.SelectedRows.Count == 0)
            {
                selInfo = dgvUnitList.Rows[0].DataBoundItem as UnitInfoModel;
            }
            else
            {
                selInfo = dgvUnitList.SelectedRows[0].DataBoundItem as UnitInfoModel;
            }
            //将选择的单位信息赋值给要选择页面的selUnit公有变量
            switch (typeName)
            {
                case "Supplier-PerInStore"://采购单页面
                    FrmPerchaseInStore frmPerInStore = cModel.FGet as FrmPerchaseInStore;
                    frmPerInStore.selUnit = selInfo;
                    break;
                case "Customer-SaleOutStore"://销售单页面
                    FrmSaleOutStore frmSaleOutStore = cModel.FGet as FrmSaleOutStore;
                    frmSaleOutStore.selCust = selInfo;
                    break;
                case "Unit-SheetQuery"://单据查询页面
                    FrmSheetQuery frmSheetQuery = cModel.FGet as FrmSheetQuery;
                    frmSheetQuery.unit = selInfo;
                    break;
                case "Supplier-PerQueryBySupplier"://采购统计按供应商页面
                    FrmPerchaseQueryBySupplier frmPerQueryBySupplier = cModel.FGet as FrmPerchaseQueryBySupplier;
                    frmPerQueryBySupplier.unit = selInfo;
                    break;
                case "Supplier-PerQueryByStore"://采购统计按仓库页面
                    FrmPerchaseQueryByStore frmPerQueryByStore = cModel.FGet as FrmPerchaseQueryByStore;
                    frmPerQueryByStore.unit = selInfo;
                    break;
                case "Supplier-PerQueryByGoods"://采购统计按商品页面
                    FrmPerchaseQueryByGoods frmPerQueryByGoods = cModel.FGet as FrmPerchaseQueryByGoods;
                    frmPerQueryByGoods.unit = selInfo;
                    break;
                case "Customer-SaleQueryByCustomer"://销售统计按客户页面
                    FrmSaleQueryByCustomer fSaleQueryCustomer = cModel.FGet as FrmSaleQueryByCustomer;
                    fSaleQueryCustomer.unit = selInfo;
                    break;
                case "Customer-SaleQueryByStore"://销售统计按仓库页面
                    FrmSaleQueryByStore fSaleQueryStore = cModel.FGet as FrmSaleQueryByStore;
                    fSaleQueryStore.unit = selInfo;
                    break;
                case "Customer-SaleQueryByGoods"://销售统计按仓库页面
                    FrmSaleQueryByGoods fSaleQueryGoods = cModel.FGet as FrmSaleQueryByGoods;
                    fSaleQueryGoods.unit = selInfo;
                    break;
            }
            this.SetUnit?.Invoke();//显示到文本框
            this.Close();
        }
    }
}
