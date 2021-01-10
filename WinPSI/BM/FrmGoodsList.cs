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
    public partial class FrmGoodsList : Form
    {
        public FrmGoodsList()
        {
            InitializeComponent();
        }

        private string uName = "";//账号  
        private void FrmGoodsList_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                {
                    uName = this.Tag.ToString();
                }
                txtKeyWords.Clear();
                LoadTVGoodsTypes();
                LoadGoodsList();//加载所有商品信息
                        };
            act.TryCatch("商品信息加载异常！");
        }

        /// <summary>
        /// 加载所有商品信息
        /// </summary>
        private void LoadGoodsList()
        {
            string keywords = txtKeyWords.Text.Trim();
            int gTypeId = 0;
            if (tvGTypes.SelectedNode != null)
            {
                gTypeId = tvGTypes.SelectedNode.Name.GetInt();
            }
            PageModel<ViewGoodsInfoModel> pageModel = RequestStar.LoadGoodsList(gTypeId, keywords, chkStop.Checked, chkShowDel.Checked, ucPager1.StartRecord, ucPager1.PageSize);
            SetColsAndToolBtns(chkShowDel.Checked);
            if (pageModel != null)
            {
                if (pageModel.ReList.Count > 0)
                {
                    dgvGoodsList.AutoGenerateColumns = false;
                    dgvGoodsList.DataSource = pageModel.ReList;
                }
                else
                {
                    dgvGoodsList.DataSource = null;
                    dgvGoodsList.AllowUserToAddRows = false;
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

        /// <summary>
        /// 设置操作列的显示与工具项的可用
        /// </summary>
        /// <param name="isShowDel"></param>
        private void SetColsAndToolBtns(bool isShowDel)
        {
            dgvGoodsList.Columns["Edit"].Visible = !isShowDel;
            dgvGoodsList.Columns["Del"].Visible = !isShowDel;
            dgvGoodsList.Columns["RecoverCol"].Visible = isShowDel;
            dgvGoodsList.Columns["Remove"].Visible = isShowDel;
            tsbtnAdd.Enabled = !isShowDel;
            tsbtnEdit.Enabled = !isShowDel;
            tsbtnDelete.Enabled = !isShowDel;
        }

        /// <summary>
        /// 递归加载商品类别
        /// </summary>
        private void LoadTVGoodsTypes()
        {
            tvGTypes.Nodes.Clear();
            TreeNode rootNode = FormUtility.CreateNode("0", "商品类别");
            tvGTypes.Nodes.Add(rootNode);
            //获取节点数据
            List<GoodsTypeInfoModel> typeList = RequestStar.LoadAllGoodsTypes();
            FormUtility.AddTvGTypesNode(typeList, rootNode, 0);//递归加载节点
            tvGTypes.SelectedNode = rootNode;
            tvGTypes.ExpandAll();//展开所有节点
        }
        /// <summary>
        /// 分页响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucPager1_BindSource(object sender, EventArgs e)
        {
            LoadGoodsList();
        }

        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            ucPager1.CurrentPage = 1;
            LoadGoodsList();
        }

        private void chkStop_CheckedChanged(object sender, EventArgs e)
        {
            ucPager1.CurrentPage = 1;
            LoadGoodsList();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadGoodsList();
        }

        /// <summary>
        /// 新增商品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            ShowGoodsInfoPage(1, 0);
        }

        /// <summary>
        /// 显示商品信息页面（新增、修改、详情）
        /// </summary>
        /// <param name="actType">1  add  2 edit  4 info</param>
        /// <param name="goodsId"></param>
        private void ShowGoodsInfoPage(int actType, int goodsId)
        {
            //acttype  id   uname    （reload刷新列表数据）
            //另一种刷新：利用事件   为信息页面定义一个事件
            FrmGoodsInfo fGoodsInfo = new FrmGoodsInfo();
            fGoodsInfo.Tag = new FInfoModel()
            {
                ActType = actType,
                FId = goodsId,
                UName = uName
            };
            if (actType != 4)
                fGoodsInfo.ReLoadHandler += LoadGoodsList;//订阅  并不是每种都需要刷新
            fGoodsInfo.ShowDialog();
        }

        /// <summary>
        /// 修改响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvGoodsList.CurrentRow != null)
            {
                ViewGoodsInfoModel goodsInfo = dgvGoodsList.CurrentRow.DataBoundItem as ViewGoodsInfoModel;
                if (goodsInfo != null)
                {
                    ShowGoodsInfoPage(2, goodsInfo.GoodsId);
                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("请选择要修改的商品信息！");
                return;
            }
        }

        /// <summary>
        /// 详情响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            if (dgvGoodsList.CurrentRow != null)
            {
                ViewGoodsInfoModel goodsInfo = dgvGoodsList.CurrentRow.DataBoundItem as ViewGoodsInfoModel;
                if (goodsInfo != null)
                {
                    ShowGoodsInfoPage(4, goodsInfo.GoodsId);
                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("请选择要查看的商品信息！");
                return;
            }
        }

        private void dgvGoodsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Action act = () =>
            {
                if (e.RowIndex >= 0)
                {
                    var curCell = dgvGoodsList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    ViewGoodsInfoModel goodsInfo = dgvGoodsList.Rows[e.RowIndex].DataBoundItem as ViewGoodsInfoModel;
                    string cellVal = curCell.FormattedValue.ToString();
                    switch (cellVal)
                    {
                        case "修改":
                            ShowGoodsInfoPage(2, goodsInfo.GoodsId);
                            break;
                        case "删除":
                            DeleteGoodsInfo(1, goodsInfo);
                            break;
                        case "恢复":
                            DeleteGoodsInfo(0, goodsInfo);
                            break;
                        case "移除":
                            DeleteGoodsInfo(2, goodsInfo);
                            break;
                    }
                }
            };
            act.TryCatch("操作商品信息数据异常！");
        }

        /// <summary>
        /// 删除商品信息处理（删除、恢复、移除）
        /// </summary>
        /// <param name="isDeleted"></param>
        /// <param name="goodsInfo"></param>
        private void DeleteGoodsInfo(int isDeleted, ViewGoodsInfoModel goodsInfo)
        {
            string delTypeName = FormUtility.GetDeleteTypeName(isDeleted);
            string msgTitle = $"商品信息{delTypeName}";
            if (MsgBoxHelper.MsgBoxConfirm(msgTitle, $"您确定要{delTypeName}该商品信息？") == DialogResult.Yes)
            {
                bool bl = false;
                switch (isDeleted)
                {
                    case 1://删除
                           //如果商品在使用中，不允许删除
                        bool IsGoodsUse = RequestStar.CheckIsGoodsUse(goodsInfo.GoodsId);
                        if (!IsGoodsUse)
                        {
                            bl = RequestStar.DeleteGoodsInfo(goodsInfo.GoodsId);
                        }
                        else
                        {
                            MsgBoxHelper.MsgErrorShow($"该商品:{goodsInfo.GoodsName}在使用中，不能删除！");
                            return;
                        }
                        break;
                    case 0://恢复
                        bl = RequestStar.RecoverGoodsInfo(goodsInfo.GoodsId, uName);
                        break;
                    case 2://移除
                        bl = RequestStar.RemoveGoodsInfo(goodsInfo.GoodsId);
                        break;
                }
                string sucType = bl ? "成功" : "失败";
                string delMsg = $"商品信息:{goodsInfo.GoodsName} {delTypeName} {sucType}";
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, delMsg);
                    LoadGoodsList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(delMsg);
                    return;
                }
            }
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
            chkStop.Checked = false;
            tvGTypes.SelectedNode = tvGTypes.Nodes[0];
            LoadGoodsList();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }

        private void tvGTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadGoodsList();
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                            //SelectedRows 选定行的集合（MultiSelect True ）  多个行
                            if (dgvGoodsList.SelectedRows.Count == 0)
                {
                    MsgBoxHelper.MsgErrorShow("请选择要删除的商品信息");
                    return;
                }
                string title = "删除商品信息";
                if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要删除选择的这些商品信息吗？") == DialogResult.Yes)
                {
                    List<int> goodsIds = new List<int>();
                    string IsUseGoodsNames = "";
                    foreach (DataGridViewRow row in dgvGoodsList.SelectedRows)
                    {
                        ViewGoodsInfoModel gInfo = row.DataBoundItem as ViewGoodsInfoModel;
                                    //如果该类别添加了商品，不允许删除
                                    bool isGoodsUse = RequestStar.CheckIsGoodsUse(gInfo.GoodsId);
                        if (!isGoodsUse)
                        {
                            goodsIds.Add(gInfo.GoodsId);
                        }
                        else
                        {
                            if (IsUseGoodsNames.Length > 0) IsUseGoodsNames += ",";
                            IsUseGoodsNames += gInfo.GoodsName;
                        }
                    }
                    if (goodsIds.Count > 0)
                    {
                        bool bl = RequestStar.DeleteGoodsInfos(goodsIds);//执行批量删除
                                    string sucMsg = bl ? "成功" : "失败";
                        string msg = $"选择的商品信息中符合删除要求的信息 删除 {sucMsg}!";

                        if (bl)
                        {
                            if (!string.IsNullOrEmpty(IsUseGoodsNames))
                                msg += $" {IsUseGoodsNames} 已经使用，不能删除！";
                            MsgBoxHelper.MsgBoxShow(title, msg);
                            LoadGoodsList();
                        }
                        else
                            MsgBoxHelper.MsgErrorShow(msg);
                    }
                    else
                        MsgBoxHelper.MsgErrorShow("没有符合删除要求的商品信息！");
                }
            };
            act.TryCatch("批量删除商品信息异常！");
        }

        /// <summary>
        /// 商品类别响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnType_Click(object sender, EventArgs e)
        {
            FrmGoodsTypeList fGoodsType = new FrmGoodsTypeList();
            fGoodsType.Tag = uName;
            fGoodsType.ReloadTVGoodsTypes += LoadTVGoodsTypes;
            fGoodsType.ShowDialog();
        }
    }
}
