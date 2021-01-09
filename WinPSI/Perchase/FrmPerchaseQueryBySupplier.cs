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
using WinPSI.Request;

namespace WinPSI.Perchase
{
        public partial class FrmPerchaseQueryBySupplier : Form
        {
                public FrmPerchaseQueryBySupplier()
                {
                        InitializeComponent();
                } 
                PerchaseInStoreBLL perBLL = new PerchaseInStoreBLL();
                public UnitInfoModel unit = null;//选择的供应商
                public StoreInfoModel store = null;//选择的仓库
                public GoodsTypeInfoModel gtInfo = null;//选择的商品类别
                private void FrmPerchaseQueryBySupplier_Load(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                ClearInfo();
                                InitUnitTypes();
                                LoadPerDataBySupplier();
                        };
                        act.TryCatch("按供应商统计采购数据页面初始化异常！");
                }

                /// <summary>
                /// 条件查询采购统计数据
                /// </summary>
                private void LoadPerDataBySupplier()
                {
                        QueryParaModel pModel = GetParaModel();
                        PageModel<PerQuerySupplierModel> pageModel = perBLL.GetPerDataBySupplier(pModel, ucPager1.StartRecord, ucPager1.PageSize);
                        if(pageModel!=null)
                        {
                                if(pageModel.ReList.Count >0)
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
                        string unitName = txtSupplyName.Text.Trim();
                        int storeId = 0;
                        if (store != null)
                                storeId = store.StoreId;
                        string storeName = txtStore.Text.Trim();
                        int gTypeId = 0;
                        if (gtInfo != null)
                                gTypeId = gtInfo.GTypeId;
                        string goodsName = txtGoodName.Text.Trim();
                        string dealPerson = txtDealPerson.Text.Trim();
                        int uTypeId = 0;
                        if (tvUnitTypes.SelectedNode != null)
                                uTypeId = tvUnitTypes.SelectedNode.Name.GetInt();
                        //封装查询条件实体
                        QueryParaModel pModel = new QueryParaModel()
                        {
                                UnitId =unitId,
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
                /// 加载单位类别节点树
                /// </summary>
                private void InitUnitTypes()
                {
                        tvUnitTypes.Nodes.Clear();
                        TreeNode root = null;
                        string typeText = "供应商";
                         List<UnitTypeInfoModel>  utList = RequestStar.GetAllUnitTypes(typeText);
                        root = FormUtility.CreateNode("0", typeText);
                        foreach (UnitTypeInfoModel ut in utList)
                        {
                                TreeNode node = FormUtility.CreateNode(ut.UTypeId.ToString(), ut.UTypeName);
                                root.Nodes.Add(node);
                                FormUtility.AddTvUTypesNode(utList, node, ut.UTypeId);
                        }
                        tvUnitTypes.Nodes.Add(root);
                        tvUnitTypes.SelectedNode = root;
                        tvUnitTypes.ExpandAll();
                }
                /// <summary>
                /// 清空条件信息框
                /// </summary>
                private void ClearInfo()
                {
                        txtDealPerson.Clear();
                        txtGoodName.Clear();
                        txtGoodsType.Clear();
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
                        LoadPerDataBySupplier();
                }

                private void tvUnitTypes_AfterSelect(object sender, TreeViewEventArgs e)
                {
                        LoadPerDataBySupplier();
                }

                private void ucPager1_BindSource(object sender, EventArgs e)
                {
                        LoadPerDataBySupplier();
                }

                /// <summary>
                /// 仓库的选择
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void storeList_Click(object sender, EventArgs e)
                {
                        FrmChooseStores fChooseStore = new FrmChooseStores();
                        fChooseStore.Tag = new ChooseModel()
                        {
                                FGet = this,
                                TypeCode = "Store-PerQueryBySupplier"
                        };
                        fChooseStore.SetStore += () =>
                        {
                                txtStore.Text = store.StoreName;
                        };
                        fChooseStore.ShowDialog();
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
                                TypeCode = "Supplier-PerQueryBySupplier"
                        };
                        fChooseUnits.SetUnit += () =>
                        {
                                txtSupplyName.Text = unit.UnitName;
                        };
                        fChooseUnits.ShowDialog();
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
                                TypeCode = "Goods-PerQueryBySupplier",
                                FGet = this
                        };
                        fCTypes.SetType += ()=> {
                                txtGoodsType.Text = gtInfo.GTypeName;
                        };
                        fCTypes.ShowDialog();
                }

                /// <summary>
                /// 只允许删除信息
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void txtGoodsType_KeyPress(object sender, KeyPressEventArgs e)
                {
                        if(e.KeyChar!=8)
                        {
                                e.Handled = true;
                        }
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
                        List<PerQuerySupplierModel> perData = perBLL.GetPerDataBySupplier(paraModel, 1, 100000000).ReList;
                        string fileName = "采购统计——按供应商";
                        FormUtility.DataToExcel<PerQuerySupplierModel>(perData, dgvGoodsList.Columns, fileName + ".xls", fileName, fileName, "导出按供应商采购统计数据");
                }

                private void txtSupplyName_TextChanged(object sender, EventArgs e)
                {
                        if(string.IsNullOrEmpty(txtSupplyName.Text.Trim()))
                        {
                                if(unit!=null)
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

                /// <summary>
                /// 双击查看采购明细数据
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void dgvGoodsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                        int rowIndex = e.RowIndex;
                        if(rowIndex!=-1)
                        {
                                PerQuerySupplierModel perInfo = dgvGoodsList.Rows[rowIndex].DataBoundItem as PerQuerySupplierModel;
                                if(perInfo!=null)
                                {
                                        FrmSheetInfo fSheetInfo = new FrmSheetInfo();
                                        //shType   typeId  id  infoName
                                        fSheetInfo.Tag = new ShInfoModel()
                                        {
                                                ShType = 1,
                                                TypeId = 1,
                                                Id = perInfo.UnitId,
                                                InfoName = perInfo.UnitName
                                        };
                                        TabControl tab = this.Parent.Parent as TabControl;
                                        if(FormUtility.CheckOpenForm(fSheetInfo.Name))
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
