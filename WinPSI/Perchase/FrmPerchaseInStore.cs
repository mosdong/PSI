﻿using PSI.BLL;
using PSI.Common;
using PSI.Models.DModels;
using PSI.Models.VModels;
using WinPSI.BM;
using WinPSI.FModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI.Models.UIModels;
using WinPSI.UControls;
using WinPSI.Request;

namespace WinPSI.Perchase
{
        public partial class FrmPerchaseInStore : SheetFormParent
        {
                public FrmPerchaseInStore()
                {
                        InitializeComponent();
                }
                PerchaseInStoreBLL perBLL = new PerchaseInStoreBLL();
             
                SysBLL sysBLL = new SysBLL();
                 
                private FInfoModel fModel = null;
                public UnitInfoModel selUnit = null;//选择的单位信息
                public StoreInfoModel store = null;//选择的仓库
                private string uName = "";
                public List<PayInfoModel> payList = null;//付款账户列表
                public string totalThis =null;//本次付款总金额
                private int actType = 1;//页面状态
                private int perId =0;//当前编辑状态下采购单编号
                private int hasPay = 0;//是否已付款
                private int hasFullPay = 0;//是否已全付
                private bool isOpened = false;//开账状态
                private int addGoods = 0;//添加商品明细状态值
                public List<ViewGoodsInfoModel> chooseGoods = null;//选择的商品
                //public event Action ReloadList;//刷新列表页数据
                /// <summary>
                /// 打开往来单位选择页面
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void suppliersList_Click(object sender, EventArgs e)
                {
                        FrmChooseUnits fChooseUnits = new FrmChooseUnits();
                        fChooseUnits.Tag = new ChooseModel()
                        {
                                FGet = this,
                                TypeCode = "Supplier-PerInStore",
                                UName =uName
                        };
                        fChooseUnits.SetUnit += () =>
                        {
                                txtSuppliers.Text = selUnit.UnitName;
                        };
                        fChooseUnits.ShowDialog();
                }

                private void FrmPerchaseInStore_Load(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                if(this.Tag!=null)
                                {
                                        Type tagType = this.Tag.GetType();
                                        if(tagType==typeof(string))
                                        {
                                                uName = this.Tag.ToString();
                                        }
                                        else if(tagType ==typeof(FInfoModel))
                                        {
                                                fModel = this.Tag as FInfoModel;
                                                if(fModel !=null)
                                                {
                                                        uName = fModel.UName;
                                                        actType = fModel.ActType;
                                                        perId = fModel.FId;
                                                }
                                                      
                                        }
                                }
                                InitInfo();
                        };
                        act.TryCatch("采购单页面初始化异常！");
                }

