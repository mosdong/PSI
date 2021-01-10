using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Request;

namespace WinPSI.SM
{
    public partial class FrmMenuList : Form
    {
        public FrmMenuList()
        {
            InitializeComponent();
        } 
        private string uName = "";//登录者账号
        private void FrmMenuList_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                    uName = this.Tag.ToString();
                txtKeyWords.Clear();
                LoadMenuList();//加载所有菜单信息
            };
            act.TryCatch("菜单管理页面加载异常！");
        }

        /// <summary>
        /// 条件查询菜单信息
        /// </summary>
        private void LoadMenuList()
        {
            string keywords = txtKeyWords.Text.Trim();
            //调用BLL 查询方法，获取菜单数据
            List<MenuInfoModel> list = RequestStar.GetMenuListByKeyWords(keywords);
            dgvMenus.AutoGenerateColumns = false;
            dgvMenus.DataSource = list;

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadMenuList();
        }

        /// <summary>
        /// 打开菜单信息页面（新增、修改、详情、添加子菜单）
        /// </summary>
        /// <param name="actType"></param>
        /// <param name="menuId"></param>
        private void ShowMenuInfoPage(int actType, int menuId)
        {
            FrmMenuInfo fMenu = new FrmMenuInfo();
            fMenu.Tag = new FInfoModel()
            {
                ActType = actType,
                UName = uName,
                FId = menuId,
                ReLoad = LoadMenuList
            };
            fMenu.ShowDialog();

        }

        /// <summary>
        /// 新增菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            ShowMenuInfoPage(1, 0);
        }

        /// <summary>
        /// 修改菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMenus.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMenus.SelectedRows[0];
                MenuInfoModel menuInfo = row.DataBoundItem as MenuInfoModel;
                ShowMenuInfoPage(2, menuInfo.MId);
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("请选择你要修改的菜单信息！");
                return;
            }
        }

        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            if (dgvMenus.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMenus.SelectedRows[0];
                MenuInfoModel menuInfo = row.DataBoundItem as MenuInfoModel;
                ShowMenuInfoPage(4, menuInfo.MId);
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("请选择你要查看的菜单信息！");
                return;
            }
        }

        private void dgvMenus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Action act = () =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewCell curCell = dgvMenus.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string cellVal = curCell.FormattedValue.ToString();
                    MenuInfoModel menuInfo = dgvMenus.Rows[e.RowIndex].DataBoundItem as MenuInfoModel;
                    switch (cellVal)
                    {
                        case "添加子菜单":
                            ShowMenuInfoPage(3, menuInfo.MId);
                            break;
                        case "修改":
                            ShowMenuInfoPage(2, menuInfo.MId);
                            break;
                        case "删除":
                            if (MsgBoxHelper.MsgBoxConfirm("删除菜单", "您确定要删除该菜单信息吗？删除菜单会连同菜单及其角色菜单关系数据一并删除？") == DialogResult.Yes)
                            {
                                //删除
                                List<int> menuIds = new List<int>();
                                menuIds.Add(menuInfo.MId);
                                bool bl = RequestStar.DeleteMenu(menuIds, 0);
                                if (bl)
                                {
                                    MsgBoxHelper.MsgBoxShow("删除菜单", $"菜单：{menuInfo.MName} 删除成功！");
                                    LoadMenuList();
                                }
                                else
                                {
                                    MsgBoxHelper.MsgErrorShow($"菜单：{menuInfo.MName} 删除失败！");
                                    return;
                                }
                            }
                            break;
                    }
                }
            };
            act.TryCatch("菜单数据操作异常！");

        }



        /// <summary>
        /// 删除菜单信息  一条或多条都可以
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMenus.SelectedRows.Count == 0)
            {
                MsgBoxHelper.MsgErrorShow("请选择要删除的菜单信息！");
                return;
            }
            if (MsgBoxHelper.MsgBoxConfirm("菜单删除", "您确定要删除选择的菜单信息吗？删除菜单会连同菜单及其角色菜单关系数据一并删除？") == DialogResult.Yes)
            {
                List<int> menuIds = new List<int>();
                foreach (DataGridViewRow row in dgvMenus.SelectedRows)
                {
                    MenuInfoModel menuInfo = row.DataBoundItem as MenuInfoModel;
                    menuIds.Add(menuInfo.MId);
                }
                bool bl = RequestStar.DeleteMenu(menuIds, 0);
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow("删除菜单", "选择的菜单信息删除成功！");
                    LoadMenuList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow("选择的菜单信息删除失败！");
                    return;
                }
            }
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }
    }
}
