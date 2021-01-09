using PSI.Common;
using PSI.Models.DModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Perchase;
using WinPSI.Request;
using WinPSI.Sale;
using WinPSI.Stock;

namespace WinPSI.BM
{
    public partial class FrmChooseGoods : Form
    {
        public FrmChooseGoods()
        {
            InitializeComponent();
        } 
        public event Action SetChooseGoods;
        private string typeName = "";
        private string uName = "";
        ChooseModel cModel = null;
        private void FrmChooseGoods_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                {
                    cModel = this.Tag as ChooseModel;
                    typeName = cModel.TypeCode;
                    uName = cModel.UName;
                }
                LoadTvGTypes();
                LoadGoodsList();
            };
            act.TryCatch("加载商品信息出现异常");
        }

        /// <summary>
        /// 加载商品列表
        /// </summary>
        private void LoadGoodsList()
        {
            string keywords = txtKeyWords.Text.Trim();
            //商品类别编号
            int gTypeId = 0;
            if (tvGoodsTypes.SelectedNode != null)
                gTypeId = tvGoodsTypes.SelectedNode.Name.GetInt();
            dgvGoodsList.AutoGenerateColumns = false;
            dgvGoodsList.DataSource = RequestStar.GetGoodsList(gTypeId, keywords);
        }

        /// <summary>
        /// 加载商品类别列表
        /// </summary>
        private void LoadTvGTypes()
        {
            TreeNode root = FormUtility.CreateNode("0", "商品类别");
            tvGoodsTypes.Nodes.Add(root);
            List<GoodsTypeInfoModel> gtList = RequestStar.LoadAllGoodsTypes();
            if (gtList.Count > 0)
            {
                FormUtility.AddTvGTypesNode(gtList, root, 0);
            }
            tvGoodsTypes.SelectedNode = root;
            tvGoodsTypes.ExpandAll();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadGoodsList();
        }

        /// <summary>
        /// 选择类别，加载相应的商品列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvGoodsTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadGoodsList();
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
        /// 添加商品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmGoodsInfo fGoods = new FrmGoodsInfo();
            fGoods.Tag = new FInfoModel()
            {
                ActType = 1,
                UName = uName,
                FId = 0
            };
            fGoods.ReLoadHandler += LoadGoodsList;
            fGoods.ShowDialog();
        }

        /// <summary>
        /// 选择商品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoose_Click(object sender, EventArgs e)
        {
            List<ViewGoodsInfoModel> selInfo = new List<ViewGoodsInfoModel>();
            //获取选择的商品数据
            if (dgvGoodsList.SelectedRows.Count == 0)
            {
                selInfo.Add(dgvGoodsList.Rows[0].DataBoundItem as ViewGoodsInfoModel);
            }
            else
            {
                foreach (DataGridViewRow row in dgvGoodsList.SelectedRows)
                {
                    selInfo.Add(row.DataBoundItem as ViewGoodsInfoModel);
                }
            }
            Type typeForm = cModel.FGet.GetType();
            // cModel.FGet.chooseGoods = selInfo;

            //每一个进入到选择商品页面的变量名称：chooseGoods
            //typeForm.GetField("chooseGoods").SetValue(cModel.FGet, selInfo);

            switch (typeName)
            {
                case "DgvGoods-PerchaseInStore"://采购单页面商品选择
                    FrmPerchaseInStore frmPerchase = cModel.FGet as FrmPerchaseInStore;
                    frmPerchase.chooseGoods = selInfo;
                    break;
                case "DgvGoods-SaleOutStore"://销售单页面商品选择
                    FrmSaleOutStore frmSale = cModel.FGet as FrmSaleOutStore;
                    frmSale.chooseGoods = selInfo;
                    break;
                case "DgvGoods-StartStock"://期初入库单商品选择
                    FrmStartStockInfo frm = cModel.FGet as FrmStartStockInfo;
                    frm.chooseGoods = selInfo;
                    break;
            }
            this.SetChooseGoods?.Invoke();
            this.Close();
        }
    }
}
