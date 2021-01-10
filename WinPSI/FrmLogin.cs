using PSI.Common.Encrypt;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Request;

namespace WinPSI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }



        #region
        //无边框时，拖动改变窗体位置
        private Point fPoint;
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            fPoint = new Point(e.X, e.Y);
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - fPoint.X, this.Location.Y + e.Y - fPoint.Y);
            }
        }
        #endregion

        /// <summary>
        /// 登录系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //接收信息
            string userName = txtUName.Text.Trim();
            string userPwd = txtUPwd.Text.Trim();
            //判断是否为空
            if (string.IsNullOrEmpty(userName))
            {
                MsgBoxHelper.MsgErrorShow("账号不能为空！");
                txtUName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(userPwd))
            {
                MsgBoxHelper.MsgErrorShow("密码不能为空！");
                txtUPwd.Focus();
                return;
            }
            Action act = () =>
            {
                //加密
                string enPwd = MD5Encrypt.Encrypt(userPwd);

                List<ViewUserRoleModel> urList = RequestStar.Login(userName, enPwd);//登录
                                                                                    //判断结果
                if (urList == null || urList.Count == 0)
                {
                    MsgBoxHelper.MsgErrorShow("账号或密码输入有误，请检查！");
                    return;
                }
                else
                {
                    //转到主页面
                    if (!FormUtility.CheckOpenForm("FrmMain"))
                    {
                        FrmMain fMain = new FrmMain();
                        //登录页面显示处理---隐藏，不能关闭
                        fMain.Tag = new LoginModel()
                        {
                            URList = urList,
                            LoginForm = this
                        };
                        fMain.Show();
                    }
                    else
                    {
                        //更换登录者时发生（暂留，后面实现）
                        //FormUtility.ShowOpenForm("FrmMain");
                        foreach (Form frm in Application.OpenForms)
                        {
                            if (frm.Name == "FrmMain")
                            {
                                frm.Tag = new LoginModel()
                                {
                                    URList = urList,
                                    LoginForm = this
                                };
                                frm.Show();
                                break;
                            }
                        }
                    }
                    this.Hide();
                }
            };
            act.TryCatch("登录系统出现异常");
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUName.Clear();
            txtUPwd.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
            Environment.Exit(0);
        }
    }
}
