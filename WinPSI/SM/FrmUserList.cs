using PSI.BLL;
using PSI.Common;
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
using WinPSI.FModels;

namespace WinPSI.SM
{
    public partial class FrmUserList : Form
    {
        public FrmUserList()
        {
            InitializeComponent();
        }
        string uName = "";
        UserBLL userBLL = new UserBLL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowUserInfoPage(1, 0);
        }

        private void ShowUserInfoPage(int actType, int userId)
        {
            FrmUserInfo fUser = new FrmUserInfo();
            fUser.Tag = new FInfoModel()
            {
                ActType = actType,
                FId = userId,
                UName = uName,
                ReLoad = LoadUserList
            };
            fUser.ShowDialog();
        }

        /// <summary>
        /// 页面加载 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUserList_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                    uName = this.Tag.ToString();
                txtUName.Clear();//清空条件
                LoadUserList();//加载所有用户列表
            };
            act.TryCatch("用户管理页面加载异常！");

        }

        /// <summary>
        /// 按条件加载用户列表
        /// </summary>
        private void LoadUserList()
        {
            string uName = txtUName.Text.Trim();
            List<UserInfoModel> userList = userBLL.GetUserList(uName);
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = userList;
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                var enableCell = row.Cells["EnableUser"] as DataGridViewLinkCell;
                UserInfoModel userInfo = row.DataBoundItem as UserInfoModel;
                if (userInfo.UserState == 1)
                    enableCell.Value = "停用";
                else
                    enableCell.Value = "启用";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadUserList();
        }

        /// <summary>
        /// 数据行操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //单击的单元格
            DataGridViewCell curCell = dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //单击单元格的值
            string cellVal = curCell.FormattedValue.ToString();
            UserInfoModel userInfo = dgvUsers.Rows[e.RowIndex].DataBoundItem as UserInfoModel;
            switch (cellVal)
            {
                case "修改":
                    ShowUserInfoPage(2, userInfo.UserId);
                    break;
                case "停用":
                    UpdateUserState(0, userInfo.UserId);
                    break;
                case "启用":
                    UpdateUserState(1, userInfo.UserId);
                    break;
            }
        }

        /// <summary>
        /// 启用或停用用户
        /// </summary>
        /// <param name="type"></param>
        /// <param name="userId"></param>
        private void UpdateUserState(int type, int userId)
        {
            string msg = "";
            if (type == 1)
                msg = "启用";
            else
                msg = "停用";
            if (MsgBoxHelper.MsgBoxConfirm($"用户{msg}", $"您确定要{msg}该账号吗？") == DialogResult.Yes)
            {
                bool bl = false;
                if (type == 1)
                    bl = userBLL.EnableUser(userId);
                else
                    bl = userBLL.StopUser(userId);
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow($"用户{msg}", $"该用户{msg}成功！");
                    LoadUserList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow($"该用户{msg}失败！");
                    return;
                }
            }
        }

        /// <summary>
        /// 启用多用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnable_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                UpdateUsersState(1);
            };
            act.TryCatch("批量启用异常！");
        }

        /// <summary>
        /// 多用户停用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                UpdateUsersState(0);
            };
            act.TryCatch("批量停用异常！");
        }

        /// <summary>
        /// 修改多用户状态
        /// </summary>
        /// <param name="type"></param>
        private void UpdateUsersState(int type)
        {
            string actMsg = type == 1 ? "启用" : "停用";
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MsgBoxHelper.MsgErrorShow($"请选择要{actMsg}的用户！");
                return;
            }
            if (MsgBoxHelper.MsgBoxConfirm($"用户{actMsg}", $"您确定要{actMsg}这些选择的用户吗？") == DialogResult.Yes)
            {
                List<int> userIds = new List<int>();
                foreach (DataGridViewRow row in dgvUsers.SelectedRows)
                {
                    UserInfoModel userInfo = row.DataBoundItem as UserInfoModel;
                    userIds.Add(userInfo.UserId);
                }
                bool bl = false;
                if(type ==1)
                    bl = userBLL.EnableUsers(userIds);
                else
                    bl = userBLL.StopUsers(userIds);
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow($"用户{actMsg}", $"该用户{actMsg}成功！");
                    LoadUserList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow($"该用户{actMsg}失败！");
                    return;
                }
            }
        }
    }
}
