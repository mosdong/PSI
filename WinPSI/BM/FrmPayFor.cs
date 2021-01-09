using PSI.BLL;
using PSI.Models.DModels;
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
using WinPSI.Perchase;
using WinPSI.Sale;

namespace WinPSI.BM
{
        public partial class FrmPayFor : Form
        {
                public FrmPayFor()
                {
                        InitializeComponent();
                }
                //设置付款
                public event Action SetPayInfo;//设置付款信息
                private PayBLL payBLL = new PayBLL();
                private string paytype = "";
                private Form fInfo = null;
                private string strPayFor = "";

                private void FrmPayFor_Load(object sender, EventArgs e)
                {
                        if (this.Tag != null)
                        {
                                PayModel pModel = this.Tag as PayModel;
                                if (pModel != null)
                                {
                                        paytype = pModel.PayType;
                                        fInfo = pModel.FGet;
                                        strPayFor = pModel.StrPayFor;
                                }
                                List<PayInfoModel> payList = payBLL.GetFirstPayInfos(paytype, strPayFor);
                                dgvPay.AutoGenerateColumns = false;
                                dgvPay.DataSource = payList;
                                if (string.IsNullOrEmpty(strPayFor))
                                {
                                        lblTotal.Text = "0";
                                }
                                else
                                        lblTotal.Text = GetTotal(payList).ToString();

                        }
                }

                /// <summary>
                /// 总计金额
                /// </summary>
                /// <param name="payList"></param>
                /// <returns></returns>
                private decimal GetTotal(List<PayInfoModel> list)
                {
                        if (list.Count == 0)
                                return 0;
                        else
                        {
                                decimal total = 0;
                                foreach (var pi in list)
                                {
                                        total += pi.PayMoney;
                                }
                                return total;
                        }
                }

                /// <summary>
                /// 总计因输入金额变化而变化
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void dgvPay_CellValueChanged(object sender, DataGridViewCellEventArgs e)
                {
                        if (dgvPay.DataSource != null)
                        {
                                List<PayInfoModel> list = dgvPay.DataSource as List<PayInfoModel>;
                                lblTotal.Text =  GetTotal(list).ToString();
                        }
                        else
                                lblTotal.Text = "0";
                }

                private void btnOK_Click(object sender, EventArgs e)
                {
                        List<PayInfoModel> list = dgvPay.DataSource as List<PayInfoModel>;
                        if (paytype == "pay")
                        {
                                FrmPerchaseInStore frm = fInfo as FrmPerchaseInStore;
                                frm.payList = list;
                                frm.totalThis = lblTotal.Text;
                        }
                        else  if (paytype == "get")
                        {
                                FrmSaleOutStore frm = fInfo as FrmSaleOutStore;
                                frm.payList = list;
                                frm.totalThis = lblTotal.Text;

                        }
                        this.SetPayInfo?.Invoke();
                        this.Close();
                }

                private void dgvPay_CurrentCellDirtyStateChanged(object sender, EventArgs e)
                {
                        if (dgvPay.IsCurrentCellDirty)
                        {
                                dgvPay.CommitEdit(DataGridViewDataErrorContexts.Commit);
                        }
                }
        }
}
