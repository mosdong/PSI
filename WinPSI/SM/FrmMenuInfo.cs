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
    public partial class FrmMenuInfo : Form
    {
        public FrmMenuInfo()
        {
            InitializeComponent();
        } 
        FInfoModel fModel = null;
        int menuId = 0;//修改的菜单编号
        string uName = "";
        string oldName = "";//修改前的菜单名称
        private void FrmMenuInfo_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                {
                    fModel = this.Tag as FInfoModel;
                    if (fModel != null)
                    {
                        uName = fModel.UName;
                        menuId = fModel.FId;
                        LoadCboParents();//加载父菜单下拉框
                        LoadCboForms();//加载关联页面下拉框
                        string title = "";
                        switch (fModel.ActType)
                        {
                            case 1://新增
                                title = "新增";
                                ClearInfo();
                                break;
                            case 2://修改
                                title = "修改";
                                InitMenuInfo(menuId);//加载菜单信息
                                tsbtnClear.Enabled = false;
                                break;
                            case 3://添加子菜单
                                title = "添加子菜单";
                                ClearInfo();
                                cboParents.SelectedValue = menuId;
                                cboParents.Enabled = false;
                                break;
                            case 4://详情页面
                                title = "详情";
                                InitMenuInfo(menuId);//加载菜单信息
                                tsbtnSave.Enabled = false;
                                tsbtnClear.Enabled = false;
                                break;
                        }
                        this.Text += "----" + title;
                    }
                }
            };
            act.TryCatch("菜单信息页面加载异常!");
        }

        /// <summary>
        /// 清空
        /// </summary>
        private void ClearInfo()
        {
            txtMName.Clear();
            txtMKey.Clear();
            txtOrder.Clear();
            txtMDesp.Clear();
            chkTop.Checked = false;
            cboParents.SelectedIndex = 0;
            cboUrls.SelectedIndex = 0;
        }

        /// <summary>
        /// 加载菜单信息
        /// </summary>
        /// <param name="menuId"></param>
        private void InitMenuInfo(int menuId)
        {
            MenuInfoModel menuInfo = RequestStar.GetMenuInfo(menuId);
            if (menuInfo != null)
            {
                txtMName.Text = menuInfo.MName;
                oldName = menuInfo.MName;
                txtMKey.Text = menuInfo.MKey;
                txtMDesp.Text = menuInfo.MDesp;
                txtOrder.Text = menuInfo.MOrder.ToString();
                if (menuInfo.ParentId != null)
                    cboParents.SelectedValue = menuInfo.ParentId;
                if (!string.IsNullOrEmpty(menuInfo.MUrl))
                    cboUrls.SelectedValue = menuInfo.MUrl;
                if (menuInfo.IsTop == 1)
                    chkTop.Checked = true;
                else
                    chkTop.Checked = false;
            }
        }

        /// <summary>
        /// 加载关联页面下拉框
        /// </summary>
        private void LoadCboForms()
        {
            //程序集名称
            string assName = this.GetType().Assembly.GetName().Name;
            Type[] types = this.GetType().Assembly.GetTypes();
            //筛选出所有窗体类
            var frmTypes = types.Where(t => t.BaseType.Name == "Form");
            Dictionary<string, string> listForms = new Dictionary<string, string>();
            listForms.Add("", "请选择页面");
            foreach (Type type in frmTypes)
            {
                Form f = (Form)Activator.CreateInstance(type);
                listForms.Add(type.FullName.Remove(0, assName.Length + 1), f.Text);
                f.Dispose();
            }
            //绑定
            BindingSource bs = new BindingSource();
            bs.DataSource = listForms;
            cboUrls.Items.Clear();
            cboUrls.DataSource = bs;
            cboUrls.DisplayMember = "Value";
            cboUrls.ValueMember = "Key";
            cboUrls.SelectedValue = "";
        }

        /// <summary>
        /// 加载父菜单下拉框
        /// </summary>
        private void LoadCboParents()
        {
            cboParents.Items.Clear();
            List<MenuInfoModel> menuList = RequestStar.GetAllMenus();
            menuList.Insert(0, new MenuInfoModel()
            {
                MId = 0,
                MName = "请选择"
            });
            cboParents.DataSource = menuList;
            cboParents.DisplayMember = "MName";
            cboParents.ValueMember = "MId";
        }

        private void tsbtnClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            //1.接收页面输入
            string mName = txtMName.Text.Trim();
            int parentId = cboParents.SelectedValue.GetInt();
            string parentName = cboParents.Text.Trim();
            if (parentId == 0)
                parentName = null;
            string mUrl = cboUrls.SelectedValue.ToString();
            if (string.IsNullOrEmpty(mUrl))
                mUrl = null;
            string mKey = txtMKey.Text.Trim();
            int mOrder = txtMKey.Text.GetInt();
            string mDesp = txtMDesp.Text.Trim();
            if (string.IsNullOrEmpty(mDesp))
                mDesp = null;
            int isTop = chkTop.Checked ? 1 : 0;
            //2.判断菜单名称不能为空
            if (string.IsNullOrEmpty(mName))
            {
                MsgBoxHelper.MsgErrorShow("菜单名称不能为空！");
                txtMName.Focus();
                return;
            }
            //3.判断菜单名称是否已存在 （oldName=""||(oldName!="" && oleName!=mName)） 
            if (string.IsNullOrEmpty(oldName) || (!string.IsNullOrEmpty(oldName) && oldName != mName))
            {
                //判断名称是否已存在
                if (RequestStar.ExistMenu(mName))
                {
                    MsgBoxHelper.MsgErrorShow("菜单名称已存在！");
                    txtMName.Focus();
                    return;
                }
            }
            //4.信息的封装
            MenuInfoModel menuInfo = new MenuInfoModel()
            {
                MName = mName,
                ParentId = parentId,
                ParentName = parentName,
                MUrl = mUrl,
                MOrder = mOrder,
                MKey = mKey,
                IsTop = isTop,
                MDesp = mDesp,
                Creator = fModel.UName
            };
            //5.执行方法（添加、修改）
            bool bl = false;
            string actMsg = fModel.ActType == 2 ? "修改" : "新增";
            if (fModel.ActType == 1 || fModel.ActType == 3)
            {
                //新增操作
                bl = RequestStar.AddMenuInfo(menuInfo);
            }
            else if (fModel.ActType == 2)
            {
                //修改操作
                menuInfo.MId = menuId;
                bool blUpdate = false;
                if (oldName != mName)
                    blUpdate = true;
                bl = RequestStar.UpdateMenuInfo(menuInfo, blUpdate);
            }
            if (bl)
            {
                MsgBoxHelper.MsgBoxShow($"{actMsg}菜单", $"菜单：{mName} 信息 {actMsg}成功！");
                fModel.ReLoad?.Invoke();//刷新列表数据
            }
            else
            {
                MsgBoxHelper.MsgErrorShow($"菜单：{mName} 信息 {actMsg}失败！");
                return;
            }
        }
    }
}
