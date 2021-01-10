using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Request;

namespace WinPSI.SM
{
    public partial class FrmToolMenuList : Form
    {
        public FrmToolMenuList()
        {
            InitializeComponent();
        }
        private string uName = "";  
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmToolMenuList_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                    uName = this.Tag.ToString();
                chkShowDel.Checked = false;
                //绑定ComboBox列  工具组列表
                LoadTGroups();
                //加载工具项列表数据
                LoadTMenuList();


            };
            act.TryCatch("工具菜单列表加载异常");
        }

        private void LoadTMenuList()
        {
            string keywords = txtKeyWords.Text.Trim();
            bool blShow = chkShowDel.Checked;
            SetActColsShow(blShow);//控制操作列的显示
            //获取数据
            List<ToolMenuInfoModel> list = RequestStar.GetToolMenuInfos(keywords, blShow);

            //判断是否有数据，处理工具栏中按钮项 启用处理
            if (list.Count > 0)
            {
                dgvTMenus.AutoGenerateColumns = false;
                dgvTMenus.DataSource = list;
                SetToolBtnsEnable(true);
            }
            else
            {
                dgvTMenus.DataSource = null;
                SetToolBtnsEnable(false);
            }
        }

        private void SetActColsShow(bool blShow)
        {
            if (blShow)
            {
                dgvTMenus.Columns["Edit"].Visible = false;
                dgvTMenus.Columns["Del"].Visible = false;
                dgvTMenus.Columns["Recover"].Visible = true;
                tsbtnRecover.Enabled = true;
                tsbtnDelete.Enabled = false;
                tsbtnEdit.Enabled = false;
            }
            else
            {
                dgvTMenus.Columns["Edit"].Visible = true;
                dgvTMenus.Columns["Del"].Visible = true;
                dgvTMenus.Columns["Recover"].Visible = false;
                tsbtnRecover.Enabled = false;
                tsbtnDelete.Enabled = true;
                tsbtnEdit.Enabled = true;
            }
        }

        /// <summary>
        /// 按钮启用处理
        /// </summary>
        /// <param name="blEnable"></param>
        private void SetToolBtnsEnable(bool blEnable)
        {
            tsbtnDelete.Enabled = blEnable;
            tsbtnEdit.Enabled = blEnable;
            tsbtnInfo.Enabled = blEnable;
        }

        private void LoadTGroups()
        {
            List<ToolGroupInfoModel> list = RequestStar.GetToolGroups();
            //获取下拉框列
            DataGridViewComboBoxColumn col = dgvTMenus.Columns["TGroupId"] as DataGridViewComboBoxColumn;
            col.DisplayMember = "TGroupName";
            col.ValueMember = "TGroupId";
            col.DataSource = list;

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadTMenuList();
            if (dgvTMenus.Rows.Count == 0)
            {
                MsgBoxHelper.MsgErrorShow("没有符合条件的数据!");
                return;
            }
        }

        /// <summary>
        /// 打开工具组列表页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnToolGroup_Click(object sender, EventArgs e)
        {
            FrmToolGroup fToolGroup = new FrmToolGroup();
            fToolGroup.Tag = uName;
            fToolGroup.ShowDialog();
        }

        /// <summary>
        /// 打开新增工具菜单页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            ShowTMenuInfoPage(0, 1);
        }

        /// <summary>
        /// 显示工具菜单信息页面  新增  修改 详情
        /// </summary>
        /// <param name="tmenuId"></param>
        /// <param name="actType"></param>
        private void ShowTMenuInfoPage(int tmenuId, int actType)
        {
            FrmTMenuInfo fTMenuInfo = new FrmTMenuInfo();
            fTMenuInfo.Tag = new FInfoModel()
            {
                FId = tmenuId,
                ActType = actType,
                UName = uName,
                ReLoad = LoadTMenuList
            };
            fTMenuInfo.ShowDialog();
        }

        /// <summary>
        /// 打开修改工具菜单信息页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTMenus.SelectedRows.Count > 0)
            {
                ToolMenuInfoModel tmInfo = dgvTMenus.SelectedRows[0].DataBoundItem as ToolMenuInfoModel;
                ShowTMenuInfoPage(tmInfo.TMenuId, 2);
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("请选择要修改的工具菜单项！");
                return;
            }
        }

        /// <summary>
        /// 打开工具菜单详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            if (dgvTMenus.SelectedRows.Count > 0)
            {
                ToolMenuInfoModel tmInfo = dgvTMenus.SelectedRows[0].DataBoundItem as ToolMenuInfoModel;
                ShowTMenuInfoPage(tmInfo.TMenuId, 4);
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("请选择要查看的工具菜单项！");
                return;
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
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            LoadTGroups();
            LoadTMenuList();
        }

        /// <summary>
        /// 删除工具菜单项  单个  多个
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTMenus.SelectedRows.Count == 0)
            {
                MsgBoxHelper.MsgErrorShow("您没有选择要删除的工具菜单项！");
                return;
            }
            string title = "删除工具菜单项";
            if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要删除这些工具菜单项数据吗？会连同角色工具菜单关系数据一并删除？") == DialogResult.Yes)
            {
                //获取要删除的工具菜单编号
                List<int> delIds = new List<int>();
                foreach (DataGridViewRow row in dgvTMenus.SelectedRows)
                {
                    ToolMenuInfoModel tmInfo = row.DataBoundItem as ToolMenuInfoModel;
                    delIds.Add(tmInfo.TMenuId);
                }
                //删除操作
                bool bl = RequestStar.DeleteToolMenusLogic(delIds);
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(title, "选择的工具菜单项删除成功！");
                    LoadTMenuList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow("选择的工具菜单项删除失败！");
                    return;
                }
            }
        }

        private void dgvTMenus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Action act = () =>
            {
                if (e.RowIndex >= 0)
                {
                    var curCell = dgvTMenus.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    ToolMenuInfoModel tmInfo = dgvTMenus.Rows[e.RowIndex].DataBoundItem as ToolMenuInfoModel;
                    string cellVal = curCell.FormattedValue.ToString();
                    switch (cellVal)
                    {
                        case "修改":
                            ShowTMenuInfoPage(tmInfo.TMenuId, 2);
                            break;
                        case "删除":
                            DeleToolMenuInfo(tmInfo);
                            break;
                        case "恢复":
                            RecoverToolMenuInfo(tmInfo);
                            break;
                    }
                }
            };
            act.TryCatch("修改或删除工具菜单项数据异常！");

        }

        /// <summary>
        /// 工具菜单数据恢复
        /// </summary>
        /// <param name="tmInfo"></param>
        private void RecoverToolMenuInfo(ToolMenuInfoModel tmInfo)
        {
            string title = "恢复工具菜单项";
            if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要恢复该工具菜单项数据吗？会连同角色工具菜单关系数据一并恢复？") == DialogResult.Yes)
            {
                //角色工具菜单关系数据   工具菜单信息
                bool bl = RequestStar.RecoverToolMenu(tmInfo.TMenuId);
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(title, $"工具菜单项：{tmInfo.TMenuName} 恢复成功！");
                    LoadTMenuList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow($"工具菜单项：{tmInfo.TMenuName} 恢复失败！");
                    return;
                }
            }
        }
        private void DeleToolMenuInfo(ToolMenuInfoModel tmInfo)
        {
            string title = "删除工具菜单项";
            if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要删除该工具菜单项数据吗？会连同角色工具菜单关系数据一并删除？") == DialogResult.Yes)
            {
                //删除操作 
                //角色工具菜单关系数据   工具菜单信息
                bool bl = RequestStar.DeleteToolMenuLogic(tmInfo.TMenuId);
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(title, $"工具菜单项：{tmInfo.TMenuName} 删除成功！");
                    LoadTMenuList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow($"工具菜单项：{tmInfo.TMenuName} 删除失败！");
                    return;
                }
            }
        }

        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            LoadTMenuList();
        }

        /// <summary>
        /// 恢复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnRecover_Click(object sender, EventArgs e)
        {
            if (dgvTMenus.SelectedRows.Count == 0)
            {
                MsgBoxHelper.MsgErrorShow("您没有选择要恢复的工具菜单项！");
                return;
            }
            string title = "恢复工具菜单项";
            if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要恢复这些工具菜单项数据吗？会连同角色工具菜单关系数据一并恢复？") == DialogResult.Yes)
            {
                //获取要恢复的工具菜单编号
                List<int> delIds = new List<int>();
                foreach (DataGridViewRow row in dgvTMenus.SelectedRows)
                {
                    ToolMenuInfoModel tmInfo = row.DataBoundItem as ToolMenuInfoModel;
                    delIds.Add(tmInfo.TMenuId);
                }
                //恢复操作
                bool bl = RequestStar.RecoverToolMenus(delIds);
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(title, "选择的工具菜单项恢复成功！");
                    LoadTMenuList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow("选择的工具菜单项恢复失败！");
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
