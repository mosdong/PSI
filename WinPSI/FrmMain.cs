using PSI.Models.DModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Request;

namespace WinPSI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }   
        List<ViewUserRoleModel> urList = null;
        string uName = "";
        bool isAdmin = false;
        FrmLogin fLogin = null;
        int IsFirst = 0;//是否是第一次加载页面
        bool hasOpened = false;//开账状态
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                IsFirst = 1;
                //获取开账状态(暂不处理) 默认账套，编号为1

                if (this.Tag != null)
                {
                    InitMainInfo();//初始化

                }
            };
            act.TryCatch("主页面初始化出现异常");
        }

        /// <summary>
        /// 初始化页面
        /// </summary>
        private void InitMainInfo()
        {
            LoginModel loginModel = this.Tag as LoginModel;
            if (loginModel != null)
            {
                urList = loginModel.URList;
                uName = urList[0].UserName;
                fLogin = loginModel.LoginForm;
                CheckIsAdmin();
                //创建菜单项和工具菜单项，并添加到菜单控件和工具栏里?
                AddMenusAndToolMenus();
                lblUName.Text = uName;
                lblLoginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        /// <summary>
        /// 加载菜单栏和工具栏
        /// </summary>
        private void AddMenusAndToolMenus()
        {
            List<MenuInfoModel> menuList = new List<MenuInfoModel>();
            List<ToolMenuInfoModel> toolMenuList = new List<ToolMenuInfoModel>();
            hasOpened = RequestStar.GetOpenState(1);
            if (isAdmin)//超级管理员
            {
                //获取所有的菜单和工具栏菜单?
                //1.获取菜单数据
                menuList = RequestStar.GetMenuList(new List<int>());
                //2.获取工具菜单项数据
                toolMenuList = RequestStar.GetToolMenuList(new List<int>());
            }
            else
            {
                //加载登录者拥有的菜单和工具栏菜单?
                List<int> roleIds = urList.Select(ur => ur.RoleId).ToList();
                //1.获取菜单数据
                menuList = RequestStar.GetMenuList(roleIds);
                //2.获取工具菜单项数据
                toolMenuList = RequestStar.GetToolMenuList(roleIds);
            }
            PSIMenus.Items.Clear();
            PSITools.Items.Clear();
            //添加菜单项
            AddMenuItem(menuList, null, 0);
            //添加工具菜单项
            AddToolMenuItem(toolMenuList);
        }

        /// <summary>
        /// 添加工具菜单项
        /// </summary>
        /// <param name="toolList"></param>
        private void AddToolMenuItem(List<ToolMenuInfoModel> toolList)
        {
            //1.统计分组
            List<int> goupIds = new List<int>();
            foreach (var ti in toolList)
            {
                if (!goupIds.Contains(ti.TGroupId))
                    goupIds.Add(ti.TGroupId);
            }
            //2.工具菜单项的添加
            foreach (var groupId in goupIds)
            {
                var gTools = toolList.Where(t => t.TGroupId == groupId);
                if (gTools.ToList().Count > 0)
                {
                    foreach (var tmi in gTools)
                    {
                        ToolStripButton tsbtn = new ToolStripButton();
                        tsbtn.Text = tmi.TMenuName;
                        tsbtn.Name = tmi.TMenuId.ToString();
                        //图片
                        if (!string.IsNullOrEmpty(tmi.TMPic))
                            tsbtn.Image = Image.FromFile(Application.StartupPath + "/" + tmi.TMPic);
                        //图片与文本显示方式
                        tsbtn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                        //文本与图片的显示位置
                        tsbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                        tsbtn.Tag = tmi;
                        tsbtn.Click += Tsbtn_Click;//单击事件注册
                        PSITools.Items.Add(tsbtn);
                    }
                    ToolStripSeparator sp = new ToolStripSeparator();
                    PSITools.Items.Add(sp);
                }
            }
        }

        /// <summary>
        /// 工具栏菜单项响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsbtn_Click(object sender, EventArgs e)
        {
            ToolStripButton tsbtn = sender as ToolStripButton;
            if (tsbtn.Tag != null)
            {
                ToolMenuInfoModel tmInfo = tsbtn.Tag as ToolMenuInfoModel;
                string mUrl = tmInfo.TMUrl;
                if (!string.IsNullOrEmpty(mUrl))
                    CreateForm(mUrl, tmInfo.IsTop);
                else
                {
                    //特殊响应处理
                    //退出系统操作
                    if (tmInfo.TMDesp == ToolMenuDesp.ExitSystem.ToString())
                    {
                        Application.Exit();
                    }
                    else if (tmInfo.TMDesp == ToolMenuDesp.ChangeActor.ToString())
                    {
                        //更换操作员
                        this.Hide();
                        fLogin.Show();//不能showDialog()
                        IsFirst = 2;
                    }
                    else if (tmInfo.TMDesp == ToolMenuDesp.RefreshMenu.ToString())
                    {
                        //刷新菜单(菜单栏和工具栏)
                        AddMenusAndToolMenus();
                    }
                }
            }
        }

        /// <summary>
        /// 实例化窗体页面
        /// </summary>
        /// <param name="url"></param>
        /// <param name="isTop"></param>
        private void CreateForm(string url, int isTop)
        {
            //程序集的名称
            string assName = this.GetType().Assembly.GetName().Name;
            string frmName = url.Substring(url.LastIndexOf('.') + 1);
            if (!FormUtility.CheckOpenForm(frmName))
            {
                ObjectHandle t = Activator.CreateInstance(assName, assName + "." + url);
                Form f = (Form)t.Unwrap();
                if (f.Name.Contains(MenuDesp.ModifyPwd.ToString()))//修改密码页面传值
                {
                    f.Tag = new FMPwdModel()
                    {
                        UName = uName,
                        FLogin = this.fLogin,
                        FMain = this
                    };
                }
                else
                    f.Tag = uName;
                if (isTop == 0)
                {
                    //内嵌到选项卡里
                    tcPages.AddTabFormPage(f);
                }
                else
                {
                    //顶级显示
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.WindowState = FormWindowState.Normal;
                    f.ShowDialog();
                }
            }

        }

        /// <summary>
        ///递归添加菜单项
        /// </summary>
        /// <param name="mList"></param>
        /// <param name="pMenu"></param>
        /// <param name="pId"></param>
        private void AddMenuItem(List<MenuInfoModel> mList, ToolStripMenuItem pMenu, int pId)
        {
            //获取所有子菜单列表
            var childList = mList.Where(m => m.ParentId == pId);
            foreach (var child in childList)
            {
                if (child.MDesp == MenuDesp.OpenSys.ToString() && hasOpened)
                {
                    continue;
                }
                if (child.MDesp == MenuDesp.UnOpenSys.ToString() && !hasOpened)
                {
                    continue;
                }
                ToolStripMenuItem mi = new ToolStripMenuItem();
                mi.Name = child.MId.ToString();
                mi.Text = child.MName;
                if (!string.IsNullOrEmpty(child.MKey))
                {
                    //alt+K
                    string sKey = child.MKey.ToString().Trim();
                    //设置Alt快捷键  Ctrl+P   Shift+C
                    if (sKey.Length > 1 && sKey.Split('+')[0].ToLower() == "alt" && child.ParentId == 0)
                    {
                        mi.Text += $"(&{sKey.Split('+')[1]})";
                    }
                    mi.ShortcutKeys = SetShortKeys(sKey);
                }
                //菜单项关联页面
                if (!string.IsNullOrEmpty(child.MUrl))
                {
                    mi.Tag = child;
                }
                //菜单项响应事件注册（先没有子菜单的）有关联和没有关联页面
                if (mList.Where(m => m.ParentId == child.MId).ToList().Count == 0)
                {
                    mi.Click += Mi_Click;
                }
                if (pMenu != null)
                    pMenu.DropDownItems.Add(mi);
                else
                    PSIMenus.Items.Add(mi);
                AddMenuItem(mList, mi, child.MId);//为当前菜单项添加它的子菜单
            }
        }

        /// 获取快捷键
        /// </summary>
        /// <param name="mkey"></param>
        /// <returns></returns>
        private Keys SetShortKeys(string mkey)
        {
            Keys reKey = default(Keys);
            string[] arrKeys = mkey.Split('+');
            if (arrKeys.Length == 2)
            {
                Keys k;
                Enum.TryParse<Keys>(arrKeys[1], out k);
                if (arrKeys[0].ToLower() == "ctrl")
                {
                    reKey = Keys.Control | k;
                }
                else if (arrKeys[0].ToLower() == "alt")
                {
                    reKey = Keys.Alt | k;
                }
                else if (arrKeys[0].ToLower() == "shift")
                {
                    reKey = Keys.Shift | k;
                }
            }
            else if (arrKeys.Length == 3)
            {
                Keys k;
                Enum.TryParse<Keys>(arrKeys[2], out k);
                string start = arrKeys[0].ToLower() + "+" + arrKeys[1].ToLower();
                switch (start)
                {
                    case "shift+alt":
                        reKey = Keys.Shift | Keys.Alt | k;
                        break;
                    case "ctrl+alt":
                        reKey = Keys.Control | Keys.Alt | k;
                        break;
                    case "ctrl+shift":
                        reKey = Keys.Control | Keys.Shift | k;
                        break;
                }
            }
            else if (arrKeys.Length == 4)
            {
                Keys k;
                Enum.TryParse<Keys>(arrKeys[3], out k);
                reKey = Keys.Control | Keys.Shift | Keys.Alt | k;
            }
            Keys key = (Keys)reKey;
            return reKey;

        }

        /// <summary>
        /// 菜单项的响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mi_Click(object sender, EventArgs e)
        {
            // 获取单击的菜单项
            ToolStripMenuItem mi = sender as ToolStripMenuItem;
            if (mi.Tag != null)
            {
                MenuInfoModel mInfo = mi.Tag as MenuInfoModel;
                if (!string.IsNullOrEmpty(mInfo.MUrl))
                    CreateForm(mInfo.MUrl, mInfo.IsTop);
                else
                {

                }
            }
        }




        /// <summary>
        /// 判断是否具有超级管理员权限
        /// </summary>
        private void CheckIsAdmin()
        {
            isAdmin = false;
            foreach (var ur in urList)
            {
                if (ur.IsAdmin == 1)
                {
                    isAdmin = true;
                    break;
                }
            }
        }

        /// <summary>
        /// 特殊工具菜单项说明
        /// </summary>
        private enum ToolMenuDesp
        {
            ExitSystem = 1,
            ChangeActor = 2,
            RefreshMenu = 3
        }

        /// <summary>
        /// 特殊菜单项说明
        /// </summary>
        private enum MenuDesp
        {
            ExitSystem = 1,
            ModifyPwd = 2,
            OpenSys = 3,
            UnOpenSys = 4
        }

        /// <summary>
        /// 主页面关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //太不友好？---选择机会---确认是否关闭   是--关闭； 否---不关闭
            //会出现两弹框？？
            if (MsgBoxHelper.MsgBoxConfirm("关闭系统", "您确定要退出系统？") == DialogResult.Yes)
            {
                Application.ExitThread();//退出消息循环
            }
            else
                e.Cancel = true;
        }

        //Visible属性改变时触发
        private void FrmMain_VisibleChanged(object sender, EventArgs e)
        {
            if (IsFirst == 2)
            {
                InitMainInfo();
                IsFirst = 1;
            }

        }
        /// <summary>
        /// 关闭选项卡页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //获取选择的选项卡
            TabPage selPage = tcPages.SelectedTab;
            if (selPage != null)
            {
                tcPages.TabPages.Remove(selPage);//移除
                FormUtility.CloseOpenForm(selPage.Name);//关闭窗体
            }
        }

        private void tcPages_SizeChanged(object sender, EventArgs e)
        {
            if (tcPages.TabPages.Count > 0)
            {
                Size size = tcPages.SelectedTab.Size;
                foreach (TabPage page in tcPages.TabPages)
                {
                    foreach (Control c in page.Controls)
                    {
                        if (c is Form)
                        {
                            Form frm = c as Form;
                            frm.WindowState = FormWindowState.Normal;
                            frm.SuspendLayout();
                            frm.Size = size;
                            frm.ResumeLayout(true);
                            frm.WindowState = FormWindowState.Maximized;
                        }
                    }
                }
            }
        }


    }
}
