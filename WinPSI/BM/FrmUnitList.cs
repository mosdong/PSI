using PSI.Common;
using PSI.Models.DModels;
using PSI.Models.UIModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Request;

namespace WinPSI.BM
{
    public partial class FrmUnitList : Form
    {
        public FrmUnitList()
        {
            InitializeComponent();
        }
        string uName = "";//账号
        private void FrmUnitList_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                {
                    uName = this.Tag.ToString();
                }
                txtKeyWords.Clear();
                LoadTVUnitTypes();//加载单位类别节点树
                            LoadUnitList();//加载所有单位信息
                        };
            act.TryCatch("单位信息加载异常！");
        }

        /// <summary>
        /// 条件查询单位信息
        /// </summary>
        private void LoadUnitList()
        {
            string keywords = txtKeyWords.Text.Trim();
            int uTypeId = 0;
            if (tvUTypes.SelectedNode != null)
            {
                uTypeId = tvUTypes.SelectedNode.Name.GetInt();
            }
            PageModel<ViewUnitInfoModel> pageModel = RequestStar.GetUnitList(uTypeId, keywords, chkShowDel.Checked, ucPager1.StartRecord, ucPager1.PageSize);
            SetColsAndToolBtns(chkShowDel.Checked);//设置工具项的可用与操作列的显示
            if (pageModel != null)
            {
                if (pageModel.ReList.Count > 0)
                {
                    dgvUnitList.AutoGenerateColumns = false;
                    dgvUnitList.DataSource = pageModel.ReList;
                    tsbtnInfo.Enabled = true;
                }
                else
                {
                    dgvUnitList.DataSource = null;
                    dgvUnitList.AllowUserToAddRows = false;
                    tsbtnInfo.Enabled = false;
                }
                if (pageModel.TotalCount > 0)
                {
                    ucPager1.Visible = true;
                    ucPager1.Record = pageModel.TotalCount;
                }

                else
                    ucPager1.Visible = false;

            }
        }

        private void SetColsAndToolBtns(bool isShowDel)
        {
            dgvUnitList.Columns["Edit"].Visible = !isShowDel;
            dgvUnitList.Columns["Del"].Visible = !isShowDel;
            dgvUnitList.Columns["Recover"].Visible = isShowDel;
            dgvUnitList.Columns["Remove"].Visible = isShowDel;
            tsbtnAdd.Enabled = !isShowDel;
            tsbtnEdit.Enabled = !isShowDel;
            tsbtnDelete.Enabled = !isShowDel;
        }

        /// <summary>
        /// 加载单位类别节点树
        /// </summary>
        private void LoadTVUnitTypes()
        {
            tvUTypes.Nodes.Clear();
            TreeNode rootNode = FormUtility.CreateNode("0", "往来单位类别");
            tvUTypes.Nodes.Add(rootNode);
            //获取单位类别数据
            List<UnitTypeInfoModel> typeList = RequestStar.LoadAllTVUnitTypes();
            FormUtility.AddTvUTypesNode(typeList, rootNode, 0);//将类别数据加载到根节点
            tvUTypes.SelectedNode = rootNode;//默认选择根节点
            tvUTypes.ExpandAll();//展开所有节点
        }

        /// <summary>
        /// 显示已删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            LoadUnitList();
        }

        /// <summary>
        /// 选择类别响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvUTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadUnitList();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadUnitList();
        }
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            txtKeyWords.Clear();
            chkShowDel.Checked = false;
            tvUTypes.SelectedNode = tvUTypes.Nodes[0];
            LoadUnitList();
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

        private void ucPager1_BindSource(object sender, EventArgs e)
        {
            LoadUnitList();
        }

        /// <summary>
        /// 新增单位信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            ShowUnitInfoPage(1, 0);
        }

        /// <summary>
        /// 显示单位信息页面（新增、修改、详情）
        /// </summary>
        /// <param name="actType">1  add  2 edit  4 info</param>
        /// <param name="unitId"></param>
        private void ShowUnitInfoPage(int actType, int unitId)
        {
            //acttype  id   uname    （reload刷新列表数据）
            //另一种刷新：利用事件   为信息页面定义一个事件
            FrmUnitInfo fUnitInfo = new FrmUnitInfo();
            fUnitInfo.Tag = new FInfoModel()
            {
                ActType = actType,
                FId = unitId,
                UName = uName
            };
            if (actType != 4)
                fUnitInfo.ReLoadHandler += LoadUnitList;//订阅  并不是每种都需要刷新
            fUnitInfo.ShowDialog();
        }

        /// <summary>
        /// 修改单位信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUnitList.CurrentRow != null)
            {
                ViewUnitInfoModel unitInfo = dgvUnitList.CurrentRow.DataBoundItem as ViewUnitInfoModel;
                if (unitInfo != null)
                {
                    ShowUnitInfoPage(2, unitInfo.UnitId);
                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("请选择要修改的单位信息！");
                return;
            }
        }

        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            if (dgvUnitList.CurrentRow != null)
            {
                ViewUnitInfoModel unitInfo = dgvUnitList.CurrentRow.DataBoundItem as ViewUnitInfoModel;
                if (unitInfo != null)
                {
                    ShowUnitInfoPage(4, unitInfo.UnitId);
                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("请选择要查看的单位信息！");
                return;
            }
        }

        /// <summary>
        /// 打开单位类别管理页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnType_Click(object sender, EventArgs e)
        {
            FrmUnitTypeList fUnitTypeList = new FrmUnitTypeList();
            fUnitTypeList.Tag = uName;
            fUnitTypeList.TVUTypesReLoad += LoadTVUnitTypes;//刷新类别节点树
            fUnitTypeList.ShowDialog();
        }

        private void dgvUnitList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Action act = () =>
            {
                if (e.RowIndex >= 0)
                {
                    var curCell = dgvUnitList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    ViewUnitInfoModel unitInfo = dgvUnitList.Rows[e.RowIndex].DataBoundItem as ViewUnitInfoModel;
                    string cellVal = curCell.FormattedValue.ToString();
                    switch (cellVal)
                    {
                        case "修改":
                            ShowUnitInfoPage(2, unitInfo.UnitId);
                            break;
                        case "删除":
                            DeleteUnitInfo(1, unitInfo);
                            break;
                        case "恢复":
                            DeleteUnitInfo(0, unitInfo);
                            break;
                        case "移除":
                            DeleteUnitInfo(2, unitInfo);
                            break;
                    }
                }
            };
            act.TryCatch("操作单位信息数据异常！");
        }

        /// <summary>
        /// 删除单位信息（删除、恢复、移除）
        /// </summary>
        /// <param name="isDeleted"></param>
        /// <param name="unitInfo"></param>
        private void DeleteUnitInfo(int isDeleted, ViewUnitInfoModel unitInfo)
        {
            string delTypeName = FormUtility.GetDeleteTypeName(isDeleted);
            string msgTitle = $"单位信息{delTypeName}";
            if (MsgBoxHelper.MsgBoxConfirm(msgTitle, $"您确定要{delTypeName}该单位信息？") == DialogResult.Yes)
            {
                bool bl = false;
                switch (isDeleted)
                {
                    case 1://删除
                           //如果单位在使用中，不允许删除
                        bool isUnitUse = RequestStar.CheckUnitUse(unitInfo.UnitId);
                        if (!isUnitUse)
                        {
                            bl = RequestStar.UnitLogicDelete(unitInfo.UnitId);
                        }
                        else
                        {
                            MsgBoxHelper.MsgErrorShow($"该单位:{unitInfo.UnitName} 在使用中，不能删除！");
                            return;
                        }
                        break;
                    case 0://恢复
                        bl = RequestStar.UnitRecover(unitInfo.UnitId);
                        break;
                    case 2://移除
                        bl = RequestStar.UnitDelete(unitInfo.UnitId);
                        break;
                }
                string sucType = bl ? "成功" : "失败";
                string delMsg = $"单位信息:{unitInfo.UnitName} {delTypeName} {sucType}";
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, delMsg);
                    LoadUnitList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(delMsg);
                    return;
                }
            }
        }

        /// <summary>
        /// 批量删除单位信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                            //SelectedRows 选定行的集合（MultiSelect True ）  多个行
                            if (dgvUnitList.SelectedRows.Count == 0)
                {
                    MsgBoxHelper.MsgErrorShow("请选择要删除的单位信息");
                    return;
                }
                string title = "删除单位信息";
                if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要删除选择的这些单位信息吗？") == DialogResult.Yes)
                {
                    List<int> unitIds = new List<int>();
                    string IsUseUnitNames = "";
                    foreach (DataGridViewRow row in dgvUnitList.SelectedRows)
                    {
                        ViewUnitInfoModel uInfo = row.DataBoundItem as ViewUnitInfoModel;
                                    //如果该类别添加了商品，不允许删除
                                    bool isUnitUse = RequestStar.CheckUnitUse(uInfo.UnitId);
                        if (!isUnitUse)
                        {
                            unitIds.Add(uInfo.UnitId);
                        }
                        else
                        {
                            if (IsUseUnitNames.Length > 0) IsUseUnitNames += ",";
                            IsUseUnitNames += uInfo.UnitName;
                        }
                    }
                    if (unitIds.Count > 0)
                    {
                        bool bl = RequestStar.UnitLogicDeleteList(unitIds);//执行批量删除
                                    string sucMsg = bl ? "成功" : "失败";
                        string msg = $"选择的单位信息中符合删除要求的信息 删除 {sucMsg}!";

                        if (bl)
                        {
                            if (!string.IsNullOrEmpty(IsUseUnitNames))
                                msg += $"  {IsUseUnitNames} 已经使用，不能删除！";
                            MsgBoxHelper.MsgBoxShow(title, msg);
                            LoadUnitList();
                        }
                        else
                            MsgBoxHelper.MsgErrorShow(msg);
                    }
                    else
                        MsgBoxHelper.MsgErrorShow("没有符合删除要求的单位信息！");
                }
            };
            act.TryCatch("批量删除单位信息异常！");
        }
    }
}
