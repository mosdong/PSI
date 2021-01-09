using PSI.BLL;
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
        public partial class FrmSaleQueryByStore : Form
        {
                public FrmSaleQueryByStore()
                {
                        InitializeComponent();
                }
                SaleOutStoreBLL saleBLL = new SaleOutStoreBLL();
                public UnitInfoModel unit = null;//选择的客户信息
                public StoreInfoModel store = null;//选择的仓库信息
                private void FrmSaleQueryByStore_Load(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                ClearInfo();
                                LoadSaleDataByStore();
                        };
                        act.TryCatch("按客户统计销售数据页面初始化异常！");
                }

                /// <summary>
                /// 统计数据加载 
                /// </summary>
                private void LoadSaleDataByStore()
                {
                        QueryParaModel pModel = GetParaModel();
                        PageModel<SaleQueryStoreModel> pageModel = saleBLL.GetSaleDataByStore(pModel, ucPager1.StartRecord, ucPager1.PageSize);
                        if (pageModel != null)
                        {
                                if (pageModel.ReList.Count > 0)
                                {
                                        dgvSaleList.AutoGenerateColumns = false;
                                        dgvSaleList.DataSource = pageModel.ReList;
                                        ucPager1.Visible = true;
                                        ucPager1.Record = pageModel.TotalCount;
                                }
                                else
                                {
                                        dgvSaleList.DataSource = null;
                                        dgvSaleList.AllowUserToAddRows = false;
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
                        string goodsName = txtGoodsName.Text.Trim();
                        string dealPerson = txtDealPerson.Text.Trim();
                        int storeId = 0;
                        string storeName = txtStore.Text.Trim();
                        if (store != null)
                        {
                                storeId = store.StoreId;
                        }
                        //封装查询条件实体
                        QueryParaModel pModel = new QueryParaModel()
                        {
                                StoreId = storeId,
                                StoreName = storeName,
                                UnitId = unitId,
                                UnitName = unitName,
                                GoodsName = goodsName,
                                DealPerson = dealPerson
                        };
                        return pModel;
                }

                
                /// <summary>
                /// 获取条件与封装
                /// </summary>
                private void ClearInfo()
                {
                        txtCustomerName.Clear();
                        txtDealPerson.Clear();
                        txtGoodsName.Clear();
                        txtStore.Clear();
                }

                /// <summary>
                /// 查询
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnQuery_Click(object sender, EventArgs e)
                {
                        LoadSaleDataByStore();
                }

                /// <summary>
                /// 翻页
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void ucPager1_BindSource(object sender, EventArgs e)
                {
                        LoadSaleDataByStore();
                }

                private void tsbtnClose_Click(object sender, EventArgs e)
                {
                        this.CloseForm();
                }

                /// <summary>
                /// 选择客户
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void suppliersList_Click(object sender, EventArgs e)
                {

                        FrmChooseUnits fChooseUnits = new FrmChooseUnits();
                        fChooseUnits.Tag = new ChooseModel()
                        {
                                FGet = this,
                                TypeCode = "Customer-SaleQueryByStore"
                        };
                        fChooseUnits.SetUnit += () =>
                        {
                                txtCustomerName.Text = unit.UnitName;
                        };
                        fChooseUnits.ShowDialog();
                }

                /// <summary>
                /// 选择仓库
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void storeList_Click(object sender, EventArgs e)
                {
                        FrmChooseStores fChooseStore = new FrmChooseStores();
                        fChooseStore.Tag = new ChooseModel()
                        {
                                FGet = this,
                                TypeCode = "Store-SaleQueryByStore"
                        };
                        fChooseStore.SetStore += () =>
                        {
                                txtStore.Text = store.StoreName;
                        };
                        fChooseStore.ShowDialog();
                }
                /// <summary>
                /// 双击查看销售明细
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void dgvSaleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                        int rowIndex = e.RowIndex;
                        if (rowIndex != -1)
                        {
                                SaleQueryStoreModel saleInfo = dgvSaleList.Rows[rowIndex].DataBoundItem as SaleQueryStoreModel;
                                if (saleInfo != null)
                                {
                                        FrmSheetInfo fSheetInfo = new FrmSheetInfo();
                                        //shType   typeId  id  infoName
                                        fSheetInfo.Tag = new ShInfoModel()
                                        {
                                                ShType =2,
                                                TypeId = 2,
                                                Id = saleInfo.StoreId,
                                                InfoName = saleInfo.StoreName
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
                /// 导出
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnOutToExcel_Click(object sender, EventArgs e)
                {
                        //获取查询条件并封装
                        QueryParaModel paraModel = GetParaModel();
                        //条件查询出来的所有数据
                        List<SaleQueryStoreModel> saleData = saleBLL.GetSaleDataByStore(paraModel, 1, 100000000).ReList;
                        string fileName = "销售统计——按仓库";
                        FormUtility.DataToExcel<SaleQueryStoreModel>(saleData, dgvSaleList.Columns, fileName + ".xls", fileName, fileName, "导出按仓库销售统计数据");
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
