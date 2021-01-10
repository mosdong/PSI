using PSI.Common;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.Request;

namespace WinPSI.BM
{
    public partial class FrmStoreTypeList : Form
    { 
        public FrmStoreTypeList()
        {
            InitializeComponent();
        }
        private string uName = "";//登录者账号
        private int storeTypeId = 0;//当前编辑的类别编号
        private string oldName = "";//原始类别名称
        public event Action TVStoreTypeReload;//刷新列表页的类别节点树
        private void FrmStoreTypeList_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                {
                    Type tagType = this.Tag.GetType();
                                //1.账号信息  string
                                if (tagType == typeof(string))
                    {
                        uName = this.Tag.ToString();
                    }
                    else  //2.Model   class
                                {

                    }

                }
                gbInfo.Visible = false;
                            //加载仓库类别列表
                            LoadStoreTypeList();
            };
            act.TryCatch("仓库类别信息加载异常！");
        }

        /// <summary>
        /// 加载所有仓库类别列表
        /// </summary>
        private void LoadStoreTypeList()
        {
            bool isShowDel = chkShowDel.Checked;
            List<StoreTypeInfoModel> typeList = RequestStar.LoadAllStoreTypes(isShowDel);
            SetColsAndToolBtns(isShowDel);
            if (typeList.Count > 0)
            {
                dgvStoreTypeList.AutoGenerateColumns = false;
                dgvStoreTypeList.DataSource = typeList;
            }
            else
            {
                dgvStoreTypeList.DataSource = null;
                dgvStoreTypeList.AllowUserToAddRows = false;
            }
        }

        /// <summary>
        /// 操作列的显示与否，工具项的可用与否
        /// </summary>
        /// <param name="isShowDel"></param>
        private void SetColsAndToolBtns(bool isShowDel)
        {
            dgvStoreTypeList.Columns["Edit"].Visible = !isShowDel;
            dgvStoreTypeList.Columns["Del"].Visible = !isShowDel;
            dgvStoreTypeList.Columns["Recover"].Visible = isShowDel;
            dgvStoreTypeList.Columns["Remove"].Visible = isShowDel;
            tsbtnAdd.Enabled = !isShowDel;
            tsbtnEdit.Enabled = !isShowDel;
            tsbtnDelete.Enabled = !isShowDel;
        }

        /// <summary>
        /// 显示已删除复选框的响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            LoadStoreTypeList();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            chkShowDel.Checked = false;
            LoadStoreTypeList();
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.TVStoreTypeReload?.Invoke();
            this.CloseForm();
        }

        /// <summary>
        /// 新增类别信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            ShowAddTypeInfo(null);
        }

        /// <summary>
        /// 显示新增信息栏，重置信息
        /// </summary>
        private void ShowAddTypeInfo(StoreTypeInfoModel stInfo)
        {
            gbInfo.Visible = true;
            if (stInfo == null)
            {
                storeTypeId = 0;
                txtSTypeName.Clear();
                txtSTPYNo.Clear();
                txtSTOrder.Clear();
                btnSave.Text = "新增";
                oldName = "";
            }
            else
            {
                storeTypeId = stInfo.STypeId;
                txtSTypeName.Text = stInfo.STypeName;
                txtSTPYNo.Text = stInfo.STPYNo;
                txtSTOrder.Text = stInfo.STypeOrder.ToString();
                btnSave.Text = "修改";
                oldName = stInfo.STypeName;
            }
        }

        /// <summary>
        /// 修改类别信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStoreTypeList.CurrentRow != null)
            {
                StoreTypeInfoModel stInfo = dgvStoreTypeList.CurrentRow.DataBoundItem as StoreTypeInfoModel;
                ShowAddTypeInfo(stInfo);
            }

        }

        private void dgvStoreTypeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Action act = () =>
            {
                if (e.RowIndex >= 0)
                {
                    var curCell = dgvStoreTypeList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    StoreTypeInfoModel stInfo = dgvStoreTypeList.Rows[e.RowIndex].DataBoundItem as StoreTypeInfoModel;
                    string cellVal = curCell.FormattedValue.ToString();
                    switch (cellVal)
                    {
                        case "修改":
                            ShowAddTypeInfo(stInfo);
                            break;
                        case "删除":
                            DeleteStoreType(1, stInfo);
                            break;
                        case "恢复":
                            DeleteStoreType(0, stInfo);
                            break;
                        case "移除":
                            DeleteStoreType(2, stInfo);
                            break;
                    }
                }
            };
            act.TryCatch("操作仓库类别数据异常！");
        }

        /// <summary>
        /// 删除类别信息处理（删除、恢复、移除）
        /// </summary>
        /// <param name="isDeleted"></param>
        /// <param name="st"></param>
        private void DeleteStoreType(int isDeleted, StoreTypeInfoModel st)
        {
            string delTypeName = FormUtility.GetDeleteTypeName(isDeleted);
            string msgTitle = $"仓库类别{delTypeName}";
            if (MsgBoxHelper.MsgBoxConfirm(msgTitle, $"您确定要{delTypeName}该仓库类别？") == DialogResult.Yes)
            {
                bool bl = false;
                switch (isDeleted)
                {
                    case 1://删除
                           //如果该类别添加了仓库，不允许删除
                        bool hasAddStores = RequestStar.IsAddStores(st.STypeId);
                        if (!hasAddStores)
                        {
                            bl = RequestStar.StoreTypeLogicDelete(st.STypeId);
                        }
                        else
                        {
                            MsgBoxHelper.MsgErrorShow($"该类别:{st.STypeName} 已经添加了仓库，不能删除！");
                            return;
                        }
                        break;
                    case 0://恢复
                        bl = RequestStar.StoreTypeRecover(st.STypeId);
                        break;
                    case 2://移除
                        bl = RequestStar.StoreTypeDelete(st.STypeId);
                        break;
                }
                string sucType = bl ? "成功" : "失败";
                string delMsg = $"仓库类别:{st.STypeName} {delTypeName} {sucType}";
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, delMsg);
                    LoadStoreTypeList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(delMsg);
                    return;
                }
            }
        }

        /// <summary>
        /// 批量删除或单条删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                            //SelectedRows 选定行的集合（MultiSelect True ）  多个行
                            if (dgvStoreTypeList.SelectedRows.Count == 0)
                {
                    MsgBoxHelper.MsgErrorShow("请选择要删除的仓库类别信息");
                    return;
                }
                string title = "删除仓库类别";
                if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要删除选择的这些仓库类别信息吗？") == DialogResult.Yes)
                {
                    List<int> typeIds = new List<int>();
                    string hasAddStoresNames = "";
                    foreach (DataGridViewRow row in dgvStoreTypeList.SelectedRows)
                    {
                        StoreTypeInfoModel stInfo = row.DataBoundItem as StoreTypeInfoModel;
                                    //如果该类别添加了仓库，不允许删除
                                    bool hasAddStores = RequestStar.IsAddStores(stInfo.STypeId);
                        if (!hasAddStores)
                        {
                            typeIds.Add(stInfo.STypeId);
                        }
                        else
                        {
                            if (hasAddStoresNames.Length > 0) hasAddStoresNames += ",";
                            hasAddStoresNames += stInfo.STypeName;
                        }
                    }
                    if (typeIds.Count > 0)
                    {
                        bool bl = RequestStar.StoreTypeLogicDeleteList(typeIds);//执行批量删除
                                    string sucMsg = bl ? "成功" : "失败";
                        string msg = $"选择的类别信息中符合删除要求的信息 删除 {sucMsg}!";
                        if (bl)
                        {
                            if (!string.IsNullOrEmpty(hasAddStoresNames))
                                msg += $" {hasAddStoresNames} 已经添加了仓库，不能删除！";
                            MsgBoxHelper.MsgBoxShow(title, msg);
                            LoadStoreTypeList();
                        }
                        else
                            MsgBoxHelper.MsgErrorShow(msg);
                    }
                    else
                        MsgBoxHelper.MsgErrorShow("没有符合删除要求的类别信息!");
                }
            };
            act.TryCatch("批量删除仓库类别信息异常！");
        }

        /// <summary>
        /// 新增、修改提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //信息获取
            string typeName = txtSTypeName.Text.Trim();
            string pyNo = txtSTPYNo.Text.Trim();
            int stOrder = txtSTOrder.Text.GetInt();

            //判空处理
            if (string.IsNullOrEmpty(typeName))
            {
                MsgBoxHelper.MsgErrorShow("请输入仓库类别名称！");
                txtSTypeName.Focus();
                return;
            }
            //判断已存在
            if (storeTypeId == 0 || (!string.IsNullOrEmpty(oldName) && oldName != typeName))
            {
                if (RequestStar.ExistsStoreType(typeName))
                {
                    MsgBoxHelper.MsgErrorShow("该仓库类别已存在！");
                    txtSTypeName.Focus();
                    return;
                }
            }

            //信息封装
            StoreTypeInfoModel stInfo = new StoreTypeInfoModel()
            {
                STypeId = storeTypeId,
                STypeName = typeName,
                STPYNo = pyNo,
                STypeOrder = stOrder,
                Creator = uName
            };

            //方法执行
            bool bl = false;
            if (storeTypeId == 0)
            {
                bl = RequestStar.AddStoreType(stInfo);
            }
            else
            {
                bl = RequestStar.UpdateStoreType(stInfo);
            }
            string actType = storeTypeId == 0 ? "添加" : "修改";
            string sucType = bl ? "成功" : "失败";
            string actMsg = $"仓库类别信息:{typeName} {actType} {sucType}";
            string msgTitle = $"{actType}仓库类别";
            if (bl)
            {
                MsgBoxHelper.MsgBoxShow(msgTitle, actMsg);
                LoadStoreTypeList();
                if (storeTypeId == 0)
                {
                    txtSTOrder.Clear();
                    txtSTPYNo.Clear();
                    txtSTypeName.Clear();
                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow(actMsg);
                return;
            }
        }

        /// <summary>
        /// 拼音码生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSTypeName_TextChanged(object sender, EventArgs e)
        {
            txtSTPYNo.Text = PingYinHelper.GetFirstSpell(txtSTypeName.Text.Trim());
        }
    }
}
