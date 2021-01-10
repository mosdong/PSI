using PSI.Common;
using PSI.Models.DModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinPSI.BM;
using WinPSI.FModels;
using WinPSI.Request;
using WinPSI.UControls;

namespace WinPSI.Stock
{
    public partial class FrmStartStockInfo : SheetFormParent
    {

        public FrmStartStockInfo()
        {
            InitializeComponent();
        }   
        private FInfoModel fModel = null;
        string uName = "";
        int stockId = 0;//当前编辑的入库单编号
        int actType = 1;//当前单据页面的类别
        bool isOpened = false;//开账状态
        public StoreInfoModel store = null;//选择的仓库
        int addGoods = 0;//添加商品标识
        public List<ViewGoodsInfoModel> chooseGoods = null;//选择的商品
                                                           //public event Action ReloadList;//刷新列表页
        private void FrmStartStockInfo_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                {
                    Type tagType = this.Tag.GetType();
                    if (tagType == typeof(string))
                        uName = this.Tag.ToString();
                    else if (tagType == typeof(FInfoModel))
                    {
                        fModel = this.Tag as FInfoModel;
                        uName = fModel.UName;
                        stockId = fModel.FId;
                        actType = fModel.ActType;
                    }
                }

                InitInfo();//初始化
                        };
            act.TryCatch("商品信息页面初始化异常！");
        }

        /// <summary>
        /// 页面初始化
        /// </summary>
        private void InitInfo()
        {

            if (stockId == 0)
            {
                ClearInfo();
            }
            else//加载单据信息
            {
                //获取指定入库单信息   
                StockStoreInfoModel stockInfo = RequestStar.GetStockInfo(stockId);
                if (stockInfo != null)
                {

                    //选择仓库    仓库编号
                    store = new StoreInfoModel()
                    {
                        StoreId = stockInfo.StoreId,
                        StoreName = RequestStar.GetStoreInfo(stockInfo.StoreId).StoreName
                    };
                    txtInStore.Text = store.StoreName;
                    txtDealPerson.Text = stockInfo.DealPerson;
                    txtRemark.Text = stockInfo.Remark;
                    lblStockNo.Text = stockInfo.StockNo;
                    txtCreator.Text = stockInfo.Creator;
                    txtCreateTime.Text = stockInfo.CreateTime.ToShortDateString();
                    //单据状态
                    switch (stockInfo.IsChecked)
                    {
                        case 0: lblCheckState.Text = "待审核"; break;
                        case 1:
                            lblCheckState.Text = "已审核";
                            break;
                        case 2:
                            lblCheckState.Text = "作废";//未审核作废
                            break;
                        case 3:
                            lblCheckState.Text = "已红冲";//已审核作废称红冲
                            break;
                    }
                    //在不同审核状态下工具项的可用
                    SetBtnsEnabled(stockInfo.IsChecked);
                    //获取该单据相关的商品明细列表
                    List<ViewStStockGoodsInfoModel> stockGoods = RequestStar.GetStockGoodsList(stockId);
                    if (stockGoods.Count > 0)
                    {
                        dgvGoods.AutoGenerateColumns = false;
                        dgvGoods.DataSource = stockGoods;
                        SetTotalInfo(stockGoods);
                    }
                    else
                    {
                        dgvGoods.DataSource = null;
                        dgvGoods.AllowUserToAddRows = false;
                    }
                }
            }
            isOpened = RequestStar.GetOpenState(1);
            if (isOpened)
            {
                tsbtnAdd.Enabled = false;
                tsbtnSave.Enabled = false;
                tsbtnCheck.Enabled = false;
                tsddbtnAct.Enabled = false;
                btnAddGoods.Enabled = false;
                btnDelete.Enabled = false;
                storeList.Visible = false;
                lblOpenDesp.Visible = true;
            }
            else
                lblOpenDesp.Visible = false;
        }

        /// <summary>
        /// 设置商品明细统计 
        /// </summary>
        /// <param name="list"></param>
        private void SetTotalInfo(List<ViewStStockGoodsInfoModel> list)
        {
            TotalCountAandAmount(list);
            lblTotalAmount.Text = totalAmount.ToString("0.00");
            lblTotalCount.Text = totalCount.ToString();
            lblTotalDesp.Text = $"共{list.Count}条明细";
        }

        decimal totalAmount = 0;//期初总金额
        int totalCount = 0;//期初总数量
        /// <summary>
        /// 统计总量数据
        /// </summary>
        private void TotalCountAandAmount(List<ViewStStockGoodsInfoModel> list)
        {
            totalCount = 0;
            totalAmount = 0;
            foreach (var sgi in list)
            {
                totalCount += sgi.StCount;
                totalAmount += sgi.StAmount;
            }
        }

        /// <summary>
        /// 设置审核 作废 红冲 保存按钮的启用
        /// </summary>
        /// <param name="isChecked"></param>
        private void SetBtnsEnabled(int isChecked)
        {
            if (isChecked == 0)
            {
                tsbtnCheck.Enabled = true;
                tsmiNoUse.Enabled = true;
                tsmiRedChecked.Enabled = false;
                tsbtnSave.Enabled = true;
            }
            else if (isChecked == 1)
            {
                tsbtnCheck.Enabled = false;
                tsmiNoUse.Enabled = false;
                tsmiRedChecked.Enabled = true;
                tsbtnSave.Enabled = false;
            }
            else
            {
                tsbtnCheck.Enabled = false;
                tsmiNoUse.Enabled = false;
                tsmiRedChecked.Enabled = false;
                tsbtnSave.Enabled = false;
            }
        }

        /// <summary>
        /// 清空操作
        /// </summary>
        private void ClearInfo()
        {
            txtInStore.Clear();
            txtDealPerson.Clear();
            txtRemark.Clear();
            dgvGoods.AutoGenerateColumns = false;
            dgvGoods.DataSource = null;
            lblTotalDesp.Text = "共0条明细";
            lblTotalCount.Text = "";
            lblTotalAmount.Text = "";
            txtCreator.Text = uName;
            txtCreateTime.Text = DateTime.Today.ToShortDateString();
            lblCheckState.Text = "待审核";
            lblStockNo.Text = "";
            tsbtnCheck.Enabled = false;
            tsddbtnAct.Enabled = false;
        }
        /// <summary>
        /// 添加商品明细空记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            List<ViewStStockGoodsInfoModel> list = new List<ViewStStockGoodsInfoModel>();
            int id = 0;
            if (dgvGoods.DataSource != null)
            {
                list = dgvGoods.DataSource as List<ViewStStockGoodsInfoModel>;
                dgvGoods.DataSource = null;
                List<ViewStStockGoodsInfoModel> list2 = new List<ViewStStockGoodsInfoModel>();
                foreach (var vg in list)
                {
                    if (string.IsNullOrEmpty(vg.GoodsName))
                        list2.Add(vg);
                }
                foreach (var vg in list2)
                {
                    list.Remove(vg);
                }
                id = list.Count + 1;
            }
            else
                id += 1;

            list.Add(new ViewStStockGoodsInfoModel()
            {
                Id = id,
                GoodsNo = "",
                GoodsTXNo = "",
                GoodsName = "",
                GUnit = "",
                StCount = 0,
                StPrice = 0,
                StAmount = 0,
                Remark = ""
            });
            dgvGoods.DataSource = list;
            SetTotalInfo(list);
            addGoods = 1;//添加商品
        }


        /// <summary>
        /// 单元格双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgvGoods.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string colName = dgvGoods.Columns[e.ColumnIndex].Name;
            if (addGoods == 1)
            {
                if (colName == "GoodsName")
                {
                    if (!string.IsNullOrEmpty(txtInStore.Text))
                    {
                        FrmChooseGoods fGoods = new FrmChooseGoods();
                        fGoods.Tag = new ChooseModel()
                        {
                            FGet = this,
                            UName = uName,
                            TypeCode = "DgvGoods-StartStock"
                        };
                        fGoods.SetChooseGoods += SetDgvGoods;
                        fGoods.ShowDialog();
                    }
                    else
                    {
                        MsgBoxHelper.MsgErrorShow("请先选择入货仓库！");
                        return;
                    }

                }
            }
        }
        /// <summary>
        ///  刷新商品列表(将选择的商品列表追加到明细数据中)
        /// </summary>
        private void SetDgvGoods()
        {
            List<ViewStStockGoodsInfoModel> list = dgvGoods.DataSource as List<ViewStStockGoodsInfoModel>;
            dgvGoods.DataSource = null;
            int id = 0;
            if (list.Count == 1)
            {
                list.RemoveAt(0);
                id = 0;
            }
            else
            {
                list.RemoveAt(list.Count - 1);
                id = list[list.Count - 1].Id;
            }
            foreach (ViewGoodsInfoModel vg in chooseGoods)
            {
                id += 1;
                list.Add(new ViewStStockGoodsInfoModel()
                {
                    Id = id,
                    GoodsId = vg.GoodsId,
                    GoodsNo = vg.GoodsNo,
                    GoodsName = vg.GoodsName,
                    GoodsTXNo = vg.GoodsTXNo,
                    GUnit = vg.GUnit,
                    StCount = 1,
                    StPrice = 0,
                    StAmount = 0,
                    Remark = ""
                });
            }
            dgvGoods.DataSource = list;
            SetTotalInfo(list);//总计信息
            addGoods = 0;//不能添加商品
        }

        /// <summary>
        /// 打开仓库选择页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void storeList_Click(object sender, EventArgs e)
        {
            //store  事件--跨页面赋值  uName   本页面实例
            FrmChooseStores fChooseStore = new FrmChooseStores();
            fChooseStore.Tag = new ChooseModel()
            {
                FGet = this,
                UName = uName,
                TypeCode = "Store-StartStock"
            };
            fChooseStore.SetStore += () =>
            {
                txtInStore.Text = store.StoreName;
            };
            fChooseStore.ShowDialog();
        }

        /// <summary>
        /// 移除某一个明细数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //将dgv 数据源中选中的数据行的数据移除
            if (dgvGoods.DataSource != null)
            {
                if (dgvGoods.SelectedRows.Count > 0)
                {
                    List<ViewStStockGoodsInfoModel> list = dgvGoods.DataSource as List<ViewStStockGoodsInfoModel>;
                    foreach (DataGridViewRow row in dgvGoods.SelectedRows)
                    {
                        var sgInfo = row.DataBoundItem as ViewStStockGoodsInfoModel;
                        list.Remove(sgInfo);
                    }
                    dgvGoods.DataSource = null;
                    dgvGoods.DataSource = list;
                    SetTotalInfo(list);//总计
                }
            }
        }

        /// <summary>
        /// 当单元格结束编辑时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGoods.Rows.Count > 0)
            {
                //当前输入的单元格
                DataGridViewCell curcell = dgvGoods.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //获取单元格所在列的列名
                string colName = dgvGoods.Columns[e.ColumnIndex].Name;
                int count = 0;
                decimal price = 0;
                decimal amount = 0;
                switch (colName)
                {
                    case "StCount":
                        count = curcell.Value.GetInt();
                        //获取价格单元格的值
                        price = dgvGoods.Rows[e.RowIndex].Cells["StPrice"].Value.ToString().GetDecimal();
                        break;
                    case "StPrice":
                        price = curcell.Value.ToString().GetDecimal();
                        //获取数量单元格的值
                        count = dgvGoods.Rows[e.RowIndex].Cells["StCount"].Value.GetInt();
                        break;
                    default: break;
                }
                amount = count * price;//计算金额
                dgvGoods.Rows[e.RowIndex].Cells["StAmount"].Value = amount.ToString("0.00");
                //总计
                SetTotalInfo((List<ViewStStockGoodsInfoModel>)dgvGoods.DataSource);
            }
        }

        /// <summary>
        /// 单元格的状态因其值改变时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGoods_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //if (dgvGoods.IsCurrentCellDirty)
            //{
            //        dgvGoods.CommitEdit(DataGridViewDataErrorContexts.Commit);
            //}
        }

        /// <summary>
        /// 新增响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            actType = 1;
            stockId = 0;
            SetBtnsEnabled(0);
            ClearInfo();
        }

        /// <summary>
        /// 单据保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                            //信息接收
                            int storeId = 0;
                if (store != null)
                    storeId = store.StoreId;
                string dealPerson = txtDealPerson.Text.Trim();
                string remark = txtRemark.Text.Trim();
                string creator = txtCreator.Text.Trim();
                DateTime createTime = DateTime.Today;
                if (storeId == 0)
                {
                    MsgBoxHelper.MsgErrorShow("请选择入货仓库！");
                    txtInStore.Focus();
                    return;
                }
                if (dgvGoods.DataSource == null)
                {
                    MsgBoxHelper.MsgErrorShow("请选择商品！");
                    return;
                }
                else
                {
                    List<ViewStStockGoodsInfoModel> list = dgvGoods.DataSource as List<ViewStStockGoodsInfoModel>;
                    List<ViewStStockGoodsInfoModel> list2 = list;
                    foreach (var vpi in list)
                    {
                        if (string.IsNullOrEmpty(vpi.GoodsName))
                        {
                            DialogResult dr = MsgBoxHelper.MsgBoxConfirm("入库商品", $"商品不能为空，是否删除这行？");
                            if (dr == DialogResult.Yes)
                            {
                                dgvGoods.DataSource = null;
                                list2.Remove(vpi);
                                dgvGoods.DataSource = list2;
                            }
                            return;
                        }
                        else if (vpi.StPrice == 0)
                        {
                            MsgBoxHelper.MsgErrorShow($"商品：{vpi.GoodsName}的成本单价不能为0！");
                            return;
                        }
                        else if (vpi.StCount == 0)
                        {
                            MsgBoxHelper.MsgErrorShow($"商品：{vpi.GoodsName}的入库数量不能为0！");
                            return;
                        }

                    }
                }
                            //信息封装：单据信息   明细信息
                            StockStoreInfoModel stockInfo = new StockStoreInfoModel()
                {
                    StoreId = storeId,
                    DealPerson = dealPerson,
                    Remark = remark,
                    Creator = creator,
                    CreateTime = createTime
                };

                            //保存期初商品列表
                            List<ViewStStockGoodsInfoModel> listGoods = dgvGoods.DataSource as List<ViewStStockGoodsInfoModel>;
                foreach (var goods in listGoods)
                {
                    goods.Creator = uName;
                }

                            //提交
                            if (stockId == 0)//新单保存
                            {
                                //reStr  stockId,StockNo
                                string reStr = RequestStar.AddStockInfo(stockInfo, listGoods);
                    if (!string.IsNullOrEmpty(reStr))
                    {
                        MsgBoxHelper.MsgBoxShow("期初入库单保存", "期初入库单新增保存成功！");
                        string[] reStrs = reStr.Split(',');
                        stockId = reStrs[0].GetInt();//生成的入库单编号
                                    lblStockNo.Text = reStrs[1];//生成的入库单号
                                    actType = 2;
                        tsddbtnAct.Enabled = true;
                        SetBtnsEnabled(0);
                        this.ReloadListHandler();
                    }
                    else
                    {
                        MsgBoxHelper.MsgErrorShow("期初入库单保存失败！");
                        return;
                    }
                }
                else//修改保存   新增后修改     单据列表页进来 
                            {
                    stockInfo.StockId = stockId;
                    bool bl = RequestStar.UpdateStockInfo(stockInfo, listGoods);
                    if (bl)
                    {
                        MsgBoxHelper.MsgBoxShow("期初入库单保存", "期初入库单修改保存成功！");
                        this.ReloadListHandler();
                    }
                }
            };
            act.TryCatch("期初入库单提交出现异常！");
        }

        /// <summary>
        /// 审核入库单  状态：待审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnCheck_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (actType == 1)
                {
                    MsgBoxHelper.MsgErrorShow("期初入库单还未保存，不能审核！");
                    return;
                }
                if (MsgBoxHelper.MsgBoxConfirm("期初入库单审核", "你确定要审核该入库单吗？") == DialogResult.Yes)
                {
                    bool bl = RequestStar.CheckStockInfo(stockId, uName, store.StoreId);
                    if (bl)
                    {
                        lblCheckState.Text = "已审核";
                        lblCheckState.ForeColor = Color.Red;
                        SetBtnsEnabled(1);
                    }
                }
            };
            act.TryCatch("审核入库单出现异常！");

        }

        /// <summary>
        /// 红冲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRedChecked_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (actType == 1)
                {
                    MsgBoxHelper.MsgErrorShow("期初入库单还未保存，不能红冲！");
                    return;
                }
                if (actType == 2 && lblCheckState.Text.Trim() == "待审核")
                {
                    MsgBoxHelper.MsgErrorShow("期初入库单还未审核，不能红冲！");
                    return;
                }
                if (MsgBoxHelper.MsgBoxConfirm("期初入库单审核", "你确定要红冲该入库单吗？") == DialogResult.Yes)
                {
                    bool bl = RequestStar.RedCheckStockInfo(stockId, store.StoreId);
                    if (bl)
                    {
                        lblCheckState.Text = "已红冲";
                        lblCheckState.ForeColor = Color.Green;
                        SetBtnsEnabled(3);
                    }
                }
            };
            act.TryCatch("红冲入库单出现异常！");

        }

        /// <summary>
        /// 作废
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiNoUse_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (actType == 1)
                {
                    MsgBoxHelper.MsgErrorShow("期初入库单还未保存，不能进行作废操作！");
                    return;
                }
                if (MsgBoxHelper.MsgBoxConfirm("期初入库单审核", "你确定要作废该入库单吗？") == DialogResult.Yes)
                {
                    bool bl = RequestStar.NoUseStockInfo(stockId);
                    if (bl)
                    {
                        lblCheckState.Text = "已作废";
                        lblCheckState.ForeColor = Color.Gray;
                        SetBtnsEnabled(2);
                    }
                }
            };
            act.TryCatch("作废入库单出现异常！");

        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            if (actType == 1)
            {
                if (MsgBoxHelper.MsgBoxConfirm("期初入库单", "该单据并未保存，你确定要关闭期初入库单页面吗？") == DialogResult.Yes)
                {
                    this.CloseForm();
                }
            }
            else
                this.CloseForm();

        }


    }
}
