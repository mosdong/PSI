using PSI.Common;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.Request;

namespace WinPSI.BM
{
    public partial class FrmGUnitList : Form
    {
        public FrmGUnitList()
        {
            InitializeComponent();
        }
        string uName = ""; 
        int guId = 0;//修改的单位编号
        string oldName = "";//修改前的单位名称
        public event Action GUnitsReLoad;//刷新单位下拉框
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            gbInfo.Visible = true;
            txtGUnitName.Clear();
            txtGUnitPYNo.Clear();
            txtGUnitOrder.Clear();
            btnSave.Text = "添加";
            guId = 0;
            oldName = "";
        }

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGUnitList_Load(object sender, EventArgs e)
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

                }
                gbInfo.Visible = false;
                LoadGUnitList();
            };
            act.TryCatch("计量单位管理加载异常!");

        }

        /// <summary>
        /// 加载所有的单位信息
        /// </summary>
        private void LoadGUnitList()
        {
            SetButtonEnable(chkShowDel.Checked);
            int isDeleted = chkShowDel.Checked ? 1 : 0;
            List<GoodsUnitInfoModel> list = RequestStar.GetAllUnits(isDeleted);
            dgvGUnitList.AutoGenerateColumns = false;
            if (list.Count > 0)
            {
                dgvGUnitList.DataSource = list;
            }
            else
            {
                dgvGUnitList.DataSource = null;
                dgvGUnitList.AllowUserToAddRows = false;
            }
        }

        /// <summary>
        /// 工具项的启用与操作列的显示
        /// </summary>
        /// <param name="bl"></param>
        private void SetButtonEnable(bool bl)
        {
            if (bl)
            {
                tsbtnDelete.Enabled = false;
                tsbtnEdit.Enabled = false;
                dgvGUnitList.Columns["Edit"].Visible = false;
                dgvGUnitList.Columns["Del"].Visible = false;
                dgvGUnitList.Columns["Recover"].Visible = true;
                dgvGUnitList.Columns["Remove"].Visible = true;
            }
            else
            {
                tsbtnDelete.Enabled = true;
                tsbtnEdit.Enabled = true;
                dgvGUnitList.Columns["Edit"].Visible = true;
                dgvGUnitList.Columns["Del"].Visible = true;
                dgvGUnitList.Columns["Recover"].Visible = false;
                dgvGUnitList.Columns["Remove"].Visible = false;
            }
        }

        /// <summary>
        /// 是否显示已删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            LoadGUnitList();
        }

        private void dgvGUnitList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Action act = () =>
            {
                if (e.RowIndex >= 0)
                {
                    var curCell = dgvGUnitList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    GoodsUnitInfoModel guInfo = dgvGUnitList.Rows[e.RowIndex].DataBoundItem as GoodsUnitInfoModel;
                    string cellVal = curCell.FormattedValue.ToString();
                    switch (cellVal)
                    {
                        case "修改":
                            InitEditInfo(guInfo);
                            break;
                        case "删除":
                            DeleteUnit(guInfo, 1);
                            break;
                        case "恢复":
                            DeleteUnit(guInfo, 0);
                            break;
                        case "永久删除":
                            DeleteUnit(guInfo, 2);
                            break;
                    }
                }
            };
            act.TryCatch("修改或删除工具菜单项数据异常！");
        }

        /// <summary>
        /// 加载修改状态的单位信息
        /// </summary>
        /// <param name="guInfo"></param>
        private void InitEditInfo(GoodsUnitInfoModel guInfo)
        {
            gbInfo.Visible = true;
            txtGUnitName.Text = guInfo.GUnitName;
            txtGUnitPYNo.Text = guInfo.GUnitPYNo;
            txtGUnitOrder.Text = guInfo.GUnitOrder.ToString();
            guId = guInfo.GUnitId;
            oldName = guInfo.GUnitName;
            btnSave.Text = "修改";
        }

        /// <summary>
        /// 处理行删除 恢复 永久删除
        /// </summary>
        /// <param name="guInfo"></param>
        /// <param name="actType">0--恢复  1--假删除   2---真删除</param>
        private void DeleteUnit(GoodsUnitInfoModel guInfo, int actType)
        {
            string actMsg = "";
            switch (actType)
            {
                case 0:
                    actMsg = "恢复";
                    break;
                case 1:
                    actMsg = "删除";
                    break;
                case 2:
                    actMsg = "永久删除";
                    break;
            }
            string title = actMsg + "单位";
            if (MsgBoxHelper.MsgBoxConfirm(title, $"您确定要{actMsg}该计量单位吗？") == DialogResult.Yes)
            {
                bool bl = false;
                switch (actType)
                {
                    case 0:
                        bl = RequestStar.GoodsUnitRecover(guInfo.GUnitId);
                        break;
                    case 1:
                        if (!RequestStar.GetGoodsUnitUse(guInfo.GUnitName))
                            bl = RequestStar.GoodsUnitLogicDelete(guInfo.GUnitId);
                        else
                        {
                            MsgBoxHelper.MsgErrorShow($"计量单位：{guInfo.GUnitName} 已经应用，不能删除！");
                            return;
                        }
                        break;
                    case 2:
                        bl = RequestStar.GoodsUnitDelete(guInfo.GUnitId);
                        break;
                }
                string sucMsg = bl ? "成功" : "失败";
                string msg = $"计量单位：{guInfo.GUnitName} {actMsg}{sucMsg}！";
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(title, msg);
                    LoadGUnitList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(msg);
                    return;
                }
            }
        }


        /// <summary>
        /// 新增、修改提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //接收
            string unitName = txtGUnitName.Text.Trim();
            string unitPYNo = txtGUnitPYNo.Text.Trim();
            int order = txtGUnitOrder.Text.GetInt();
            //判空处理
            if (string.IsNullOrEmpty(unitName))
            {
                MsgBoxHelper.MsgErrorShow("单位名称不能为空！");
                txtGUnitName.Focus();
                return;
            }
            if (guId == 0 || (!string.IsNullOrEmpty(oldName) && unitName != oldName))
            {
                if (RequestStar.ExistName(unitName))
                {
                    MsgBoxHelper.MsgErrorShow("单位名称已存在，请重新输入！");
                    txtGUnitName.Focus();
                    return;
                }
            }
            //封装信息
            GoodsUnitInfoModel guInfo = new GoodsUnitInfoModel()
            {
                GUnitId = guId,
                GUnitName = unitName,
                GUnitPYNo = unitPYNo,
                GUnitOrder = order,
                Creator = uName
            };
            //提交执行
            bool bl = false;
            if (guId == 0)
            {
                bl = RequestStar.AddGoodsUnit(guInfo);
            }
            else
            {
                bool blUpdateName = oldName == unitName ? false : true;
                bl = RequestStar.UpdatGoodsUnit(guInfo, blUpdateName, oldName);
            }
            //处理结果
            string actMsg = guId == 0 ? "添加" : "修改";
            string sucMsg = bl ? "成功" : "失败";
            string title = $"{actMsg}计量单位";
            string msg = $"计量单位：{unitName} {actMsg}{sucMsg}";
            if (bl)
            {
                MsgBoxHelper.MsgBoxShow(title, msg);
                LoadGUnitList();
            }
            else
            {
                MsgBoxHelper.MsgErrorShow(msg);
                return;
            }
        }

        private void txtGUnitName_TextChanged(object sender, EventArgs e)
        {
            txtGUnitPYNo.Text = PingYinHelper.GetFirstSpell(txtGUnitName.Text.Trim());
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvGUnitList.SelectedRows.Count == 0)
            {
                MsgBoxHelper.MsgErrorShow("请选择要修改的单位信息");
                return;
            }
            //SelectedRows.Count>0
            GoodsUnitInfoModel guInfo = dgvGUnitList.SelectedRows[0].DataBoundItem as GoodsUnitInfoModel;
            InitEditInfo(guInfo);

        }

        /// <summary>
        /// 删除（批量）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (dgvGUnitList.SelectedRows.Count == 0)
                {
                    MsgBoxHelper.MsgErrorShow("请选择要删除的单位信息");
                    return;
                }
                string title = "删除计量单位";
                if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要删除选择的这些计量单位信息吗？") == DialogResult.Yes)
                {
                    List<int> guIds = new List<int>();
                    foreach (DataGridViewRow row in dgvGUnitList.SelectedRows)
                    {
                        GoodsUnitInfoModel guInfo = row.DataBoundItem as GoodsUnitInfoModel;
                        if (RequestStar.GetGoodsUnitUse(guInfo.GUnitName))
                        {
                            MsgBoxHelper.MsgErrorShow($"计量单位：{guInfo.GUnitName} 已经应用，不能删除！");
                            return;
                        }
                        else
                        {
                            guIds.Add(guInfo.GUnitId);
                        }
                    }
                    bool bl = RequestStar.GoodsUnitLogicDeleteList(guIds);
                    string sucMsg = bl ? "成功" : "失败";
                    string msg = $"选择的单位信息删除 {sucMsg}";
                    if (bl)
                    {
                        MsgBoxHelper.MsgBoxShow(title, msg);
                        LoadGUnitList();
                    }
                    else
                        MsgBoxHelper.MsgErrorShow(msg);
                }
            };
            act.TryCatch("批量删除计量单位信息异常！");

        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.GUnitsReLoad?.Invoke();//执行刷新下拉框的事件
            this.CloseForm();
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            LoadGUnitList();
        }
    }
}
