using System;
using System.Windows.Forms;

namespace WinPSI.UControls
{
    /// <summary>
    /// 三个单据页面的父窗体
    /// </summary>
    public partial class SheetFormParent : Form
    {
        public SheetFormParent()
        {
            InitializeComponent();
        }
        public event Action ReloadList;//刷新单据列表页的事件
                                       //调用事件方法
        public void ReloadListHandler()
        {
            this.ReloadList?.Invoke();
        }
    }
}