                /// <summary>
                /// 页面初始化工作
                /// </summary>
                private void InitInfo()
                {
                       if(perId ==0)
                        {
                                //清空处理
                                ClearInfo();
                                SetBtnsEnabled(0);
                        }
                       else  //修改状态
                        {
                                //加载指定的采购单信息
                                PerchaseInStoreInfoModel perInfo = perBLL.GetPerchaseInfo(perId);
                                if(perInfo!=null)
                                {
                                        txtSuppliers.Text = RequestStar.GetUnitInfo(perInfo.UnitId).UnitName;
                                        selUnit = new UnitInfoModel()
                                        {
                                                UnitId = perInfo.UnitId,
                                                UnitName = txtSuppliers.Text
                                        };
                                        txtInStore.Text = RequestStar.GetStoreInfo(perInfo.StoreId).StoreName;
                                        store = new StoreInfoModel()
                                        {
                                                StoreId = perInfo.StoreId,
                                                StoreName = txtInStore.Text
                                        };
                                        txtDealPerson.Text = perInfo.DealPerson;
                                        txtPayForType.Text = perInfo.PayDesp;
                                        txtThisAmount.Text = perInfo.ThisAmount.ToString("0.00");
                                        txtRemark.Text = perInfo.Remark;
                                        txtTotalAmount.Text = perInfo.TotalAmount.ToString("0.00");
                                        txtYHAmount.Text = perInfo.YHAmount.ToString("0.00");
                                        txtCreator.Text = perInfo.Creator;
                                        txtCreateTime.Text = perInfo.CreateTime.ToShortDateString();
                                        lblPerNo.Text = perInfo.PerchaseNo;
                                        switch (perInfo.IsChecked)
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
                                        SetBtnsEnabled(perInfo.IsChecked);//设置页面工具项或页面按钮的可用
                                        if (perInfo.IsPayed == 1)  //已经付款但并不定付完
                                                hasPay = 1;
                                        if (perInfo.IsPayFull == 1) //付完
                                                hasFullPay = 1;

                                        //加载商品列表
                                        List<ViewPerGoodsInfoModel> perGoodsList = perBLL.GetPerGoodsList(perId);

                                        dgvGoods.AutoGenerateColumns = false;
                                        dgvGoods.DataSource = perGoodsList;
                                        SetTotalInfo(perGoodsList);//总计  数量  金额
                                }
                        }
                        isOpened = sysBLL.GetOpenState(1);
                        if (!isOpened)
                        {
                                tsbtnAdd.Enabled = false;
                                tsbtnSave.Enabled = false;
                                tsbtnCheck.Enabled = false;
                                tsddbtnAct.Enabled = false;
                                btnAddGoods.Enabled = false;
                                btnDelete.Enabled = false;
                                storeList.Visible = false;
                                suppliersList.Visible = false;
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
                /// <param name="perList"></param>
                private void SetTotalInfo(List<ViewPerGoodsInfoModel> perList)
                {
                        totalCount = 0;
                        totalAmount = 0;
                        if (dgvGoods.DataSource != null)
                        {
                                List<ViewPerGoodsInfoModel> list = dgvGoods.DataSource as List<ViewPerGoodsInfoModel>;
                                foreach (var pgi in list)
                                {
                                        totalCount += pgi.Count;
                                        totalAmount += pgi.Amount;
                                }
                        }
                        lblTotalDesp.Text = "共" + perList.Count + "条明细";
                        lblTotalCount.Text = totalCount.ToString();
                        lblTotalAmount.Text = totalAmount.ToString("0.00");
                        txtYHAmount.Text = lblTotalAmount.Text;
                        txtTotalAmount.Text = lblTotalAmount.Text;
                }

                /// <summary>
                /// 设置页面工具项或页面按钮的可用
                /// </summary>
                /// <param name="isChecked"></param>
                private void SetBtnsEnabled(int isChecked)
                {
                        if (isChecked == 0)
                        {
                                if (perId == 0)
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
                /// 清空
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
                        lblPerNo.Text = "";
                        txtSuppliers.Clear();
                        txtPayForType.Clear();
                        txtThisAmount.Clear();
                        txtTotalAmount.Clear();
                        txtYHAmount.Clear();
                }

                /// <summary>
                /// 显示多账户付款设置页面
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void picPayType_Click(object sender, EventArgs e)
                {
                        FrmPayFor fPayFor = new FrmPayFor();
                        fPayFor.Tag = new PayModel()
                        {
                                PayType="pay",
                                FGet=this,
                                StrPayFor=txtPayForType.Text
                        };
                        fPayFor.SetPayInfo += SetPayTypeInfo;
                        fPayFor.ShowDialog();
                }

                /// <summary>
                /// 设置付款账户信息
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
                        txtPayForType.Text = strPay;
                        txtThisAmount.Text =totalThis ;
                }



                /// <summary>
                /// 按下键触发   输入：数字或点（.） enter 
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void txtThisAmount_KeyPress(object sender, KeyPressEventArgs e)
                {
                        //当输入非数字键 不让输入  0-9   . enter 
                        if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != 46) && (e.KeyChar != 13))
                                e.Handled = true;
                        if (e.KeyChar == 13)//enter  
                        {
                                decimal thisMoney = txtThisAmount.Text.GetDecimal();
                                txtPayForType.Text = "现金 " + thisMoney;
                        }
                }

