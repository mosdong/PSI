using PSI.Common;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Request;

namespace WinPSI.SM
{
    public partial class FrmRight : Form
    {
        public FrmRight()
        {
            InitializeComponent();
        }
        private string uName = "";
        int roleId = 0;
        bool blFlag = false;   
        private bool isAdmin = false;
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRight_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                LoadCboRoles();//加载角色下拉框
                //tag  菜单项----loginUserName  
                //角色管理页面  权限分配按钮 roleId=0
                //分配权限操作列  ---RoleId>0 
                if (this.Tag != null)
                {
                    Type tagType = this.Tag.GetType();
                    if (tagType == typeof(string))
                        uName = this.Tag.ToString();
                    else if (tagType == typeof(FRightModel))
                    {
                        FRightModel fModel = this.Tag as FRightModel;
                        uName = fModel.UName;
                        roleId = fModel.RoleId;
                    }
                }
                blFlag = true;
                tcRights.SelectedIndex = 0;//设置默认选择菜单选项卡
                LoadTvMenus();//加载菜单TvMenus
                LoadTvToolMenus();//加载工具菜单TvTMenus
                if (roleId > 0)
                {
                    cboRoles.SelectedValue = roleId;
                    cboRoles.Enabled = false;
                }
                else
                    cboRoles.SelectedIndex = 0;
            };
            act.TryCatch("加载权限页面信息异常！");
        }

        /// <summary>
        /// 加载工具菜单数据
        /// </summary>
        private void LoadTvToolMenus()
        {
            List<ToolMenuInfoModel> list = RequestStar.GetToolMenuList();
            tvTMenus.Nodes.Clear();
            tvTMenus.CheckBoxes = true;
            TreeNode root = FormUtility.CreateNode("0", "系统工具栏菜单");
            tvTMenus.Nodes.Add(root);
            foreach (ToolMenuInfoModel tmi in list)
            {
                TreeNode tn = FormUtility.CreateNode(tmi.TMenuId.ToString(), tmi.TMenuName);
                root.Nodes.Add(tn);
            }
            tvTMenus.ExpandAll();
        }

        /// <summary>
        /// 加载菜单数据
        /// </summary>
        private void LoadTvMenus()
        {
            List<MenuInfoModel> list = RequestStar.GetTvMenus();
            tvMenus.Nodes.Clear();
            tvMenus.CheckBoxes = true;
            TreeNode root = FormUtility.CreateNode("0", "系统菜单");
            tvMenus.Nodes.Add(root);
            //添加菜单节点
            CreateMenuNode(list, root, 0);
            tvMenus.ExpandAll();
        }

        /// <summary>
        /// 递归创建菜单树节点
        /// </summary>
        /// <param name="menuList"></param>
        /// <param name="pNode"></param>
        /// <param name="parentId"></param>
        private void CreateMenuNode(List<MenuInfoModel> menuList, TreeNode pNode, int parentId)
        {
            var childList = menuList.Where(m => m.ParentId == parentId);
            foreach (var menu in childList)
            {
                TreeNode tn = FormUtility.CreateNode(menu.MId.ToString(), menu.MName);
                pNode.Nodes.Add(tn);
                CreateMenuNode(menuList, tn, menu.MId);
            }
        }

        private void LoadCboRoles()
        {
            List<RoleInfoModel> list = RequestStar.GetAllRoles();
            list.Insert(0, new RoleInfoModel()
            {
                RoleId = 0,
                RoleName = "请选择"
            });
            cboRoles.DataSource = list;
            cboRoles.DisplayMember = "RoleName";
            cboRoles.ValueMember = "RoleId";
            cboRoles.SelectedIndex = 0;
        }

        /// <summary>
        /// 默认情况下，绑定数据源后，立即触发这个事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blFlag)
            {
                int rId = cboRoles.SelectedValue.GetInt();
                CheckIsAdmin(rId);
                if (isAdmin)
                {
                    //把所有节点选中，不能进行权限提交设置
                    tvMenus.Nodes[0].Checked = true;
                    tvTMenus.Nodes[0].Checked = true;
                    CheckAllNodes(tvMenus.Nodes[0]);
                    CheckAllNodes(tvTMenus.Nodes[0]);
                    btnSubmit.Enabled = false;
                }
                else
                {
                    btnSubmit.Enabled = true;
                    tvMenus.Nodes[0].Checked = false;
                    tvTMenus.Nodes[0].Checked = false;
                    CheckAllNodes(tvMenus.Nodes[0]);
                    CheckAllNodes(tvTMenus.Nodes[0]);
                    if (rId > 0)
                    {
                        //加载权限数据
                        //获取数据   角色菜单    角色工具栏
                        List<int> menuIds = RequestStar.GetRoleMenuIds(rId);
                        List<int> tMenuIds = RequestStar.GetRoleTMenuIds(rId);
                        //加载 处理节点勾选
                        if (menuIds.Count > 0)
                            LoadCheckedNodes(menuIds, tvMenus.Nodes[0]);
                        if (tMenuIds.Count > 0)
                            LoadCheckedNodes(tMenuIds, tvTMenus.Nodes[0]);
                    }
                }
            }
        }


        //全选和全不选
        private void CheckAllNodes(TreeNode pNode)
        {
            foreach (TreeNode child in pNode.Nodes)
            {
                child.Checked = pNode.Checked;
                CheckAllNodes(child);
            }
        }

        /// <summary>
        /// 加载已设置权限数据
        /// </summary>
        /// <param name="Ids"></param>
        /// <param name="pNode"></param>
        private void LoadCheckedNodes(List<int> Ids, TreeNode pNode)
        {
            foreach (TreeNode tn in pNode.Nodes)
            {
                if (Ids.Contains(tn.Name.GetInt()))
                {
                    tn.Checked = true;
                }
                LoadCheckedNodes(Ids, tn);
            }
        }



        /// <summary>
        /// 检查一个角色是否是超级管理员角色
        /// </summary>
        /// <param name="rId"></param>
        private void CheckIsAdmin(int rId)
        {
            isAdmin = false;
            RoleInfoModel roleInfo = RequestStar.GetRole(rId);
            if (roleInfo != null)
            {
                if (roleInfo.IsAdmin == 1)
                    isAdmin = true;
            }
        }

        /// <summary>
        ///勾选状态更改后发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvMenus_AfterCheck(object sender, TreeViewEventArgs e)
        {
            //e.Node 当前操作节点

            if (e.Action == TreeViewAction.ByKeyboard || e.Action == TreeViewAction.ByMouse)
            {
                //设置当前节点的子节点的勾选处理
                SetChildNodesCheckState(e.Node);
                //设置当前节点的父节点的勾选处理
                SetParentNodesCheckState(e.Node);
            }

        }

        //递归处理 父节点勾选
        private void SetParentNodesCheckState(TreeNode node)
        {
            TreeNode pNode = node.Parent;//父节点
            if (pNode != null)
            {
                bool bl = false;
                foreach (TreeNode tn in pNode.Nodes)
                {
                    if (tn.Checked)
                    {
                        bl = true;
                        break;
                    }
                }
                pNode.Checked = bl;
                SetParentNodesCheckState(pNode);
            }
        }

        //递归处理 子节点勾选
        private void SetChildNodesCheckState(TreeNode node)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = node.Checked;
                SetChildNodesCheckState(child);
            }
        }

        private void tvTMenus_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByKeyboard || e.Action == TreeViewAction.ByMouse)
            {
                //设置当前节点的子节点的勾选处理
                SetChildNodesCheckState(e.Node);
                //设置当前节点的父节点的勾选处理
                SetParentNodesCheckState(e.Node);
            }
        }

        /// <summary>
        /// 提交权限设置数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int rId = cboRoles.SelectedValue.GetInt();
            CheckIsAdmin(rId);
            if (rId == 0)
            {
                MsgBoxHelper.MsgErrorShow("请选择要设置权限的角色！");
                return;
            }
            else
            {
                //1.获取菜单编号，工具栏菜单编号
                List<int> tMenuIds = GetToolMenuIds(rId);
                List<int> menuIds = new List<int>();
                menuIds = GetMenuIds(rId, menuIds, tvMenus.Nodes[0]);
                bool bl = false;//执行结果
                if (menuIds.Count == 0 && tMenuIds.Count == 0)
                {
                    MsgBoxHelper.MsgErrorShow("请设置该角色的菜单和工具栏权限！");
                    return;
                }
                else if (menuIds.Count == 0 && tMenuIds.Count > 0)
                {
                    if (MsgBoxHelper.MsgBoxConfirm("权限设置", "您没有设置系统菜单权限，将会无法使用系统菜单功能！是否继续？") == DialogResult.Yes)
                    {
                        //设置工具栏权限
                        bl = RequestStar.SetRoleRight(rId, null, tMenuIds, uName);
                    }
                }
                else if (menuIds.Count > 0 && tMenuIds.Count == 0)
                {
                    if (MsgBoxHelper.MsgBoxConfirm("权限设置", "您没有设置工具菜单权限，将会无法使用工具栏菜单功能！是否继续？") == DialogResult.Yes)
                    {
                        //设置菜单权限
                        bl = RequestStar.SetRoleRight(rId, menuIds, null, uName);
                    }
                }
                else
                {
                    //设置菜单和工具栏权限
                    bl = RequestStar.SetRoleRight(rId, menuIds, tMenuIds, uName);
                }
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow("权限设置", "权限设置保存成功！");
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow("权限设置保存失败！");
                    return;
                }
            }


        }

        /// <summary>
        /// tvTMenus 获取已勾选的工具栏菜单编号集合
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        private List<int> GetToolMenuIds(int roleId)
        {
            List<int> tMenuIds = new List<int>();
            foreach (TreeNode tn in tvTMenus.Nodes[0].Nodes)
            {
                if (tn.Checked)
                {
                    int tMenuId = tn.Name.GetInt();
                    tMenuIds.Add(tMenuId);
                }
            }
            return tMenuIds;
        }

        /// <summary>
        /// 获取已勾选的菜单编号集合
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="menuIds"></param>
        /// <param name="pNode"></param>
        /// <returns></returns>
        private List<int> GetMenuIds(int roleId, List<int> menuIds, TreeNode pNode)
        {
            foreach (TreeNode tn in pNode.Nodes)
            {
                if (tn.Checked)
                {
                    int menuId = tn.Name.GetInt();
                    if (!menuIds.Contains(menuId))
                        menuIds.Add(menuId);
                }
                GetMenuIds(roleId, menuIds, tn);
            }
            return menuIds;
        }
    }
}
