using PSI.BLL;
using PSI.Common;
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

namespace WinPSI.Stock
{
        public partial class FrmSetMore : Form
        {
                public FrmSetMore()
                {
                        InitializeComponent();
                }
                public event Action ReloadList;//刷新上下限列表
                StockSetMoreModel sModel = null;
                private StockBLL stockBLL = new StockBLL();
                /// <summary>
                /// 页面加载
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void FromSetMore_Load(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                if (this.Tag != null)
                                {
                                        sModel = this.Tag as StockSetMoreModel;
                                        lblStoreName.Text = sModel.StoreName;
                                        chkDown.Checked = true;
                                        chkUp.Checked = true;
                                }
                        };
                        act.TryCatch("批量设置上下限页面加载异常！");

                }

                private void chkUp_CheckedChanged(object sender, EventArgs e)
                {
                        if (chkUp.Checked)
                        {
                                txtStockUp.Enabled = true;
                        }
                        else
                                txtStockUp.Enabled = false;
                }

                private void chkDown_CheckedChanged(object sender, EventArgs e)
                {
                        if (chkDown.Checked)
                        {
                                txtStockDown.Enabled = true;
                        }
                        else
                                txtStockDown.Enabled = false;
                }
                /// <summary>
                /// 保存设置
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void btnSave_Click(object sender, EventArgs e)
                {
                        int down = txtStockDown.Text.GetInt();
                        int up = txtStockUp.Text.GetInt();
                        bool blSave = stockBLL.SetMoreGoodsStockUpDown(sModel.StoreUpDownList,  up, down);
                        if (blSave)
                        {
                                MsgBoxHelper.MsgBoxShow("批量设置库存上下限", "保存成功！");
                                this.ReloadList?.Invoke();
                                this.Close();
                        }
                        else
                        {
                                MsgBoxHelper.MsgErrorShow("保存失败！");
                                return;
                        }
                }

                private void btnCancel_Click(object sender, EventArgs e)
                {
                        this.Close();
                }
        }
}
