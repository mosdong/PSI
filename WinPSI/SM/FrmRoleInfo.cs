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
using WinPSI.FModels;

namespace WinPSI.SM
{
    public partial class FrmRoleInfo : Form
    {
        public FrmRoleInfo()
        {
            InitializeComponent();
        }
        FInfoModel fModel = null;
        private RoleBLL roleBLL = new RoleBLL();
        private string oldName = "";//要修改的角色名称
        private string btnText = "";
        private void FrmRoleInfo_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                {
                    fModel = this.Tag as FInfoModel;
                    if (fModel != null)
                    {
                        InitRoleInfo();
                    }
                }
            };
            act.TryCatch("角色信息页面加载异常！");
           
        }

        private void InitRoleInfo()
        {
            string addText = "——";
          
            if (fModel.FId == 0)
            {
                txtRName.Clear();
                txtRemark.Clear();
                btnText = "新增";
            }
            else
            {
                RoleInfoModel roleInfo = roleBLL.GetRole(fModel.FId);
                if (roleInfo != null)
                {
                    txtRName.Text = roleInfo.RoleName;
                    txtRemark.Text = roleInfo.Remark;
                    oldName = roleInfo.RoleName;
                }
                btnText = "修改";
            }
            addText += btnText;
            this.Text += addText;
            btnSubmit.Text = btnText;
        }

        /// <summary>
        /// 提交响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //接收页面信息输入
            string roleName = txtRName.Text.Trim();
            string remark = txtRemark.Text.Trim();
            //判空处理 ---角色名称
             if(string.IsNullOrEmpty(roleName))
            {
                MsgBoxHelper.MsgErrorShow("角色名称不能为空！");
                txtRName.Focus();
                return;
            }
            //角色名称存在性---add 不能是已存在  update 没有修改名称（不用判断存在性）  名称已修改的情况（要判断）
            if(fModel.FId==0||(!string.IsNullOrEmpty(oldName)&&oldName !=roleName))
            {
                if(roleBLL.ExistRoleName(roleName))
                {
                    MsgBoxHelper.MsgErrorShow("角色名称已经存在！");
                    txtRName.Focus();
                    return;
                }
            }
            //封装
            RoleInfoModel roleInfo = new RoleInfoModel()
            {
                RoleName = roleName,
                Remark = remark,
                Creator=fModel.UName
            };
            //调用方法（add）  （update）
            bool bl = false;
            if(fModel.FId==0)
            {
                bl = roleBLL.AddRoleInfo(roleInfo);
            }
            else if(fModel.FId >0)
            {
                roleInfo.RoleId = fModel.FId;
                bl = roleBLL.UpdateRoleInfo(roleInfo);
            }
            //判断结果给出提示
            if(bl)
            {
                MsgBoxHelper.MsgBoxShow($"{btnText}角色", $"角色：{roleName} 信息{btnText}成功！");
                //刷新列表页面数据
                fModel.ReLoad?.Invoke();
            }
            else
            {
                MsgBoxHelper.MsgErrorShow( $"角色：{roleName} 信息{btnText}失败！");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
