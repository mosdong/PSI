using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinPSI.UControls
{
        public partial class ucPager : UserControl
        {
                public ucPager()
                {
                        InitializeComponent();
                }

                private int record = 0;
                /// <summary>
                /// 总记录数
                /// </summary>
                public int Record
                {
                        get { return record; }
                        set
                        {
                                record = value;
                                InitPageInfo();
                        }
                }

                private int startRecord = 1;
                public int StartRecord
                {
                        get { return (CurrentPage - 1) * PageSize + 1; }
                        set { startRecord = value; }
                }

                private int pageSize =5;

                /// <summary>
                /// 每页条数
                /// </summary>
                public int PageSize
                {
                        get { return pageSize; }
                        set { pageSize = value; }
                }

                private int currentPage = 1;

                /// <summary>
                /// 当前页
                /// </summary>
                public int CurrentPage
                {
                        get { return currentPage; }
                        set { currentPage = value; }
                }

                public int pageNum = 0;

                /// <summary>
                /// 总页码
                /// </summary>
                public int PageNum
                {
                        get
                        {
                                if (Record == 0)
                                {
                                        pageNum = 0;
                                }
                                else
                                {
                                        if (Record % PageSize > 0)
                                        {
                                                pageNum = Record / PageSize + 1;
                                        }
                                        else
                                        {
                                                pageNum = Record / PageSize;
                                        }
                                }
                                return pageNum;
                        }

                }

                public void InitPageInfo()
                {
                        if (Record == 0 || (Record > 0 && CurrentPage > pageNum))
                        {
                                CurrentPage = 1;
                        }
                        if(CurrentPage==1)
                        {
                                btnFirst.Enabled = false;
                                btnPre.Enabled = false;
                                if(CurrentPage==PageNum)
                                {
                                        btnNext.Enabled = false;
                                        btnLast.Enabled = false;
                                        btnGo.Enabled = false;
                                }
                                else 
                                {
                                        btnNext.Enabled = true;
                                        btnLast.Enabled = true;
                                        btnGo.Enabled = true;
                                }
                        }
                        else if(CurrentPage>1 )
                        {
                                btnFirst.Enabled = true;
                                btnPre.Enabled = true;
                                if(CurrentPage < PageNum)
                                {
                                        btnNext.Enabled = true;
                                        btnLast.Enabled = true;
                                        btnGo.Enabled = true;
                                }
                                else
                                {
                                        btnNext.Enabled = false;
                                        btnLast.Enabled = false;
                                        btnGo.Enabled = true;
                                }
                        }
                      
                        lblPageInfo.Text = string.Format("共 {0} 条记录  共 {1} 页  当前第 {2} 页", Record, PageNum, CurrentPage);
                        txtGoPage.Text = CurrentPage.ToString();

                }

                //定义委托
                public delegate void BindHandle(object sender, EventArgs e);

                /// <summary>
                /// 绑定数据源事件
                /// </summary>
                public event BindHandle BindSource;

                private void btnFirst_Click(object sender, EventArgs e)
                {
                        if (Record > 0)
                        {
                               if(CurrentPage>1)
                                {
                                        CurrentPage = 1;
                                        if (BindSource != null)
                                        {
                                                BindSource(sender, e);
                                                InitPageInfo();
                                        }
                                }
                        }

                }

                private void btnPre_Click(object sender, EventArgs e)
                {
                        if (Record > 0)
                        {
                               if(CurrentPage>1)
                                {
                                        CurrentPage = CurrentPage - 1;
                                        if (BindSource != null)
                                        {
                                                BindSource(sender, e);
                                                InitPageInfo();
                                        }
                                }
                        }
                }

                private void btnNext_Click(object sender, EventArgs e)
                {
                        if (Record > 0)
                        {
                               if(CurrentPage<PageNum)
                                {
                                        CurrentPage = CurrentPage + 1;
                                        if (BindSource != null)
                                        {
                                                BindSource(sender, e);
                                                InitPageInfo();
                                        }
                                }
                        }
                }

                private void btnLast_Click(object sender, EventArgs e)
                {
                        if (Record > 0)
                        {
                               if(CurrentPage<PageNum)
                                {
                                        CurrentPage = PageNum;
                                        if (BindSource != null)
                                        {
                                                BindSource(sender, e);
                                                InitPageInfo();
                                        }
                                }
                        }
                }

                private void btnGo_Click(object sender, EventArgs e)
                {
                        if (Record > 0)
                        {
                                if (!string.IsNullOrEmpty(txtGoPage.Text) && !Regex.IsMatch(txtGoPage.Text, @"^[\d]*$"))
                                {
                                        MessageBox.Show("请正确填写页码！");
                                        return;
                                }
                                int page = Convert.ToInt32(txtGoPage.Text);
                                if (page == 0)
                                {
                                        page = 1;
                                }
                                if (page > PageNum)
                                {
                                        page = PageNum;
                                }

                                CurrentPage = page;
                                if (BindSource != null)
                                {
                                        BindSource(sender, e);
                                        InitPageInfo();
                                }
                        }
                }

                private void ucPager_Load(object sender, EventArgs e)
                {
                        if (BindSource != null)
                        {
                                BindSource(sender, e);
                                InitPageInfo();
                        }
                }
        }
}