                /// <summary>
                /// 选择入库仓库
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
                                TypeCode = "Store-PerchaseInStore"
                        };
                        fChooseStore.SetStore += () =>
                        {
                                txtInStore.Text = store.StoreName;
                        };
                        fChooseStore.ShowDialog();
                }

                /// <summary>
                /// 添加商品明细空记录
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void btnAddGoods_Click(object sender, EventArgs e)
                {
                        List<ViewPerGoodsInfoModel> list = new List<ViewPerGoodsInfoModel>();
                        int id = 0;
                        if (dgvGoods.DataSource != null)
                        {
                                list = dgvGoods.DataSource as List<ViewPerGoodsInfoModel>;
                                dgvGoods.DataSource = null;
                                List<ViewPerGoodsInfoModel> list2 = new List<ViewPerGoodsInfoModel>();
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

                        list.Add(new ViewPerGoodsInfoModel()
                        {
                                Id = id,
                                GoodsNo = "",
                                GoodsTXNo = "",
                                GoodsName = "",
                                GUnit = "",
                                Count = 0,
                                PerPrice = 0,
                                Amount = 0,
                                Remark = ""
                        });
                        dgvGoods.DataSource = list;
                        SetTotalInfo(list);
                        addGoods = 1;//添加商品
                }

                /// <summary>
                /// 双击商品名称列单元格，显示商品选择页面
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
                                                //显示商品选择页面
                                                FrmChooseGoods fGoods = new FrmChooseGoods();
                                                fGoods.Tag = new ChooseModel()
                                                {
                                                        FGet = this,
                                                        UName = uName,
                                                        TypeCode = "DgvGoods-PerchaseInStore"
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

                //刷新商品明细
                private void SetDgvGoods()
                {
                        List<ViewPerGoodsInfoModel> list = dgvGoods.DataSource as List<ViewPerGoodsInfoModel>;
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
                                list.Add(new ViewPerGoodsInfoModel()
                                {
                                        Id = id,
                                        GoodsId = vg.GoodsId,
                                        GoodsNo = vg.GoodsNo,
                                        GoodsName = vg.GoodsName,
                                        GoodsTXNo = vg.GoodsTXNo,
                                        GUnit = vg.GUnit,
                                        Count = 1,
                                        PerPrice = 0,
                                        Amount = 0,
                                        Remark = ""
                                });
                        }
                        dgvGoods.DataSource = list;
                        SetTotalInfo(list);//总计信息
                        addGoods = 0;//不能添加商品
                }

                /// <summary>
                /// 明细移除
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
                                        List<ViewPerGoodsInfoModel> list = dgvGoods.DataSource as List<ViewPerGoodsInfoModel>;
                                        foreach (DataGridViewRow row in dgvGoods.SelectedRows)
                                        {
                                                var sgInfo = row.DataBoundItem as ViewPerGoodsInfoModel;
                                                list.Remove(sgInfo);
                                        }
                                        dgvGoods.DataSource = null;
                                        dgvGoods.DataSource = list;
                                        SetTotalInfo(list);//总计
                                }
                        }
                }

                /// <summary>
                /// 单元格编辑模式停止时发生    单元格里输入完毕后，按enter后触发
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
                                        case "Count":
                                                count = curcell.Value.GetInt();
                                                //获取价格单元格的值
                                                price = dgvGoods.Rows[e.RowIndex].Cells["PerPrice"].Value.ToString().GetDecimal();
                                                break;
                                        case "PerPrice":
                                                price = curcell.Value.ToString().GetDecimal();
                                                //获取数量单元格的值
                                                count = dgvGoods.Rows[e.RowIndex].Cells["Count"].Value.GetInt();
                                                break;
                                        default: break;
                                }
                                amount = count * price;//计算金额
                                dgvGoods.Rows[e.RowIndex].Cells["TAmount"].Value = amount.ToString("0.00");
                                //总计
                                SetTotalInfo((List<ViewPerGoodsInfoModel>)dgvGoods.DataSource);
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
                        perId = 0;
                        SetBtnsEnabled(0);
                        ClearInfo();
                }

                /// <summary>
                /// 采购单信息的提交 
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
                                if (selUnit != null)
                                        unitId = selUnit.UnitId;
                                string dealPerson = txtDealPerson.Text.Trim();
                                string payDesp = txtPayForType.Text.Trim();
                                decimal thisAmount = txtThisAmount.Text.GetDecimal();
                                string remark = txtRemark.Text.Trim();
                                decimal totalAmount = txtTotalAmount.Text.GetDecimal();
                                decimal yhAmount = txtYHAmount.Text.GetDecimal();
                                string creator = txtCreator.Text.Trim();
                                DateTime createTime = DateTime.Today;
                                DateTime? payTime = null;
                                if (storeId == 0)
                                {
                                        MsgBoxHelper.MsgErrorShow("请选择入货仓库！");
                                        txtInStore.Focus();
                                        return;
                                }
                                if(unitId==0)
                                {
                                        MsgBoxHelper.MsgErrorShow("请选择供应商！");
                                        txtSuppliers.Focus();
                                        return;
                                }
                                if (thisAmount > totalAmount)
                                {
                                        MsgBoxHelper.MsgErrorShow("付款金额不能大于应付金额！");
                                        txtThisAmount.Focus();
                                        return;
                                }
                                else if (thisAmount > 0 && thisAmount <= totalAmount)
                                {
                                        hasPay = 1;//已付款
                                        if (thisAmount == totalAmount)
                                                hasFullPay = 1;//已付完
                                        payTime = DateTime.Now;
                                }
                                if (dgvGoods.DataSource == null)
                                {
                                        MsgBoxHelper.MsgErrorShow("请选择采购商品！");
                                        return;
                                }
                                else
                                {
                                        List<ViewPerGoodsInfoModel> list = dgvGoods.DataSource as List<ViewPerGoodsInfoModel>;
                                        List<ViewPerGoodsInfoModel> list2 = list;
                                        foreach (var vpi in list)
                                        {
                                                if (string.IsNullOrEmpty(vpi.GoodsName))
                                                {
                                                        DialogResult dr = MsgBoxHelper.MsgBoxConfirm("采购商品", $"商品不能为空，是否删除这行？");
                                                        if (dr == DialogResult.Yes)
                                                        {
                                                                dgvGoods.DataSource = null;
                                                                list2.Remove(vpi);
                                                                dgvGoods.DataSource = list2;
                                                        }
                                                        return;
                                                }
                                                else if (vpi.PerPrice == 0)
                                                {
                                                        MsgBoxHelper.MsgErrorShow($"商品：{vpi.GoodsName}的采购单价不能为0！");
                                                        return;
                                                }
                                                else if (vpi.Count == 0)
                                                {
                                                        MsgBoxHelper.MsgErrorShow($"商品：{vpi.GoodsName}的采购数量不能为0！");
                                                        return;
                                                }

                                        }
                                }
                                //信息封装：单据信息   明细信息
                                PerchaseInStoreInfoModel perInfo = new PerchaseInStoreInfoModel()
                                {
                                        StoreId = storeId,
                                        UnitId=unitId,
                                        PayDesp=payDesp,
                                        ThisAmount=thisAmount,
                                        TotalAmount=totalAmount,
                                        YHAmount=yhAmount,
                                        DealPerson = dealPerson,
                                        Remark = remark,
                                        IsPayed=hasPay,
                                        IsPayFull=hasFullPay,
                                        Creator = creator,
                                        CreateTime = createTime
                                };
                                if (hasPay == 1)
                                        perInfo.PayTime = payTime;

                                //获取采购商品列表
                                List<ViewPerGoodsInfoModel> listGoods = dgvGoods.DataSource as List<ViewPerGoodsInfoModel>;
                                //提交
                                if (perId == 0)//新单保存
                                {
                                        //reStr  perId,PerNo
                                        string reStr = perBLL.AddPerchaseInfo(perInfo, listGoods);
                                        if (!string.IsNullOrEmpty(reStr))
                                        {
                                                MsgBoxHelper.MsgBoxShow("采购单保存", "采购单新增保存成功！");
                                                string[] reStrs = reStr.Split(',');
                                                perId = reStrs[0].GetInt();//生成的采购单编号
                                                lblPerNo.Text = reStrs[1];//生成的采购单号
                                                actType = 2;
                                                tsddbtnAct.Enabled = true;
                                                SetBtnsEnabled(0);//更新页面按钮的可用状态
                                                this.ReloadListHandler();
                                        }
                                        else
                                        {
                                                MsgBoxHelper.MsgErrorShow("采购单保存失败！");
                                                return;
                                        }
                                }
                                else//修改保存   新增后修改     单据列表页进来 
                                {
                                        perInfo.PerId = perId;
                                        bool bl = perBLL.UpdatePerchaseInfo(perInfo, listGoods);
                                        if (bl)
                                        {
                                                MsgBoxHelper.MsgBoxShow("采购单保存", "采购单修改保存成功！");
                                                this.ReloadListHandler();
                                        }
                                }
                        };
                        act.TryCatch("采购单提交出现异常！");
                       
                }

                /// <summary>
                /// 审核单据：待审核    新增页面：待审核    已提交后才可以操作
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnCheck_Click(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                if (actType == 1)
                                {
                                        MsgBoxHelper.MsgErrorShow("采购单还未保存，不能审核！");
                                        return;
                                }
                                if (MsgBoxHelper.MsgBoxConfirm("采购单审核", "你确定要审核该采购单吗？") == DialogResult.Yes)
                                {
                                        bool bl = perBLL.CheckPerchaseInfo(perId, uName, store.StoreId);
                                        if (bl)
                                        {
                                                lblCheckState.Text = "已审核";
                                                lblCheckState.ForeColor = Color.Red;
                                                SetBtnsEnabled(1);//更新页面按钮的可用
                                        }
                                }
                        };
                        act.TryCatch("审核采购单出现异常！");
                }

                /// <summary>
                /// 作废单据：未审核单据作废
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsmiNoUse_Click(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                if (actType == 1)
                                {
                                        MsgBoxHelper.MsgErrorShow("采购单还未保存，不能作废！");
                                        return;
                                }
                                if (MsgBoxHelper.MsgBoxConfirm("采购单作废", "你确定要作废该采购单吗？") == DialogResult.Yes)
                                {
                                        bool bl = perBLL.NoUsePerchaseInfo(perId);
                                        if (bl)
                                        {
                                                lblCheckState.Text = "已作废";
                                                lblCheckState.ForeColor = Color.Gray;
                                                SetBtnsEnabled(2);//更新页面按钮的可用
                                        }
                                }
                        };
                        act.TryCatch("作废采购单出现异常！");
                }

                /// <summary>
                /// 红冲---已审核单据作废
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsmiRedChecked_Click(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                if (actType == 1)
                                {
                                        MsgBoxHelper.MsgErrorShow("采购单还未保存，不能红冲！");
                                        return;
                                }
                               else  if (actType == 2 && lblCheckState.Text.Trim() == "待审核")
                                {
                                        MsgBoxHelper.MsgErrorShow("采购单还未审核，不能红冲！");
                                        return;
                                }
                                if (MsgBoxHelper.MsgBoxConfirm("采购单红冲", "你确定要红冲该采购单吗？") == DialogResult.Yes)
                                {
                                        bool bl = perBLL.RedCheckPerchaseInfo(perId,store.StoreId);
                                        if (bl)
                                        {
                                                lblCheckState.Text = "已红冲";
                                                lblCheckState.ForeColor = Color.Green;
                                                SetBtnsEnabled(3);//更新页面按钮的可用
                                        }
                                }
                        };
                        act.TryCatch("红冲采购单出现异常！");
                }

                /// <summary>
                /// 关闭采购单页面
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnClose_Click(object sender, EventArgs e)
                {
                        if (actType == 1)
                        {
                                if (MsgBoxHelper.MsgBoxConfirm("采购单", "该单据并未保存，你确定要关闭采购单页面吗？") == DialogResult.Yes)
                                {
                                        this.CloseForm();
                                }
                        }
                        else
                                this.CloseForm();
                }

              
        }
}
