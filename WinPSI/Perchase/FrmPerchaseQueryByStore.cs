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

namespace WinPSI.Perchase
{
        public partial class FrmPerchaseQueryByStore : Form
        {
                public FrmPerchaseQueryByStore()
                {
                        InitializeComponent();
                }
                PerchaseInStoreBLL perBLL = new PerchaseInStoreBLL();
                public UnitInfoModel unit = null;//选择的供应商
                public StoreInfoModel store = null;//选择的仓库
                private void FrmPerchaseQueryByStore_Load(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                ClearInfo();
                                LoadPerDataByStore();
                        };
                        act.TryCatch("按供应商统计采购数据页面初始化异常！");
                }

                /// <summary>
                /// 条件查询采购数据
                /// </summary>
                private void LoadPerDataByStore()
                {
                        QueryParaModel pModel = GetParaModel();
                        PageModel<PerQueryStoreModel> pageModel = perBLL.GetPerDataByStore(pModel, ucPager1.StartRecord, ucPager1.PageSize);
                        if (pageModel != null)
                        {
                                if (pageModel.ReList.Count > 0)
                                {
                                        dgvPerList.AutoGenerateColumns = false;
                                        dgvPerList.DataSource = pageModel.ReList;
                                        ucPager1.Visible = true;
                                        ucPager1.Record = pageModel.TotalCount;
                                }
                                else
                                {
                                        dgvPerList.DataSource = null;
                                        dgvPerList.AllowUserToAddRows = false;
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
                        string unitName = txtSupplyName.Text.Trim();
                        string goodsName = txtGoodsName.Text.Trim();
                        string dealPerson = txtDealPerson.Text.Trim();
                        int storeId = 0;
                        string storeName = txtStore.Text.Trim();
                        if(store!=null)
                        {
                                storeId = store.StoreId;
                        }
                        //封装查询条件实体
                        QueryParaModel pModel = new QueryParaModel()
                        {
                                StoreId=storeId,
                                StoreName =storeName,
                                UnitId=unitId,
                                UnitName = unitName,
                                GoodsName = goodsName,
                                DealPerson = dealPerson
                        };
                        return pModel;
                }

                private void ClearInfo()
                {
                        txtDealPerson.Clear();
                        txtGoodsName.Clear();
                        txtSupplyName.Clear();
                        txtStore.Clear();
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

                /// <summary>
                /// 供应商选择
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void suppliersList_Click(object sender, EventArgs e)
                {
                        FrmChooseUnits fChooseUnits = new FrmChooseUnits();
                        fChooseUnits.Tag = new ChooseModel()
                        {
                                FGet = this,
                                TypeCode = "Supplier-PerQueryByStore"
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
                        FrmChooseStores fChooseStore = new FrmChooseStores();
                        fChooseStore.Tag = new ChooseModel()
                        {
                                FGet = this,
                                TypeCode = "Store-PerQueryByStore"
                        };
                        fChooseStore.SetStore += () =>
                        {
                                txtStore.Text = store.StoreName;
                        };
                        fChooseStore.ShowDialog();
                }

                /// <summary>
                /// 查询
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnQuery_Click(object sender, EventArgs e)
                {
                        LoadPerDataByStore();
                }

                private void ucPager1_BindSource(object sender, EventArgs e)
                {
                        LoadPerDataByStore();
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
                /// 导出数据
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnOutToExcel_Click(object sender, EventArgs e)
                {
                        //获取查询条件并封装
                        QueryParaModel paraModel = GetParaModel();
                        //条件查询出来的所有数据
                        List<PerQueryStoreModel> perData = perBLL.GetPerDataByStore(paraModel, 1, 100000000).ReList;
                        string fileName = "采购统计——按仓库";
                        FormUtility.DataToExcel<PerQueryStoreModel>(perData, dgvPerList.Columns, fileName + ".xls", fileName, fileName, "导出按仓库采购统计数据");
                }

                private void dgvPerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                        int rowIndex = e.RowIndex;
                        if (rowIndex != -1)
                        {
                                PerQueryStoreModel perInfo = dgvPerList.Rows[rowIndex].DataBoundItem as PerQueryStoreModel;
                                if (perInfo != null)
                                {
                                        FrmSheetInfo fSheetInfo = new FrmSheetInfo();
                                        //shType   typeId  id  infoName
                                        fSheetInfo.Tag = new ShInfoModel()
                                        {
                                                ShType = 1,
                                                TypeId =2,
                                                Id = perInfo.StoreId,
                                                InfoName = perInfo.StoreName
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
        }
}
