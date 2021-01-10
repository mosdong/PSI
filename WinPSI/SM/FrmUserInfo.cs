using PSI.Common.Encrypt;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Request;

namespace WinPSI.SM
{
    public partial class FrmUserInfo : Form
    {
        public FrmUserInfo()
        {
            InitializeComponent();
        }
        private FInfoModel fModel = null;
        int userId = 0;//用户编号    
        List<int> roleIds = new List<int>();
        string oldUserName = "";//原来的用户名
        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                fModel = this.Tag as FInfoModel;
                //加载角色列表
                InitRoleList();
                switch (fModel.ActType)
                {
                    case 1://新增
                        this.Text += "--新增";
                        txtUName.Clear();
                        txtUPwd.Clear();
                        rbEnabed.Checked = true;
                        btnSubmit.Text = "添加";
                        break;
                    case 2://修改
                        this.Text += "--修改";
                        btnSubmit.Text = "修改";
                        userId = fModel.FId;
                        //加载用户信息
                        InitUserInfo(userId);
                        break;
                }
            }
        }

        /// <summary>
        /// 加载用户信息
        /// </summary>
        /// <param name="userId"></param>
        private void InitUserInfo(int userId)
        {
            UserInfoModel user = RequestStar.GetUserInfo(userId);
            if (user != null)
            {
                txtUName.Text = user.UserName;
                oldUserName = user.UserName;
                if (user.UserState == 1)
                    rbEnabed.Checked = true;
                else
                    rbStop.Checked = true;
                //已有角色的选项勾选
                var userRoles = RequestStar.GetUserRoleList(userId);
                if (userRoles.Count > 0)
                {
                    foreach (var ur in userRoles)
                    {
                        for (int i = 0; i < chkList.Items.Count; i++)
                        {
                            RoleInfoModel role = chkList.Items[i] as RoleInfoModel;
                            if (role.RoleId == ur.RoleId)
                            {
                                chkList.SetItemChecked(i, true);
                                roleIds.Add(role.RoleId);
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 加载角色列表
        /// </summary>
        private void InitRoleList()
        {
            List<RoleInfoModel> roleList = RequestStar.GetAllRoles();
            chkList.DataSource = roleList;
            chkList.DisplayMember = "RoleName";
            chkList.ValueMember = "RoleId";
        }

        /// <summary>
        /// 提交用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                //接收页面信息
                string uName = txtUName.Text.Trim();
                string uPwd = txtUPwd.Text.Trim();
                int userState = rbEnabed.Checked ? 1 : 0;
                //判断账号是否为空
                if (string.IsNullOrEmpty(uName))
                {
                    MsgBoxHelper.MsgErrorShow("账号不能为空！");
                    txtUName.Focus();
                    return;
                }
                else if (userId == 0 || (!string.IsNullOrEmpty(oldUserName) && oldUserName != uName))
                {
                    //判断用户名是否已存在---存在---错误提示
                }
                if (userId == 0 && string.IsNullOrEmpty(uPwd))
                {

                    MsgBoxHelper.MsgErrorShow("密码不能为空！");
                    txtUPwd.Focus();
                    return;
                }
                string enPwd = "";
                if (uPwd != "")
                    enPwd = MD5Encrypt.Encrypt(uPwd);
                //封装信息实体
                UserInfoModel userInfo = new UserInfoModel()
                {
                    UserName = uName,
                    UserPwd = enPwd,
                    Creator = fModel.UName,
                    UserState = userState
                };
                if (userId > 0)
                {
                    userInfo.UserId = userId;
                }
                //角色列表获取
                List<UserRoleInfoModel> urList = new List<UserRoleInfoModel>();
                for (int i = 0; i < chkList.Items.Count; i++)
                {
                    if (chkList.GetItemCheckState(i) == CheckState.Checked)
                    {
                        RoleInfoModel role = chkList.Items[i] as RoleInfoModel;
                        UserRoleInfoModel ur = new UserRoleInfoModel()
                        {
                            RoleId = role.RoleId,
                            UserId = userId,
                            Creator = fModel.UName
                        };
                        urList.Add(ur);
                    }
                }

                //提交操作
                if (fModel.ActType == 1)
                {
                    //提交新增
                    bool blAdd = RequestStar.AddUserInfo(userInfo, urList);
                    if (blAdd)
                    {
                        MsgBoxHelper.MsgBoxShow("添加用户", $"用户:{uName} 添加成功！");
                        fModel.ReLoad?.Invoke();
                    }
                    else
                    {
                        MsgBoxHelper.MsgErrorShow($"用户:{uName} 添加失败！");
                        return;
                    }
                }
                else
                {
                    //筛选角色列表设置
                    List<UserRoleInfoModel> urListNew = new List<UserRoleInfoModel>();
                    foreach (var ur in urList)
                    {
                        bool ebl = false;
                        foreach (int rId in roleIds)
                        {
                            if (ur.RoleId == rId)
                            {
                                ebl = true;
                                break;
                            }
                        }
                        if (!ebl)
                        {
                            urListNew.Add(ur);
                        }
                    }
                    if (urList.Count == roleIds.Count && urListNew.Count == 0)
                    {
                        urList.RemoveRange(0, urList.Count);
                    }

                    //提交修改
                    bool blEdit = RequestStar.UpdateUserInfo(userInfo, urList, urListNew);
                    if (blEdit)
                    {
                        MsgBoxHelper.MsgBoxShow("修改用户", $"用户:{uName} 修改成功！");
                        fModel.ReLoad?.Invoke();
                    }
                    else
                    {
                        MsgBoxHelper.MsgErrorShow($"用户:{uName} 修改失败！");
                        return;
                    }
                }
            };
            act.TryCatch("提交用户信息异常！");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
