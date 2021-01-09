using PSI.BLL;
using PSI.Common;
using PSI.Models.DModels;
using PSI.Models.UIModels;
using PSI.Models.VModels;
using WinPSI.BM;
using WinPSI.FModels;
using WinPSI.QM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPSI.Sale
{
        public partial class FrmSaleQueryByGoods : Form
        {
                public FrmSaleQueryByGoods()
                {
                        InitializeComponent();
                }
                SaleOutStoreBLL saleBLL = new SaleOutStoreBLL();
                GoodsTypeBLL gtBLL = new GoodsTypeBLL();
                public UnitInfoModel unit = null;//选择的客户信息
                public StoreInfoModel store = null;//选择的仓库信息
                private void FrmSaleQueryByGoods_Load(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                ClearInfo();
                                InitGoodsTypes();
                                LoadSaleDataByGoods();
                        };
                        act.TryCatch("按商品统计销售数据页面初始化异常！");
                }

                /// <summary>
                /// 条件查询销售数据
                /// </summary>
                private void LoadSaleDataByGoods()
                {
                        QueryParaModel pModel = GetParaModel();
                        PageModel<SaleQueryGoodsModel> pageModel = saleBLL.GetSaleDataByGoods(pModel, ucPager1.StartRecord, ucPager1.PageSize);
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
                        string unitName = txtCustomerName.Text.Trim();
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

                private void InitGoodsTypes()
                {
                        tvGoodsType.Nodes.Clear();
                        TreeNode rootNode = FormUtility.CreateNode("0", "商品类别");
                        tvGoodsType.Nodes.Add(rootNode);
                        //获取节点数据
                        List<GoodsTypeInfoModel> typeList = gtBLL.LoadAllGoodsTypes();
                        FormUtility.AddTvGTypesNode(typeList, rootNode, 0);//递归加载节点
                        tvGoodsType.SelectedNode = rootNode;
                        tvGoodsType.ExpandAll();//展开所有节点
                }

                /// <summary>
                /// 清空
                /// </summary>
                private void ClearInfo()
                {
                        txtDealPerson.Clear();
                        txtGoodsName.Clear();
                        txtStore.Clear();
                        txtCustomerName.Clear();
                }

                private void tsbtnQuery_Click(object sender, EventArgs e)
                {
                        LoadSaleDataByGoods();
                }

                private void tvGoodsType_AfterSelect(object sender, TreeViewEventArgs e)
                {
                        LoadSaleDataByGoods();
                }

                private void ucPager1_BindSource(object sender, EventArgs e)
                {
                        LoadSaleDataByGoods();
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
                        QueryParaModel qModel = GetParaModel();
                        List<SaleQueryGoodsModel> saleData = saleBLL.GetSaleDataByGoods(qModel, 1, 100000000).ReList;
                        string fileName = "销售统计——按商品";
                        FormUtility.DataToExcel<SaleQueryGoodsModel>(saleData, dgvGoodsList.Columns, fileName + ".xls", fileName, fileName, "导出按商品统计销售数据");
                }

                /// <summary>
                /// 双击查看销售明细 
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void dgvGoodsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                        int rowIndex = e.RowIndex;
                        if (rowIndex != -1)
                        {
                                SaleQueryGoodsModel saleInfo = dgvGoodsList.Rows[rowIndex].DataBoundItem as SaleQueryGoodsModel;
                                if (saleInfo != null)
                                {
                                        FrmSheetInfo fSheetInfo = new FrmSheetInfo();
                                        //shType   typeId  id  infoName
                                        fSheetInfo.Tag = new ShInfoModel()
                                        {
                                                ShType = 2,
                                                TypeId = 3,
                                                Id = saleInfo.GoodsId,
                                                InfoName = saleInfo.GoodsName
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
                                TypeCode = "Customer-SaleQueryByGoods"
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
                                TypeCode = "Store-SaleQueryByGoods"
                        };
                        fChooseStore.SetStore += () =>
                        {
                                txtStore.Text = store.StoreName;
                        };
                        fChooseStore.ShowDialog();
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
        }
}
