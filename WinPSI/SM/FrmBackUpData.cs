using System;
using System.Windows.Forms;
using WinPSI.Request;

namespace WinPSI.SM
{
    public partial class FrmBackUpData : Form
    {
        public FrmBackUpData()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选择路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.SelectedPath;
            }
        }

        private void FrmBackUpData_Load(object sender, EventArgs e)
        {
            txtPath.Clear();
        }

        /// <summary>
        /// 备份数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text.Trim();
            if (string.IsNullOrEmpty(path))
            {
                MsgBoxHelper.MsgErrorShow("请选择备份文件存放的位置!");
                return;
            }
            if (MsgBoxHelper.MsgBoxConfirm("备份数据", "您确定要备份数据库吗?") == DialogResult.Yes)
            { 
                bool bl = RequestStar.BackupData(path);
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow("备份数据", "系统数据备份完毕!");
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow("数据备份失败!");
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }
    }
}
