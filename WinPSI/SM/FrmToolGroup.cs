using PSI.BLL;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPSI.SM
{
    public partial class FrmToolGroup : Form
    {
        public FrmToolGroup()
        {
            InitializeComponent();
        }
        string uName = "";
        ToolGroupBLL tgBLL = new ToolGroupBLL();
        ToolMenuBLL tmBLL = new ToolMenuBLL();
        string oldName = "";
        private void FrmToolGroup_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                    uName = this.Tag.ToString();
                panelInfo.Visible = false;
                chkShowDel.Checked = false;
               
                LoadToolGroups();
            };
            act.TryCatch("工具组列表加载异常！");
        }

        /// <summary>
        /// 加载所有的工具组列表
        /// </summary>
        private void LoadToolGroups()
        {
            SetActColsShow(chkShowDel.Checked);
            dgvGroups.AutoGenerateColumns = false;
            List<ToolGroupInfoModel> list = tgBLL.GetToolGroups(chkShowDel.Checked);
            dgvGroups.DataSource = list;
        }

        private void SetActColsShow(bool blShow)
        {
            if(blShow)
            {
                btnDel.Enabled = false;
                btnRecover.Enabled = true;
                dgvGroups.Columns["Edit"].Visible = false;
                dgvGroups.Columns["Delete"].Visible = false;
                dgvGroups.Columns["Recover"].Visible = true;
                dgvGroups.Columns["Remove"].Visible = true;
            }
            else
            {
                btnDel.Enabled = true;
                btnRecover.Enabled = false;
                dgvGroups.Columns["Edit"].Visible = true;
                dgvGroups.Columns["Delete"].Visible = true;
                dgvGroups.Columns["Recover"].Visible = false;
                dgvGroups.Columns["Remove"].Visible = false;
            }
        }

        int tgId = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelInfo.Visible = true;
            tgId = 0;
            btnOk.Text = "添加";
            txtGroupName.Clear();
        }

        private void dgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Action act = () =>
            {
                if (e.RowIndex >= 0)
                {
                    var curCell = dgvGroups.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    ToolGroupInfoModel tgInfo = dgvGroups.Rows[e.RowIndex].DataBoundItem as ToolGroupInfoModel;
                    string cellVal = curCell.FormattedValue.ToString();
                    switch (cellVal)
                    {
                        case "修改":
                            panelInfo.Visible = true;
                            tgId = tgInfo.TGroupId;
                            btnOk.Text = "修改";
                            txtGroupName.Text = tgInfo.TGroupName;
                            oldName = tgInfo.TGroupName;
                            break;
                        case "删除":
                            DeleteToolGroupInfo(tgInfo);
                            break;
                        case "恢复":
                            RecoverToolGroupInfo(tgInfo);
                            break;
                        case "永久删除":
                            RemoveToolGroupInfo(tgInfo);
                            break;
                    }
                }
            };
            act.TryCatch("修改或删除工具组数据异常！");
        }

        /// <summary>
        /// 永久删除工具组
        /// </summary>
        /// <param name="tgInfo"></param>
        private void RemoveToolGroupInfo(ToolGroupInfoModel tgInfo)
        {
            string title = "永久删除工具组";
            if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要永久删除该工具组数据吗,删除了就无法再恢复?") == DialogResult.Yes)
            {
                bool bl = tgBLL.DeleteToolGroup(tgInfo.TGroupId);
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(title, $"工具组：{tgInfo.TGroupName} 永久删除成功！");
                    LoadToolGroups();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow($"工具组：{tgInfo.TGroupName} 永久删除失败！");
                    return;
                }
            }
        }

        private void RecoverToolGroupInfo(ToolGroupInfoModel tgInfo)
        {
            string title = "恢复工具组";
            if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要恢复该工具组数据吗？") == DialogResult.Yes)
            {
                bool bl = tgBLL.RecoverToolGroup(tgInfo.TGroupId);
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(title, $"工具组：{tgInfo.TGroupName} 恢复成功！");
                    LoadToolGroups();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow($"工具组：{tgInfo.TGroupName} 恢复失败！");
                    return;
                }
            }
        }

        /// <summary>
        /// 删除工具组
        /// </summary>
        /// <param name="tgInfo"></param>
        private void DeleteToolGroupInfo(ToolGroupInfoModel tgInfo)
        {
            string title = "删除工具组";
            if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要删除该工具组数据吗？") == DialogResult.Yes)
            {
                //先检查是否已添加工具菜单数据
                List<int> tgIds = new List<int>();
                tgIds.Add(tgInfo.TGroupId);
                if (!tmBLL.HasToolMenus(tgIds))
                {
                    bool bl = tgBLL.LogicDeleteToolGroup(tgInfo.TGroupId);
                    if (bl)
                    {
                        MsgBoxHelper.MsgBoxShow(title, $"工具组：{tgInfo.TGroupName} 删除成功！");
                        LoadToolGroups();
                    }
                    else
                    {
                        MsgBoxHelper.MsgErrorShow($"工具组：{tgInfo.TGroupName} 删除失败！");
                        return;
                    }
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow($"工具组：{tgInfo.TGroupName} 已添加工具菜单项，不能删除！");
                    return;
                }
            }
        }

        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            LoadToolGroups();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string title = "删除工具组";
            if(dgvGroups.SelectedRows.Count>0)
            {
                if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要删除这些工具组数据吗？") == DialogResult.Yes)
                {
                    //获取要删除的Id
                    List<int> tgIds = new List<int>();
                    foreach (DataGridViewRow row in dgvGroups.SelectedRows)
                    {
                        ToolGroupInfoModel tgInfo = row.DataBoundItem as ToolGroupInfoModel;
                        tgIds.Add(tgInfo.TGroupId);
                    }
                    //先检查是否已添加工具菜单数据

                    if (!tmBLL.HasToolMenus(tgIds))
                    {
                        bool bl = tgBLL.LogicDeleteToolGroups(tgIds);
                        if (bl)
                        {
                            MsgBoxHelper.MsgBoxShow(title, "这些工具组删除成功！");
                            LoadToolGroups();
                        }
                        else
                        {
                            MsgBoxHelper.MsgErrorShow("这些工具组删除失败！");
                            return;
                        }
                    }
                    else
                    {
                        MsgBoxHelper.MsgErrorShow($"选择的工具组中有的已添加工具菜单项，不能删除！");
                        return;
                    }
                }
            }
            
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            string title = "恢复工具组";
            if (dgvGroups.SelectedRows.Count > 0)
            {
                if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要恢复这些工具组数据吗？") == DialogResult.Yes)
                {
                    //获取要恢复的Id
                    List<int> tgIds = new List<int>();
                    foreach (DataGridViewRow row in dgvGroups.SelectedRows)
                    {
                        ToolGroupInfoModel tgInfo = row.DataBoundItem as ToolGroupInfoModel;
                        tgIds.Add(tgInfo.TGroupId);
                    }
                    bool bl = tgBLL.RecoverToolGroups(tgIds);
                    if (bl)
                    {
                        MsgBoxHelper.MsgBoxShow(title, "这些工具组恢复成功！");
                        LoadToolGroups();
                    }
                    else
                    {
                        MsgBoxHelper.MsgErrorShow("这些工具组恢复失败！");
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// 提交响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            string gName = txtGroupName.Text.Trim();
            if(string.IsNullOrEmpty(gName))
            {
                MsgBoxHelper.MsgErrorShow("请输入组名！");
                txtGroupName.Focus();
                return;
            }
            if(tgId==0||(tgId>0&&oldName!=gName))
            {
                if (tgBLL.ExistName(gName))
                {
                    MsgBoxHelper.MsgErrorShow("该组名已存在，请重新输入组名！");
                    txtGroupName.Focus();
                    return;
                }
            }
            ToolGroupInfoModel tgInfo = new ToolGroupInfoModel()
            {
                TGroupName = gName,
                Creator = uName,
                TGroupId=tgId
            };
            bool bl = false;
            bl = tgBLL.ConfirmToolGroup(tgInfo);
            string actMsg = "";
            actMsg = tgId == 0 ? "添加" : "修改";
            string msgTitle = $"{actMsg}工具组";
            string sucMsg = bl ? "成功" : "失败";
            string msg = $"工具组：{gName} {actMsg} {sucMsg}！";
            if (bl)
            {
                MsgBoxHelper.MsgBoxShow(msgTitle,msg);
                LoadToolGroups();
            }
            else
            {
                MsgBoxHelper.MsgErrorShow(msg);
                return;
            }
        }
    }
}
