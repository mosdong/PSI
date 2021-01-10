using PSI.Common;
using PSI.Models.DModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Request;

namespace WinPSI.BM
{
    public partial class FrmStoreList : Form
    { 
        public FrmStoreList()
        {
            InitializeComponent();
        }
        string uName = "";//账号
        private void FrmStoreList_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                {
                    uName = this.Tag.ToString();
                }
                txtKeyWords.Clear();
                LoadTVStoreTypes();//加载仓库类别节点树
                            LoadStoreList();//加载所有仓库信息
                        };
            act.TryCatch("仓库信息加载异常！");
        }

        /// <summary>
        /// 加载所有仓库信息
        /// </summary>
        private void LoadStoreList()
        {
            string keywords = txtKeyWords.Text.Trim();
            int sTypeId = 0;
            if (tvSTypes.SelectedNode != null)
            {
                sTypeId = tvSTypes.SelectedNode.Name.GetInt();
            }
            List<ViewStoreInfoModel> storeList = RequestStar.LoadStoreList(sTypeId, keywords, chkShowDel.Checked);
            SetColsAndToolBtns(chkShowDel.Checked);//设置工具项的可用与操作列的显示
            if (storeList.Count > 0)
            {
                tsbtnInfo.Enabled = true;
                dgvStoreList.AutoGenerateColumns = false;
                dgvStoreList.DataSource = storeList;
            }
            else
            {
                tsbtnInfo.Enabled = false;
                dgvStoreList.DataSource = null;
                dgvStoreList.AllowUserToAddRows = false;
            }
        }

        /// <summary>
        /// 设置工具项的可用与操作列的显示
        /// </summary>
        /// <param name="checked"></param>
        private void SetColsAndToolBtns(bool isShowDel)
        {
            dgvStoreList.Columns["Edit"].Visible = !isShowDel;
            dgvStoreList.Columns["Del"].Visible = !isShowDel;
            dgvStoreList.Columns["Recover"].Visible = isShowDel;
            dgvStoreList.Columns["Remove"].Visible = isShowDel;
            tsbtnAdd.Enabled = !isShowDel;
            tsbtnEdit.Enabled = !isShowDel;
            tsbtnDelete.Enabled = !isShowDel;
        }

        /// <summary>
        /// 加载仓库类别节点树
        /// </summary>
        private void LoadTVStoreTypes()
        {
            tvSTypes.Nodes.Clear();
            TreeNode rootNode = FormUtility.CreateNode("0", "仓库类别");
            tvSTypes.Nodes.Add(rootNode);
            //获取仓库类别数据
            List<StoreTypeInfoModel> typeList = RequestStar.LoadAllDrpStoreTypes();
            FormUtility.AddTvSTypesNode(typeList, rootNode);
            tvSTypes.SelectedNode = rootNode;//默认选择根节点
            tvSTypes.ExpandAll();//展开所有节点
        }

        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            LoadStoreList();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadStoreList();
        }

        private void tvSTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadStoreList();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            ShowStoreInfoPage(1, 0);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStoreList.CurrentRow != null)
            {
                ViewStoreInfoModel storeInfo = dgvStoreList.CurrentRow.DataBoundItem as ViewStoreInfoModel;
                if (storeInfo != null)
                {
                    ShowStoreInfoPage(2, storeInfo.StoreId);
                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("请选择要修改的仓库信息！");
                return;
            }
        }

        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            if (dgvStoreList.CurrentRow != null)
            {
                ViewStoreInfoModel storeInfo = dgvStoreList.CurrentRow.DataBoundItem as ViewStoreInfoModel;
                if (storeInfo != null)
                {
                    ShowStoreInfoPage(4, storeInfo.StoreId);
                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("请选择要查看的仓库信息！");
                return;
            }
        }

        private void dgvStoreList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Action act = () =>
            {
                if (e.RowIndex >= 0)
                {
                    var curCell = dgvStoreList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    ViewStoreInfoModel storeInfo = dgvStoreList.Rows[e.RowIndex].DataBoundItem as ViewStoreInfoModel;
                    string cellVal = curCell.FormattedValue.ToString();
                    switch (cellVal)
                    {
                        case "修改":
                            ShowStoreInfoPage(2, storeInfo.StoreId);
                            break;
                        case "删除":
                            DeleteStoreInfo(1, storeInfo);
                            break;
                        case "恢复":
                            DeleteStoreInfo(0, storeInfo);
                            break;
                        case "移除":
                            DeleteStoreInfo(2, storeInfo);
                            break;
                    }
                }
            };
            act.TryCatch("操作单位信息数据异常！");
        }

        /// <summary>
        /// 仓库信息删除处理（删除、恢复、移除）
        /// </summary>
        /// <param name="v"></param>
        /// <param name="storeInfo"></param>
        private void DeleteStoreInfo(int isDeleted, ViewStoreInfoModel storeInfo)
        {
            string delTypeName = FormUtility.GetDeleteTypeName(isDeleted);
            string msgTitle = $"仓库信息{delTypeName}";
            if (MsgBoxHelper.MsgBoxConfirm(msgTitle, $"您确定要{delTypeName}该仓库信息？") == DialogResult.Yes)
            {
                bool bl = false;
                switch (isDeleted)
                {
                    case 1://删除
                           //如果仓库在使用中，不允许删除
                        bool isStoreUse = RequestStar.CheckStoreUse(storeInfo.StoreId);
                        if (!isStoreUse)
                        {
                            bl = RequestStar.DeleteStoreInfo(storeInfo.StoreId);
                        }
                        else
                        {
                            MsgBoxHelper.MsgErrorShow($"该仓库:{storeInfo.StoreName} 在使用中，不能删除！");
                            return;
                        }
                        break;
                    case 0://恢复
                        bl = RequestStar.RecoverStoreInfo(storeInfo.StoreId, uName);
                        break;
                    case 2://移除
                        bl = RequestStar.RemoveStoreInfo(storeInfo.StoreId);
                        break;
                }
                string sucType = bl ? "成功" : "失败";
                string delMsg = $"仓库信息:{storeInfo.StoreName} {delTypeName} {sucType}";
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, delMsg);
                    LoadStoreList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(delMsg);
                    return;
                }
            }

        }


        /// <summary>
        /// 显示仓库信息页面（新增、修改、详情）
        /// </summary>
        /// <param name="actType">1  add  2 edit  4 info</param>
        /// <param name="unitId"></param>
        private void ShowStoreInfoPage(int actType, int storeId)
        {
            //acttype  id   uname    （reload刷新列表数据）
            //另一种刷新：利用事件   为信息页面定义一个事件
            FrmStoreInfo fStoreInfo = new FrmStoreInfo();
            fStoreInfo.Tag = new FInfoModel()
            {
                ActType = actType,
                FId = storeId,
                UName = uName
            };
            if (actType != 4)
                fStoreInfo.ReLoadHandler += LoadStoreList;//订阅  并不是每种都需要刷新
            fStoreInfo.ShowDialog();
        }

        /// <summary>
        /// 响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            txtKeyWords.Clear();
            tvSTypes.SelectedNode = tvSTypes.Nodes[0];
            chkShowDel.Checked = false;
            LoadStoreList();
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }

        /// <summary>
        /// 打开仓库类别管理页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnType_Click(object sender, EventArgs e)
        {
            FrmStoreTypeList fStoreTypeList = new FrmStoreTypeList();
            fStoreTypeList.Tag = uName;
            fStoreTypeList.TVStoreTypeReload += LoadTVStoreTypes;//刷新类别节点树
            fStoreTypeList.ShowDialog();
        }

        /// <summary>
        /// 仓库信息批量删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                            //SelectedRows 选定行的集合（MultiSelect True ）  多个行
                            if (dgvStoreList.SelectedRows.Count == 0)
                {
                    MsgBoxHelper.MsgErrorShow("请选择要删除的仓库信息");
                    return;
                }
                string title = "删除仓库信息";
                if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要删除选择的这些仓库信息吗？") == DialogResult.Yes)
                {
                    List<int> storeIds = new List<int>();
                    string IsUseStoreNames = "";
                    foreach (DataGridViewRow row in dgvStoreList.SelectedRows)
                    {
                        ViewStoreInfoModel sInfo = row.DataBoundItem as ViewStoreInfoModel;
                                    //如果该类别添加了仓库，不允许删除
                                    bool isStoreUsee = RequestStar.CheckStoreUse(sInfo.StoreId);
                        if (!isStoreUsee)
                        {
                            storeIds.Add(sInfo.StoreId);
                        }
                        else
                        {
                            if (IsUseStoreNames.Length > 0) IsUseStoreNames += ",";
                            IsUseStoreNames += sInfo.StoreName;
                        }
                    }
                    if (storeIds.Count > 0)
                    {
                        bool bl = RequestStar.DeleteStoreInfos(storeIds);//执行批量删除
                                    string sucMsg = bl ? "成功" : "失败";
                        string msg = $"选择的仓库信息中符合删除要求的信息 删除 {sucMsg}!";

                        if (bl)
                        {
                            if (!string.IsNullOrEmpty(IsUseStoreNames))
                                msg += $" {IsUseStoreNames} 已经使用，不能删除！";
                            MsgBoxHelper.MsgBoxShow(title, msg);
                            LoadStoreList();
                        }
                        else
                            MsgBoxHelper.MsgErrorShow(msg);
                    }
                    else
                        MsgBoxHelper.MsgErrorShow("没有符合删除要求的仓库信息！");
                }
            };
            act.TryCatch("批量删除仓库信息异常！");
        }
    }
}
