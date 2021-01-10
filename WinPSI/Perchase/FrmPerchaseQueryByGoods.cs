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

namespace WinPSI.Perchase
{
    public partial class FrmPerchaseQueryByGoods : Form
    {
        public FrmPerchaseQueryByGoods()
        {
            InitializeComponent();
        }  
        public UnitInfoModel unit = null;//选择的供应商
        public StoreInfoModel store = null;//选择的仓库
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPerchaseQueryByGoods_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                ClearInfo();
                InitGoodsTypes();
                LoadPerDataByGoods();
            };
            act.TryCatch("按商品统计采购数据页面初始化异常！");
        }

        /// <summary>
        /// 加载采购数据
        /// </summary>
        private void LoadPerDataByGoods()
        {
            QueryParaModel pModel = GetParaModel();
            PageModel<PerQueryGoodsModel> pageModel = RequestStar.GetPerDataByGoods(pModel, ucPager1.StartRecord, ucPager1.PageSize);
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
        /// 条件获取或封装
        /// </summary>
        /// <returns></returns>
        private QueryParaModel GetParaModel()
        {
            //条件获取与封装
            int unitId = 0;
            if (unit != null)
                unitId = unit.UnitId;
            string unitName = txtSupplyName.Text.Trim();
            int storeId = 0;
            if (store != null)
                storeId = store.StoreId;
            string storeName = txtStore.Text.Trim();
            int gTypeId = 0;
            if (tvGoodsType.SelectedNode != null)
            {
                gTypeId = tvGoodsType.SelectedNode.Name.GetInt();
            }
            string goodsName = txtGoodsName.Text.Trim();
            string dealPerson = txtDealPerson.Text.Trim();

            //封装查询条件实体
            QueryParaModel pModel = new QueryParaModel()
            {
                UnitId = unitId,
                UnitName = unitName,
                StoreId = storeId,
                StoreName = storeName,
                GTypeId = gTypeId,
                GoodsName = goodsName,
                DealPerson = dealPerson
            };
            return pModel;
        }

        /// <summary>
        /// 加载商品类别节点树
        /// </summary>
        private void InitGoodsTypes()
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
        /// 条件清空
        /// </summary>
        private void ClearInfo()
        {
            txtDealPerson.Clear();
            txtGoodsName.Clear();
            txtStore.Clear();
            txtSupplyName.Clear();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnQuery_Click(object sender, EventArgs e)
        {
            LoadPerDataByGoods();
        }

        /// <summary>
        /// 选择类别，加载相应的采购数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvGoodsType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadPerDataByGoods();
        }

        /// <summary>
        /// 分页响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucPager1_BindSource(object sender, EventArgs e)
        {
            LoadPerDataByGoods();
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

        /// <summary>
        /// 供应商的选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suppliersList_Click(object sender, EventArgs e)
        {
            FrmChooseUnits fChooseUnits = new FrmChooseUnits();
            fChooseUnits.Tag = new ChooseModel()
            {
                FGet = this,
                TypeCode = "Supplier-PerQueryByGoods"
            };
            fChooseUnits.SetUnit += () =>
            {
                txtSupplyName.Text = unit.UnitName;
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
            FrmChooseStores fChooseStores = new FrmChooseStores();
            fChooseStores.Tag = new ChooseModel()
            {
                FGet = this,
                TypeCode = "Store-PerQueryByGoods"
            };
            fChooseStores.SetStore += () =>
            {
                txtStore.Text = store.StoreName;
            };
            fChooseStores.ShowDialog();
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnOutToExcel_Click(object sender, EventArgs e)
        {
            QueryParaModel qModel = GetParaModel();
            List<PerQueryGoodsModel> perData = RequestStar.GetPerDataByGoods(qModel, 1, 100000000).ReList;
            string fileName = "采购统计——按商品";
            FormUtility.DataToExcel<PerQueryGoodsModel>(perData, dgvGoodsList.Columns, fileName + ".xls", fileName, fileName, "导出按商品统计采购数据");
        }

        private void dgvGoodsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex != -1)
            {
                PerQueryGoodsModel perInfo = dgvGoodsList.Rows[rowIndex].DataBoundItem as PerQueryGoodsModel;
                if (perInfo != null)
                {
                    FrmSheetInfo fSheetInfo = new FrmSheetInfo();
                    //shType   typeId  id  infoName
                    fSheetInfo.Tag = new ShInfoModel()
                    {
                        ShType = 1,
                        TypeId = 3,
                        Id = perInfo.GoodsId,
                        InfoName = perInfo.GoodsName
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

        private void txtSupplyName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplyName.Text.Trim()))
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
    }
}
