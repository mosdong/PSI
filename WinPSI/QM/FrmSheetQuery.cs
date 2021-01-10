using PSI.Common;
using PSI.Models.DModels;
using PSI.Models.UIModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.BM;
using WinPSI.FModels;
using WinPSI.Perchase;
using WinPSI.Request;
using WinPSI.Sale;
using WinPSI.Stock;
using WinPSI.UControls;

namespace WinPSI.QM
{
    public partial class FrmSheetQuery : Form
    {
        public FrmSheetQuery()
        {
            InitializeComponent();
        }  
        private string uName = "";//账号
        public StoreInfoModel store = null;//选择仓库
        public UnitInfoModel unit = null;//选择的单位
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSheetQuery_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                {
                    Type tagType = this.Tag.GetType();
                    uName = this.Tag.ToString();
                }
                InitCboCheckState();//加载审核状态下拉框
                            ClearInfo();
                LoadSheetList();//条件查询单据列表
                        };
            act.TryCatch("采购单页面初始化异常！");
        }

        /// <summary>
        /// 条件查询单据列表
        /// </summary>
        private void LoadSheetList()
        {
            ShQueryParaModel paraModel = GetParaModel();
            //调用查询方法
            PageModel<SheetInfoModel> pageModel = RequestStar.GetSheetList(paraModel, ucPager1.StartRecord, ucPager1.PageSize);
            if (pageModel != null)
            {
                if (pageModel.ReList.Count > 0)
                {
                    dgvList.AutoGenerateColumns = false;
                    dgvList.DataSource = pageModel.ReList;
                    ucPager1.Visible = true;
                    ucPager1.Record = pageModel.TotalCount;
                }
                else
                {
                    dgvList.DataSource = null;
                    dgvList.AllowUserToAddRows = false;
                    ucPager1.Visible = false;
                }
            }
        }

        private void InitCboCheckState()
        {
            List<CheckModel> checkList = RequestStar.GetCheckList();
            checkList.Insert(0, new CheckModel()
            {
                CheckId = -1,
                CheckState = "全部"
            });
            cboChecked.DisplayMember = "CheckState";
            cboChecked.ValueMember = "CheckId";
            cboChecked.DataSource = checkList;
        }

        /// <summary>
        /// 清空条件
        /// </summary>
        private void ClearInfo()
        {
            txtCheckPerson.Clear();
            txtCreator.Clear();
            txtUnitName.Clear();
            txtStore.Clear();
            txtShNo.Clear();
            txtGoodsName.Clear();
            txtDealPerson.Clear();
            tvSheetType.SelectedNode = tvSheetType.Nodes[0];
            cboChecked.SelectedValue = -1;
        }

        private void tvSheetType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadSheetList();
        }

        private void cboChecked_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSheetList();
        }

        /// <summary>
        /// 查询单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnQuery_Click(object sender, EventArgs e)
        {
            LoadSheetList();
        }

        private void ucPager1_BindSource(object sender, EventArgs e)
        {
            LoadSheetList();
        }

        /// <summary>
        /// 往来单位选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customersList_Click(object sender, EventArgs e)
        {
            FrmChooseUnits fChooseUnits = new FrmChooseUnits();
            fChooseUnits.Tag = new ChooseModel()
            {
                FGet = this,
                TypeCode = "Unit-SheetQuery",
                UName = uName
            };
            fChooseUnits.SetUnit += () =>
            {
                txtUnitName.Text = unit.UnitName;
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
                UName = uName,
                TypeCode = "Store-SheetQuery"
            };
            fChooseStore.SetStore += () =>
            {
                txtStore.Text = store.StoreName;
            };
            fChooseStore.ShowDialog();
        }

        /// <summary>
        /// 商品名称模糊匹配
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGoodsName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//enter
            {
                string keywords = txtGoodsName.Text.Trim();
                string goodsName = RequestStar.GetGoodsInfoByKeywords(keywords);
                if (!string.IsNullOrEmpty(goodsName))
                {
                    txtGoodsName.Text = goodsName;
                }
            }
        }

        /// <summary>
        /// 重置单位信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUnitName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUnitName.Text.Trim()))
            {
                if (unit != null)
                {
                    unit.UnitId = 0;
                    unit.UnitName = null;
                }

            }
        }

        /// <summary>
        /// 重置仓库信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStore_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUnitName.Text.Trim()))
            {
                if (store != null)
                {
                    store.StoreId = 0;
                    store.StoreName = null;
                }
            }
        }

        /// <summary>
        /// 单元格双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Action act = () =>
            {
                if (e.RowIndex >= 0)
                {
                    SheetInfoModel sheetInfo = dgvList.Rows[e.RowIndex].DataBoundItem as SheetInfoModel;
                                //行双击：打开单据编辑（查看）页面
                                //采购   销售   入库  shType 1  2  3
                                SheetFormParent frmInfo = null;//编辑页面
                                switch (sheetInfo.ShType)
                    {
                        case 1:
                            frmInfo = new FrmPerchaseInStore();
                            break;
                        case 2:
                            frmInfo = new FrmSaleOutStore();
                            break;
                        case 3:
                            frmInfo = new FrmStartStockInfo();
                            break;
                    }
                    frmInfo.Tag = new FInfoModel()
                    {
                        ActType = 2,
                        UName = uName,
                        FId = sheetInfo.SheetId
                    };
                    frmInfo.ReloadList += LoadSheetList;//订阅事件
                                TabControl tab = this.Parent.Parent as TabControl;
                    if (FormUtility.CheckOpenForm(frmInfo.Name))//如果已打开
                                {
                        tab.TabPages.RemoveByKey(frmInfo.Name);
                        FormUtility.CloseOpenForm(frmInfo.Name);
                    }
                    tab.AddTabFormPage(frmInfo);
                    tab.SelectedTab = tab.TabPages[frmInfo.Name];

                }
            };
            act.TryCatch("单据双击出现异常！");

        }

        /// <summary>
        /// 获取查询条件并封装到ShQueryParaModel
        /// </summary>
        /// <returns></returns>
        private ShQueryParaModel GetParaModel()
        {
            //条件获取
            string sheetNo = txtShNo.Text.Trim();
            int storeId = 0;
            string storeName = txtStore.Text.Trim();
            if (store != null)
            {
                storeId = store.StoreId;
            }
            int unitId = 0;
            string unitName = txtUnitName.Text.Trim();
            if (unit != null)
                unitId = unit.UnitId;
            string goodsName = txtGoodsName.Text.Trim();
            string checkPerson = txtCheckPerson.Text.Trim();
            string creator = txtCreator.Text.Trim();
            string dealPerson = txtDealPerson.Text.Trim();
            int isChecked = cboChecked.SelectedValue.GetInt();
            int shType = 1;
            if (tvSheetType.SelectedNode != null)
                shType = tvSheetType.SelectedNode.Name.GetInt();
            //条件封装  ShQueryParaModel
            ShQueryParaModel paraModel = new ShQueryParaModel()
            {
                SheetNo = sheetNo,
                ShType = shType,
                Creator = creator,
                StoreId = storeId,
                StoreName = storeName,
                UnitId = unitId,
                UnitName = unitName,
                GoodsName = goodsName,
                CheckPerson = checkPerson,
                DealPerson = dealPerson,
                IsChecked = isChecked
            };
            return paraModel;
        }

        /// <summary>
        /// 导出查询的单据列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiQueryToExcel_Click(object sender, EventArgs e)
        {
            //获取查询条件并封装
            ShQueryParaModel paraModel = GetParaModel();
            //条件查询出来的所有数据
            List<SheetInfoModel> sheetList = RequestStar.GetSheetList(paraModel, 1, 100000000).ReList;
            string shTypeName = "采购入库单";
            if (tvSheetType.SelectedNode != null)
            {
                shTypeName = tvSheetType.SelectedNode.Text;
            }
            FormUtility.DataToExcel<SheetInfoModel>(sheetList, dgvList.Columns, shTypeName + ".xls", shTypeName, shTypeName, "导出单据信息");
        }

        /// <summary>
        /// 导出所有的单据列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAllToExcel_Click(object sender, EventArgs e)
        {
            List<SheetInfoModel> totalList = new List<SheetInfoModel>();
            //条件重置
            ShQueryParaModel qModel = new ShQueryParaModel()
            {
                SheetNo = "",
                Creator = "",
                UnitName = "",
                StoreName = "",
                StoreId = 0,
                UnitId = 0,
                GoodsName = "",
                CheckPerson = "",
                DealPerson = "",
                IsChecked = -1,
            };
            for (int i = 1; i <= 3; i++)
            {
                qModel.ShType = i;
                List<SheetInfoModel> list = RequestStar.GetSheetList(qModel, 1, 100000000).ReList;
                if (list.Count > 0)
                    totalList.AddRange(list);
            }
            FormUtility.DataToExcel<SheetInfoModel>(totalList, dgvList.Columns, "所有单据" + ".xls", "所有单据", "所有单据信息", "导出单据信息");
        }
    }
}
