using PSI.Common;
using PSI.Models.DModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinPSI.BM;
using WinPSI.FModels;
using WinPSI.Request;
using WinPSI.UControls;

namespace WinPSI.Sale
{
    public partial class FrmSaleOutStore : SheetFormParent
    {
        public FrmSaleOutStore()
        {
            InitializeComponent();
        } 
         
         
        string uName = "";//账号
        private FInfoModel fModel = null;//列表页传过来的信息对象 
        int actType = 1;//页面状态
        int saleId = 0;//当前销售单编号 
        public UnitInfoModel selCust = null;//选择的客户
        public StoreInfoModel store = null;//选择的仓库
        int hasPay = 0;//是否已付款
        int hasFullPay = 0;//是否已付完
        bool isOpened = false;//开账状态
        public List<PayInfoModel> payList = null;//收款账户列表
        public string totalThis = "";//本次收款
        private int addGoods = 0;//是否添加商品
        public List<ViewGoodsInfoModel> chooseGoods = null;//选择的商品列表
                                                           //public event Action ReloadList;//刷新列表页数据
        /// <summary>
        /// 页面初始化   新单   清空状态     修改  ：加载指定 的单据信息，状态--按钮可用  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSaleOutStore_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                {
                    Type tagType = this.Tag.GetType();
                    if (tagType == typeof(string))
                    {
                        uName = this.Tag.ToString();
                    }
                    else if (tagType == typeof(FInfoModel))//列表页进来的
                                {
                        fModel = this.Tag as FInfoModel;
                        if (fModel != null)
                        {
                            uName = fModel.UName;
                            actType = fModel.ActType;
                            saleId = fModel.FId;
                        }

                    }
                }
                InitInfo();//初始化加载 
                        };
            act.TryCatch("销售单页面初始化异常！");
        }

        /// <summary>
        /// 初始化工作
        /// </summary>
        private void InitInfo()
        {
            if (saleId == 0)
            {
                //清空处理
                ClearInfo();
                SetBtnsEnabled(0);
            }
            else  //修改状态
            {
                //加载指定的销售单信息
                SaleOutStoreInfoModel saleInfo = RequestStar.GetSaleInfo(saleId);
                if (saleInfo != null)
                {
                    txtCustomers.Text = RequestStar.GetUnitInfo(saleInfo.UnitId).UnitName;
                    selCust = new UnitInfoModel()
                    {
                        UnitId = saleInfo.UnitId,
                        UnitName = txtCustomers.Text
                    };
                    txtOutStore.Text = RequestStar.GetStoreInfo(saleInfo.StoreId).StoreName;
                    store = new StoreInfoModel()
                    {
                        StoreId = saleInfo.StoreId,
                        StoreName = txtOutStore.Text
                    };
                    txtDealPerson.Text = saleInfo.DealPerson;
                    txtCollectType.Text = saleInfo.PayDesp;
                    txtThisAmount.Text = saleInfo.ThisAmount.ToString("0.00");
                    txtRemark.Text = saleInfo.Remark;
                    txtTotalAmount.Text = saleInfo.TotalAmount.ToString("0.00");
                    txtYHAmount.Text = saleInfo.YHAmount.ToString("0.00");
                    txtCreator.Text = saleInfo.Creator;
                    txtCreateTime.Text = saleInfo.CreateTime.ToShortDateString();
                    lblSaleNo.Text = saleInfo.SaleOutNo;
                    switch (saleInfo.IsChecked)
                    {
                        case 0:
                            lblCheckState.Text = "待审核";
                            break;
                        case 1:
                            lblCheckState.Text = "已审核";
                            break;
                        case 2:
                            lblCheckState.Text = "已作废";//未审核作废
                            break;
                        case 3:
                            lblCheckState.Text = "已红冲";//已审核作废称红冲
                            break;
                    }
                    SetBtnsEnabled(saleInfo.IsChecked);//设置页面工具项或页面按钮的可用
                    if (saleInfo.IsPayed == 1)  //已经付款但并不定付完
                        hasPay = 1;
                    if (saleInfo.IsPayFull == 1) //付完
                        hasFullPay = 1;

                    //加载商品列表
                    List<ViewSaleGoodsInfoModel> saleGoodsList = RequestStar.GetSaleGoodsList(saleId);

                    dgvGoods.AutoGenerateColumns = false;
                    dgvGoods.DataSource = saleGoodsList;
                    SetTotalInfo(saleGoodsList);//总计  数量  金额
                }
            }
            isOpened = RequestStar.GetOpenState(1);//获取开账状态
            if (!isOpened)
            {
                tsbtnAdd.Enabled = false;
                tsbtnSave.Enabled = false;
                tsbtnCheck.Enabled = false;
                tsddbtnAct.Enabled = false;
                btnAddGoods.Enabled = false;
                btnDelete.Enabled = false;
                storeList.Visible = false;
                customersList.Visible = false;
                picPayType.Visible = false;
                lblUnOpenDesp.Visible = true;
            }
            else
                lblUnOpenDesp.Visible = false;
        }

        int totalCount = 0;
        decimal totalAmount = 0;
        /// <summary>
        /// 总计数量与金额
        /// </summary>
        /// <param name="saleList"></param>
        private void SetTotalInfo(List<ViewSaleGoodsInfoModel> saleList)
        {
            totalCount = 0;
            totalAmount = 0;
            if (dgvGoods.DataSource != null)
            {
                List<ViewSaleGoodsInfoModel> list = dgvGoods.DataSource as List<ViewSaleGoodsInfoModel>;
                foreach (var pgi in list)
                {
                    totalCount += pgi.Count;
                    totalAmount += pgi.Amount;
                }
            }
            lblTotalDesp.Text = "共" + saleList.Count + "条明细";
            lblTotalCount.Text = totalCount.ToString();
            lblTotalAmount.Text = totalAmount.ToString("0.00");
            txtYHAmount.Text = lblTotalAmount.Text;
            txtTotalAmount.Text = lblTotalAmount.Text;
        }


        /// <summary>
        /// 清空
        /// </summary>
        private void ClearInfo()
        {
            txtOutStore.Clear();
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
            lblSaleNo.Text = "";
            txtCustomers.Clear();
            txtCollectType.Clear();
            txtThisAmount.Clear();
            txtTotalAmount.Clear();
            txtYHAmount.Clear();

        }

        /// <summary>
        /// 设置页面工具项或页面按钮的可用
        /// </summary>
        /// <param name="isChecked"></param>
        private void SetBtnsEnabled(int isChecked)
        {
            if (isChecked == 0)
            {
                if (saleId == 0)
                {
                    tsbtnCheck.Enabled = false;
                    tsddbtnAct.Enabled = false;
                }
                else
                {
                    tsbtnCheck.Enabled = true;
                    tsddbtnAct.Enabled = true;
                    tsmiNoUse.Enabled = true;
                }
                tsmiRedChecked.Enabled = false;
                tsbtnSave.Enabled = true;
                btnAddGoods.Enabled = true;
                btnDelete.Enabled = true;
            }
            else if (isChecked == 1)
            {
                tsddbtnAct.Enabled = true;
                tsbtnCheck.Enabled = false;
                tsmiNoUse.Enabled = false;
                tsmiRedChecked.Enabled = true;
                tsbtnSave.Enabled = false;
                btnAddGoods.Enabled = false;
                btnDelete.Enabled = false;
            }
            else  //作废 红冲
            {
                tsbtnCheck.Enabled = false;
                tsddbtnAct.Enabled = false;
                tsbtnSave.Enabled = false;
                btnAddGoods.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        /// <summary>
        /// 客户选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customersList_Click(object sender, EventArgs e)
        {
            FrmChooseUnits fChooseUnits = new FrmChooseUnits();
            fChooseUnits.Tag = new ChooseModel()
            {
                FGet = this,
                TypeCode = "Customer-SaleOutStore",
                UName = uName
            };
            fChooseUnits.SetUnit += () =>
            {
                txtCustomers.Text = selCust.UnitName;
            };
            fChooseUnits.ShowDialog();
        }

        /// <summary>
        /// 出货仓库选择
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
                TypeCode = "Store-SaleOutStore"
            };
            fChooseStore.SetStore += () =>
            {
                txtOutStore.Text = store.StoreName;
            };
            fChooseStore.ShowDialog();
        }

        /// <summary>
        /// 打开账户设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picPayType_Click(object sender, EventArgs e)
        {
            FrmPayFor fPayFor = new FrmPayFor();
            fPayFor.Tag = new PayModel()
            {
                PayType = "get",
                FGet = this,
                StrPayFor = txtCollectType.Text
            };
            fPayFor.SetPayInfo += SetPayTypeInfo;
            fPayFor.ShowDialog();
        }

        /// <summary>
        /// 设置收款账户信息
        /// </summary>
        private void SetPayTypeInfo()
        {
            string strPay = "";
            if (payList != null && payList.Count > 0)
            {
                foreach (var pi in payList)
                {
                    if (pi.PayMoney > 0)
                    {
                        if (strPay != "")
                            strPay += ";";
                        strPay += pi.PayName + " " + pi.PayMoney.ToString();
                    }
                }
            }
            txtCollectType.Text = strPay;
            txtThisAmount.Text = totalThis;
        }

        /// <summary>
        /// 添加商品明细空记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            List<ViewSaleGoodsInfoModel> list = new List<ViewSaleGoodsInfoModel>();
            int id = 0;
            if (dgvGoods.DataSource != null)
            {
                list = dgvGoods.DataSource as List<ViewSaleGoodsInfoModel>;
                dgvGoods.DataSource = null;
                List<ViewSaleGoodsInfoModel> list2 = new List<ViewSaleGoodsInfoModel>();
                foreach (var vg in list)
                {
                    if (string.IsNullOrEmpty(vg.GoodsName))
                        list2.Add(vg);
                }
                foreach (var vg in list2)
                {
                    list.Remove(vg);
                }
                id = list.Count + 1;//已添加了明细后空记录的Id
            }
            else
                id += 1; //未添加明细的空记录Id

            list.Add(new ViewSaleGoodsInfoModel()
            {
                Id = id,
                GoodsNo = "",
                GoodsTXNo = "",
                GoodsName = "",
                GUnit = "",
                Count = 0,
                SalePrice = 0,
                Amount = 0,
                Remark = ""
            });
            dgvGoods.DataSource = list;
            SetTotalInfo(list);//统计
            addGoods = 1;//添加商品
        }

        /// <summary>
        /// 双击打开商品选择页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Action act = () =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewCell cell = dgvGoods.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string colName = dgvGoods.Columns[e.ColumnIndex].Name;
                    if (addGoods == 1)
                    {
                        if (colName == "GoodsName")
                        {
                            if (!string.IsNullOrEmpty(txtOutStore.Text))
                            {
                                            //显示商品选择页面
                                            FrmChooseGoods fGoods = new FrmChooseGoods();
                                fGoods.Tag = new ChooseModel()
                                {
                                    FGet = this,
                                    UName = uName,
                                    TypeCode = "DgvGoods-SaleOutStore"
                                };
                                fGoods.SetChooseGoods += SetDgvGoods;
                                fGoods.ShowDialog();
                            }
                            else
                            {
                                MsgBoxHelper.MsgErrorShow("请先选择出货仓库！");
                                return;
                            }
                        }
                    }
                }
            };
            act.TryCatch("删除商品明细出现异常！");

        }

        /// <summary>
        /// 刷新商品明细 
        /// </summary>
        private void SetDgvGoods()
        {
            List<ViewSaleGoodsInfoModel> list = dgvGoods.DataSource as List<ViewSaleGoodsInfoModel>;
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
                list.Add(new ViewSaleGoodsInfoModel()
                {
                    Id = id,
                    GoodsId = vg.GoodsId,
                    GoodsNo = vg.GoodsNo,
                    GoodsName = vg.GoodsName,
                    GoodsTXNo = vg.GoodsTXNo,
                    GUnit = vg.GUnit,
                    Count = 1,
                    SalePrice = 0,
                    Amount = 0,
                    Remark = ""
                });
            }
            dgvGoods.DataSource = list;
            SetTotalInfo(list);//总计信息
            addGoods = 0;//不能添加商品
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //将dgv 数据源中选中的数据行的数据移除
            if (dgvGoods.DataSource != null)
            {
                if (dgvGoods.SelectedRows.Count > 0)
                {
                    List<ViewSaleGoodsInfoModel> list = dgvGoods.DataSource as List<ViewSaleGoodsInfoModel>;
                    foreach (DataGridViewRow row in dgvGoods.SelectedRows)
                    {
                        var sgInfo = row.DataBoundItem as ViewSaleGoodsInfoModel;
                        list.Remove(sgInfo);
                    }
                    dgvGoods.DataSource = null;
                    dgvGoods.DataSource = list;
                    SetTotalInfo(list);//总计
                }
            }
        }

        /// <summary>
        /// 修改数量或单位，进行自动计算并统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Action act = () =>
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
                        case "Count":
                            count = curcell.Value.GetInt();
                                        //获取价格单元格的值
                                        price = dgvGoods.Rows[e.RowIndex].Cells["SalePrice"].Value.ToString().GetDecimal();
                            break;
                        case "SalePrice":
                            price = curcell.Value.ToString().GetDecimal();
                                        //获取数量单元格的值
                                        count = dgvGoods.Rows[e.RowIndex].Cells["Count"].Value.GetInt();
                            break;
                        default: break;
                    }
                    amount = count * price;//计算金额
                                dgvGoods.Rows[e.RowIndex].Cells["Amount"].Value = amount.ToString("0.00");
                                //总计
                                SetTotalInfo((List<ViewSaleGoodsInfoModel>)dgvGoods.DataSource);
                }
            };
            act.TryCatch("商品明细编辑出现异常！");

        }

        private void txtThisAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //当输入非数字键 不让输入      0-9   . enter 
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != 46) && (e.KeyChar != 13))
                e.Handled = true;//被处理过了
            if (e.KeyChar == 13)//enter  
            {
                decimal thisMoney = txtThisAmount.Text.GetDecimal();
                txtCollectType.Text = "现金 " + thisMoney;
            }
        }

        /// <summary>
        /// 新单响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            actType = 1;
            saleId = 0;
            ClearInfo();
            SetBtnsEnabled(0);
        }

        /// <summary>
        /// 销售单保存：新增  修改
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
                int unitId = 0;
                if (selCust != null)
                    unitId = selCust.UnitId;
                string dealPerson = txtDealPerson.Text.Trim();
                string payDesp = txtCollectType.Text.Trim();
                decimal thisAmount = txtThisAmount.Text.GetDecimal();
                string remark = txtRemark.Text.Trim();
                decimal totalAmount = txtTotalAmount.Text.GetDecimal();
                decimal yhAmount = txtYHAmount.Text.GetDecimal();
                string creator = txtCreator.Text.Trim();
                DateTime createTime = DateTime.Today;
                DateTime? payTime = null;
                if (storeId == 0)
                {
                    MsgBoxHelper.MsgErrorShow("请选择出货仓库！");
                    txtOutStore.Focus();
                    return;
                }
                if (unitId == 0)
                {
                    MsgBoxHelper.MsgErrorShow("请选择客户！");
                    txtCustomers.Focus();
                    return;
                }
                if (thisAmount > totalAmount)
                {
                    MsgBoxHelper.MsgErrorShow("收款金额不能大于应收金额！");
                    txtThisAmount.Focus();
                    return;
                }
                else if (thisAmount > 0 && thisAmount <= totalAmount)
                {
                    hasPay = 1;//已收款
                                if (thisAmount == totalAmount)
                        hasFullPay = 1;//已收完
                                payTime = DateTime.Now;
                }
                if (dgvGoods.DataSource == null)
                {
                    MsgBoxHelper.MsgErrorShow("请选择销售商品！");
                    return;
                }
                else
                {
                    List<ViewSaleGoodsInfoModel> list = dgvGoods.DataSource as List<ViewSaleGoodsInfoModel>;
                    List<ViewSaleGoodsInfoModel> list2 = list;
                    foreach (var vpi in list)
                    {
                        if (string.IsNullOrEmpty(vpi.GoodsName))
                        {
                            DialogResult dr = MsgBoxHelper.MsgBoxConfirm("销售商品", $"商品不能为空，是否删除这行？");
                            if (dr == DialogResult.Yes)
                            {
                                dgvGoods.DataSource = null;
                                list2.Remove(vpi);
                                dgvGoods.DataSource = list2;
                            }
                            return;
                        }
                        else if (vpi.SalePrice == 0)
                        {
                            MsgBoxHelper.MsgErrorShow($"商品：{vpi.GoodsName}的销售单价不能为0！");
                            return;
                        }
                        else if (vpi.Count == 0)
                        {
                            MsgBoxHelper.MsgErrorShow($"商品：{vpi.GoodsName}的销售数量不能为0！");
                            return;
                        }

                    }
                }
                            //信息封装：单据信息   明细信息
                            SaleOutStoreInfoModel saleInfo = new SaleOutStoreInfoModel()
                {
                    StoreId = storeId,
                    UnitId = unitId,
                    PayDesp = payDesp,
                    ThisAmount = thisAmount,
                    TotalAmount = totalAmount,
                    YHAmount = yhAmount,
                    DealPerson = dealPerson,
                    Remark = remark,
                    IsPayed = hasPay,
                    IsPayFull = hasFullPay,
                    Creator = creator,
                    CreateTime = createTime
                };
                if (hasPay == 1)
                    saleInfo.PayTime = payTime;

                            //获取采购商品列表
                            List<ViewSaleGoodsInfoModel> listGoods = dgvGoods.DataSource as List<ViewSaleGoodsInfoModel>;
                            //提交
                            if (saleId == 0)//新单保存
                            {
                                //reStr  saleId,SaleNo
                                string reStr = RequestStar.AddSaleInfo(saleInfo, listGoods);
                    if (!string.IsNullOrEmpty(reStr))
                    {
                        MsgBoxHelper.MsgBoxShow("销售单保存", "销售单新增保存成功！");
                        string[] reStrs = reStr.Split(',');
                        saleId = reStrs[0].GetInt();//生成的销售单编号
                                    lblSaleNo.Text = reStrs[1];//生成的销售单号
                                    actType = 2;//修改页面
                                    tsddbtnAct.Enabled = true;
                        SetBtnsEnabled(0);//更新页面按钮的可用状态
                                    this.ReloadListHandler();
                    }
                    else
                    {
                        MsgBoxHelper.MsgErrorShow("销售单保存失败！");
                        return;
                    }
                }
                else//修改保存   新增后修改     单据列表页进来 
                            {
                    saleInfo.SaleId = saleId;
                    bool bl = RequestStar.UpdateSaleInfo(saleInfo, listGoods);
                    if (bl)
                    {
                        MsgBoxHelper.MsgBoxShow("销售单保存", "销售单修改保存成功！");
                        this.ReloadListHandler();
                    }
                }
            };
            act.TryCatch("销售单提交出现异常！");
        }

        private void tsbtnCheck_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (actType == 1)
                {
                    MsgBoxHelper.MsgErrorShow("销售单还未保存，不能审核！");
                    return;
                }
                if (MsgBoxHelper.MsgBoxConfirm("销售单审核", "你确定要审核该销售单吗？") == DialogResult.Yes)
                {
                    List<ViewSaleGoodsInfoModel> listGoods = dgvGoods.DataSource as List<ViewSaleGoodsInfoModel>;
                                //检查库存
                                string reStr = RequestStar.CheckGoodsCurCount(listGoods, store.StoreId);
                    if (!string.IsNullOrEmpty(reStr))
                    {
                        string[] arrStock = reStr.Split(';');
                        string[] noStockArr = arrStock.Where(s => s.Contains("0")).ToArray();
                        string[] notStockArr = arrStock.Where(s => s.Contains("1")).ToArray();//库存不足
                                    if (noStockArr.Length == 0 && notStockArr.Length == 0)//所有商品的库存足够
                                    {
                            bool bl = RequestStar.CheckSaleInfo(saleId, uName, store.StoreId);
                            if (bl)
                            {
                                lblCheckState.Text = "已审核";
                                lblCheckState.ForeColor = Color.Red;
                                SetBtnsEnabled(1);//更新页面按钮的可用
                                        }
                        }
                        else if (noStockArr.Length > 0)
                        {
                            string goodsNames = string.Join(",", noStockArr.Select(s => s.Split('-')[0]));
                            MsgBoxHelper.MsgErrorShow($"当前销售单中:{goodsNames} 的没有库存，不能进行审核！");
                            return;
                        }
                        else if (notStockArr.Length > 0)
                        {
                            string goodsNames = string.Join(",", notStockArr.Select(s => s.Split('-')[0]));
                            MsgBoxHelper.MsgErrorShow($"当前销售单中:{goodsNames} 的库存不足，不能进行审核！");
                            return;
                        }
                    }

                }
            };
            act.TryCatch("审核销售单出现异常！");
        }

        /// <summary>
        /// 销售单作废
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiNoUse_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (actType == 1)
                {
                    MsgBoxHelper.MsgErrorShow("销售单还未保存，不能作废！");
                    return;
                }
                if (MsgBoxHelper.MsgBoxConfirm("销售单作废", "你确定要作废该销售单吗？") == DialogResult.Yes)
                {
                    bool bl = RequestStar.NoUseSaleInfo(saleId);
                    if (bl)
                    {
                        lblCheckState.Text = "已作废";
                        lblCheckState.ForeColor = Color.Gray;
                        SetBtnsEnabled(2);//更新页面按钮的可用
                                }
                }
            };
            act.TryCatch("作废销售单出现异常！");
        }

        /// <summary>
        /// 销售单红冲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRedChecked_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (actType == 1)
                {
                    MsgBoxHelper.MsgErrorShow("销售单还未保存，不能红冲！");
                    return;
                }
                else if (actType == 2 && lblCheckState.Text.Trim() == "待审核")
                {
                    MsgBoxHelper.MsgErrorShow("销售单还未审核，不能红冲！");
                    return;
                }
                if (MsgBoxHelper.MsgBoxConfirm("销售单红冲", "你确定要红冲该销售单吗？") == DialogResult.Yes)
                {
                    bool bl = RequestStar.RedCheckSaleInfo(saleId, store.StoreId);
                    if (bl)
                    {
                        lblCheckState.Text = "已红冲";
                        lblCheckState.ForeColor = Color.Green;
                        SetBtnsEnabled(3);//更新页面按钮的可用
                                }
                }
            };
            act.TryCatch("红冲销售单出现异常！");
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            if (actType == 1)
            {
                if (MsgBoxHelper.MsgBoxConfirm("销售单", "该单据并未保存，你确定要关闭销售单页面吗？") == DialogResult.Yes)
                {
                    this.CloseForm();
                }
            }
            else
                this.CloseForm();
        }
    }

}
