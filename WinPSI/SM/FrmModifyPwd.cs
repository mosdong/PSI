using PSI.BLL;
using PSI.Common.Encrypt;
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
    public partial class FrmModifyPwd : Form
    {
        public FrmModifyPwd()
        {
            InitializeComponent();
        }
        FMPwdModel fModel = null;
        UserBLL userBLL = new UserBLL();

        private void FrmModifyPwd_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                //接收传值
                if (this.Tag != null)
                    fModel = this.Tag as FMPwdModel;
                //显示账号信息
                if(fModel!=null)
                {
                    lblUserName.Text = fModel.UName;
                }

            };
            act.TryCatch("加载修改用户密码信息异常！");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                //接收信息
                string oldPwd = txtOldPwd.Text.Trim();
                string newPwd = txtNewPwd.Text.Trim();
                string confirmPwd = txtConfirmPwd.Text.Trim();
                //判断  空  正确  新密码是否与原始密码一 致   两次密码输入是否一致
                if(string.IsNullOrEmpty(oldPwd))
                {
                    MsgBoxHelper.MsgErrorShow("请输入原始密码！");
                    txtOldPwd.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(newPwd))
                {
                    MsgBoxHelper.MsgErrorShow("请输入新密码！");
                    txtNewPwd.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(confirmPwd))
                {
                    MsgBoxHelper.MsgErrorShow("请输入确认密码！");
                    txtConfirmPwd.Focus();
                    return;
                }
                //加密后的密码
                string loginPwd = userBLL.GetOldPwd(fModel.UName);
                string enoldPwd = MD5Encrypt.Encrypt(oldPwd);
                if (!string.IsNullOrEmpty(loginPwd))
                {
                    if(loginPwd!=enoldPwd)//判断原始密码正确性
                    {
                        MsgBoxHelper.MsgErrorShow("输入的原始密码有误,请输入正确的原始密码！");
                        txtOldPwd.Focus();
                        return;
                    }
                }
                if(oldPwd==newPwd)//检查新密码是否与原始密码相同（不同才对）
                {
                    MsgBoxHelper.MsgErrorShow("输入的新密码与原始密码不能相同！");
                    txtNewPwd.Focus();
                    return;
                }
                if(confirmPwd!=newPwd)//新密码与确认密码是否一致（相同，不同就错了）
                {
                    MsgBoxHelper.MsgErrorShow("两次密码输入不一致！");
                    txtConfirmPwd.Focus();
                    return;
                }
               
                //加密处理
                string enNewPwd = MD5Encrypt.Encrypt(newPwd);
                //密码提交 
                bool bl = userBLL.UpdateUserPwd(fModel.UName, enNewPwd);
                if(bl)
                {
                    MsgBoxHelper.MsgBoxShow("密码修改", "登录密码修改成功！请重新登录！");
                    //重新登录的处理
                    this.Close();
                    fModel.FMain.Hide();
                    fModel.FLogin.Show();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow("用户密码修改失败！");
                    return;
                }
            };
            act.TryCatch("加载修改用户密码信息异常！");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }
    }
}
