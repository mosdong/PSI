using PSI.BLL;
using PSI.Common;
using PSI.Models.DModels;
using WinPSI.FModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPSI.Request;

namespace WinPSI.BM
{
        public partial class FrmUnitTypeList : Form
        { 
                public FrmUnitTypeList()
                {
                        InitializeComponent();
                }
                private string uName = "";//账号
                private int uTypeId = 0;//当前编辑的编号
                private string oldName = "";//修改前的类别名称
                private UnitTypeInfoModel oldInfo = null;//修改前的类别信息
                public event Action TVUTypesReLoad;//刷新列表页类别节点树
                private void FrmUnitTypeList_Load(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                //1.获取登录名
                                if (this.Tag != null)
                                {
                                        uName = this.Tag.ToString();
                                }
                                //2.往来单位信息类别栏的显示 --隐藏
                                gbInfo.Visible = false;
                                //3.初始化父级类别下拉框 
                                InitCboParents();

                                //4.加载所有往来单位类别信息
                                LoadUnitTypeList();
                        };
                        act.TryCatch("往来单位类别管理页面初始化异常！");
                }

                /// <summary>
                /// 初始化父级类别下拉框 
                /// </summary>
                private void LoadUnitTypeList()
                {
                        string keywords = txtKeywords.Text.Trim();
                        bool isShowDel = chkShowDel.Checked;
                        //设置数据表的操作列显示以及工具项的可用状态
                        SetColumnsAndToolBtns(isShowDel);
                        //获取数据
                        List<UnitTypeInfoModel> typeList = RequestStar.LoadUnitTypeList(keywords, isShowDel);
                        dgvUnitTypeList.AutoGenerateColumns = false;
                        if (typeList.Count > 0)
                                dgvUnitTypeList.DataSource = typeList;
                        else
                                dgvUnitTypeList.DataSource = null;
                        dgvUnitTypeList.AllowUserToAddRows = false;
                }

                /// <summary>
                /// /设置数据表的操作列显示以及工具项的可用状态
                /// </summary>
                /// <param name="isShowDel"></param>
                private void SetColumnsAndToolBtns(bool isShowDel)
                {
                        dgvUnitTypeList.Columns["AddChild"].Visible = !isShowDel;
                        dgvUnitTypeList.Columns["Edit"].Visible = !isShowDel;
                        dgvUnitTypeList.Columns["Del"].Visible = !isShowDel;
                        dgvUnitTypeList.Columns["Recover"].Visible = isShowDel;
                        dgvUnitTypeList.Columns["Remove"].Visible = isShowDel;
                        tsbtnAdd.Enabled = !isShowDel;
                        tsbtnEdit.Enabled = !isShowDel;
                        tsbtnDelete.Enabled = !isShowDel;
                }

                /// <summary>
                /// 加载所有往来单位类别信息
                /// </summary>
                private void InitCboParents()
                {
                        List<UnitTypeInfoModel> typeList = RequestStar.LoadAllDrpUnitTypes();
                        typeList.Insert(0, new UnitTypeInfoModel()
                        {
                                UTypeId = 0,
                                UTypeName = "请选择父级类别"
                        });
                        //指定数据源
                        cboParents.DisplayMember = "UTypeName";
                        cboParents.ValueMember = "UTypeId";
                        cboParents.DataSource = typeList;
                        cboParents.SelectedIndex = 0;
                }

                /// <summary>
                /// 刷新
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnRefresh_Click(object sender, EventArgs e)
                {
                        txtKeywords.Clear();
                        chkShowDel.Checked = false;
                        LoadUnitTypeList();
                }

                private void tsbtnClose_Click(object sender, EventArgs e)
                {
                        this.TVUTypesReLoad?.Invoke();
                        this.CloseForm();
                }

                private void chkShowDel_CheckedChanged(object sender, EventArgs e)
                {
                        LoadUnitTypeList();
                }

                /// <summary>
                /// 查询
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void btnFind_Click(object sender, EventArgs e)
                {
                        LoadUnitTypeList();
                }

                /// <summary>
                /// 新增
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnAdd_Click(object sender, EventArgs e)
                {
                        ShowAddTypeInfo(0);
                }

                /// <summary>
                /// 显示新增信息栏，重置信息
                /// </summary>
                private void ShowAddTypeInfo(int parentId)
                {
                        gbInfo.Visible = true;
                        uTypeId = 0;
                        txtUTypeName.Clear();
                        txtUTypeNo.Clear();
                        txtUTPYNo.Clear();
                        txtUTOrder.Clear();
                        cboParents.SelectedValue = parentId;
                        if (parentId > 0)
                                cboParents.Enabled = false;
                        else
                                cboParents.Enabled = true;
                        btnSave.Text = "新增";
                        oldName = "";
                }

                /// <summary>
                /// 加载修改状态下的类别信息
                /// </summary>
                /// <param name="gtInfo"></param>
                private void ShowEditTypeInfo(UnitTypeInfoModel utInfo)
                {
                        if (utInfo != null)
                        {
                                oldInfo = utInfo;
                                gbInfo.Visible = true;
                                txtUTypeName.Text = utInfo.UTypeName;
                                txtUTypeNo.Text = utInfo.UTypeNo;
                                txtUTPYNo.Text = utInfo.UTPYNo;
                                txtUTOrder.Text = utInfo.UTOrder.ToString();
                                cboParents.SelectedValue = utInfo.ParentId;
                                cboParents.Enabled = true;
                                btnSave.Text = "修改";
                                uTypeId = utInfo.UTypeId;
                                oldName = utInfo.UTypeName;
                        }
                }

                /// <summary>
                /// 修改
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnEdit_Click(object sender, EventArgs e)
                {
                        if (dgvUnitTypeList.CurrentRow != null)
                        {
                                UnitTypeInfoModel utInfo = dgvUnitTypeList.CurrentRow.DataBoundItem as UnitTypeInfoModel;
                                ShowEditTypeInfo(utInfo);
                        }
                        else
                        {
                                MsgBoxHelper.MsgErrorShow("请选择要修改的类别信息！");
                                return;
                        }
                }

                private void dgvUnitTypeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                        Action act = () =>
                        {
                                if (e.RowIndex >= 0)
                                {
                                        var curCell = dgvUnitTypeList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                        UnitTypeInfoModel utInfo = dgvUnitTypeList.Rows[e.RowIndex].DataBoundItem as UnitTypeInfoModel;
                                        string cellVal = curCell.FormattedValue.ToString();
                                        switch (cellVal)
                                        {
                                                case "添加子类别":
                                                        ShowAddTypeInfo(utInfo.UTypeId);
                                                        break;
                                                case "修改":
                                                        ShowEditTypeInfo(utInfo);
                                                        break;
                                                case "删除":
                                                        DeleteUnitType(1, utInfo);
                                                        break;
                                                case "恢复":
                                                        DeleteUnitType(0, utInfo);
                                                        break;
                                                case "移除":
                                                        DeleteUnitType(2, utInfo);
                                                        break;
                                        }
                                }
                        };
                        act.TryCatch("操作商品类别数据异常！");
                }

                /// <summary>
                /// 删除、恢复、移除处理
                /// </summary>
                /// <param name="isDeleted"></param>
                /// <param name="utInfo"></param>
                private void DeleteUnitType(int isDeleted, UnitTypeInfoModel utInfo)
                {
                        string delTypeName = FormUtility.GetDeleteTypeName(isDeleted);
                        string msgTitle = $"往来单位类别{delTypeName}";
                        if (MsgBoxHelper.MsgBoxConfirm(msgTitle, $"您确定要{delTypeName}该往来单位类别？") == DialogResult.Yes)
                        {
                                bool bl = false;
                                switch (isDeleted)
                                {
                                        case 1://删除
                                                //如果该类别添加了单位，不允许删除
                                                bool hasAddUnits = RequestStar.IsAddUnits(utInfo.UTypeId);
                                                //如果该类别添加了子类别，不允许删除
                                                bool hasChilds = RequestStar.IsAddChilds(utInfo.UTypeId);
                                                if (!hasAddUnits && !hasChilds)
                                                {
                                                        bl = RequestStar.UnitTypeLogicDelete(utInfo.UTypeId);
                                                }
                                                else if (hasAddUnits)
                                                {
                                                        MsgBoxHelper.MsgErrorShow($"该类别:{utInfo.UTypeName} 已经添加了单位，不能删除！");
                                                        return;
                                                }
                                                else if (hasChilds)
                                                {
                                                        MsgBoxHelper.MsgErrorShow($"该类别:{utInfo.UTypeName} 已经添加了子类别，不能删除！");
                                                        return;
                                                }
                                                break;
                                        case 0://恢复
                                                bl = RequestStar.UnitTypeRecover(utInfo.UTypeId);
                                                break;
                                        case 2://移除
                                                bl = RequestStar.UnitTypeDelete(utInfo.UTypeId);
                                                break;
                                }
                                string sucType = bl ? "成功" : "失败";
                                string delMsg = $"往来单位类别:{utInfo.UTypeName} {delTypeName} {sucType}";
                                if (bl)
                                {
                                        MsgBoxHelper.MsgBoxShow(msgTitle, delMsg);
                                        LoadUnitTypeList();
                                        if (isDeleted !=2)
                                        {
                                                ReloadCboParents(utInfo,true,isDeleted);
                                        }
                                        
                                }
                                else
                                {
                                        MsgBoxHelper.MsgErrorShow(delMsg);
                                        return;
                                }
                        }
                }

                /// <summary>
                /// 新增、修改、删除、恢复 后刷新下拉框（单条数据）
                /// </summary>
                /// <param name="ut"></param>
                /// <param name="isDel"></param>
                /// <param name="isDeleted"></param>
                private void ReloadCboParents(UnitTypeInfoModel ut, bool isDel,int isDeleted)
                {
                        List<UnitTypeInfoModel> parents = cboParents.DataSource as List<UnitTypeInfoModel>;
                        //清空数据源（cbo DataSource）
                        cboParents.DataSource = null;
                        if (!isDel)
                        {
                                if (uTypeId > 0 && oldName != ut.UTypeName)//修改提交时，类别名称信息发生改变
                                {
                                        parents.Where(t => t.UTypeName == oldName).FirstOrDefault().UTypeName = ut.UTypeName;
                                }
                                else if (uTypeId == 0) //新增或添加子类别
                                {
                                        parents.Add(new UnitTypeInfoModel()
                                        {
                                                UTypeId = ut.UTypeId,
                                                UTypeName = ut.UTypeName
                                        });
                                }
                        }
                        else
                        {
                                if (isDeleted == 1)
                                        parents.Remove(parents.Where(t => t.UTypeId == ut.UTypeId).FirstOrDefault());
                                else
                                        parents.Add(new UnitTypeInfoModel()
                                        {
                                                UTypeId = ut.UTypeId,
                                                UTypeName = ut.UTypeName
                                        });
                        }
                        cboParents.DisplayMember = "UTypeName";
                        cboParents.ValueMember = "UTypeId";
                        cboParents.DataSource = parents;
                        if (!isDel)
                                cboParents.SelectedValue = ut.ParentId;
                }

                /// <summary>
                /// 批量删除后刷新下拉框
                /// </summary>
                /// <param name="typeIds"></param>
                private void ReloadCboParents(List<int> typeIds)
                {
                        List<UnitTypeInfoModel> parents = cboParents.DataSource as List<UnitTypeInfoModel>;
                        //清空数据源（cbo DataSource）
                        cboParents.DataSource = null;
                        parents.Where(t => typeIds.Contains(t.UTypeId)).ToList().ForEach(t => parents.Remove(t));
                        cboParents.DisplayMember = "UTypeName";
                        cboParents.ValueMember = "UTypeId";
                        cboParents.DataSource = parents;
                       
                }

                private void tsbtnDelete_Click(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                //SelectedRows 选定行的集合（MultiSelect True ）  多个行
                                if (dgvUnitTypeList.SelectedRows.Count == 0)
                                {
                                        MsgBoxHelper.MsgErrorShow("请选择要删除的往来单位类别信息");
                                        return;
                                }
                                string title = "删除往来单位类别";
                                if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要删除选择的这些往来单位类别信息吗？") == DialogResult.Yes)
                                {
                                        List<int> typeIds = new List<int>();
                                        string hasChildsNames = "";
                                        string hasAddUnitsNames = "";
                                        foreach (DataGridViewRow row in dgvUnitTypeList.SelectedRows)
                                        {
                                                UnitTypeInfoModel utInfo = row.DataBoundItem as UnitTypeInfoModel;
                                                //如果该类别添加了单位，不允许删除
                                                bool hasAddUnits = RequestStar.IsAddUnits(utInfo.UTypeId);
                                                //如果该类别添加了子类别，不允许删除
                                                bool hasChilds = RequestStar.IsAddChilds(utInfo.UTypeId);
                                                if (!hasAddUnits && !hasChilds)
                                                {
                                                        typeIds.Add(utInfo.UTypeId);
                                                }
                                                else if (hasAddUnits)
                                                {
                                                        if (hasAddUnitsNames.Length > 0) hasAddUnitsNames += ",";
                                                        hasAddUnitsNames += utInfo.UTypeName;
                                                }
                                                else if (hasChilds)
                                                {
                                                        if (hasChildsNames.Length > 0) hasChildsNames += ",";
                                                        hasChildsNames += utInfo.UTypeName;
                                                }

                                        }
                                        if (typeIds.Count > 0)
                                        {
                                                bool bl = RequestStar.UnitTypeLogicDeleteList(typeIds);//执行批量删除
                                                string sucMsg = bl ? "成功" : "失败";
                                                string msg = $"选择的类别信息中符合删除要求的信息 删除 {sucMsg}!";

                                                if (bl)
                                                {
                                                        if (!string.IsNullOrEmpty(hasChildsNames))
                                                                msg += $" {hasChildsNames} 已经添加了子类别，不能删除！";
                                                        if (!string.IsNullOrEmpty(hasAddUnitsNames))
                                                                msg += $" {hasAddUnitsNames} 已经添加了单位，不能删除！";
                                                        MsgBoxHelper.MsgBoxShow(title, msg);
                                                        LoadUnitTypeList();
                                                        ReloadCboParents(typeIds);
                                                }
                                                else
                                                        MsgBoxHelper.MsgErrorShow(msg);
                                        }
                                        else
                                                MsgBoxHelper.MsgErrorShow("没有符合删除要求的商品类别信息！");
                                }
                        };
                        act.TryCatch("批量删除商品类别信息异常！");
                }

                /// <summary>
                /// 保存类别信息
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void btnSave_Click(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                //信息获取
                                int parentId = cboParents.SelectedValue.GetInt();
                                string parentName = parentId == 0 ? null : cboParents.Text.Trim();
                                string typeName = txtUTypeName.Text.Trim();
                                string typeNo = txtUTypeNo.Text.Trim();
                                string pyNo = txtUTPYNo.Text.Trim();
                                int utorder = txtUTOrder.Text.GetInt();

                                //判空处理
                                if (string.IsNullOrEmpty(typeName))
                                {
                                        MsgBoxHelper.MsgErrorShow("请输入往来单位类别名称！");
                                        txtUTypeName.Focus();
                                        return;
                                }
                                //判断已存在
                                if (uTypeId == 0 || (!string.IsNullOrEmpty(oldName) && oldName != typeName))
                                {
                                        if (RequestStar.ExistsUnitType(typeName))
                                        {
                                                MsgBoxHelper.MsgErrorShow("该类别名称已存在！");
                                                txtUTypeName.Focus();
                                                return;
                                        }
                                }

                                //信息封装
                                UnitTypeInfoModel utInfo = new UnitTypeInfoModel()
                                {
                                        UTypeId = uTypeId,
                                        UTypeName = typeName,
                                        UTypeNo = typeNo,
                                        UTPYNo = pyNo,
                                        UTOrder = utorder,
                                        ParentId = parentId,
                                        ParentName = parentName,
                                        Creator = uName
                                };

                                //方法执行
                                bool bl = false;
                                int uTypeIdNew = 0;
                                if (uTypeId == 0)//新增或添加子类
                                {
                                        uTypeIdNew = RequestStar.AddUnitType(utInfo);
                                        if (uTypeIdNew > 0)
                                        {
                                                bl = true;
                                                utInfo.UTypeId = uTypeIdNew;
                                        }
                                }
                                else
                                {
                                       if(CheckUnitTypeInfo(utInfo,oldInfo))
                                             bl = RequestStar.UpdateUnitType(utInfo, oldName);
                                       else
                                        {
                                                MsgBoxHelper.MsgErrorShow("没有要提交的信息！");
                                                return;
                                        }
                                }
                                string actType = uTypeId == 0 ? "添加" : "修改";
                                string sucType = bl ? "成功" : "失败";
                                string actMsg = $"往来单位类别信息:{typeName} {actType} {sucType}";
                                string msgTitle = $"{actType}往来单位类别";
                                if (bl)
                                {
                                        MsgBoxHelper.MsgBoxShow(msgTitle, actMsg);
                                        LoadUnitTypeList();
                                        ReloadCboParents(utInfo, false, 0);//刷新下拉框
                                }
                                else
                                {
                                        MsgBoxHelper.MsgErrorShow(actMsg);
                                        return;
                                }
                        };
                        act.TryCatch("保存类别信息异常！");
                }

                private void txtUTypeName_TextChanged(object sender, EventArgs e)
                {
                        txtUTPYNo.Text = PingYinHelper.GetFirstSpell(txtUTypeName.Text.Trim());
                }

                /// <summary>
                /// 检查类别信息是否发生改变
                /// </summary>
                /// <param name="utInfo"></param>
                /// <param name="oldutInfo"></param>
                /// <returns></returns>
                private bool CheckUnitTypeInfo(UnitTypeInfoModel utInfo,UnitTypeInfoModel oldutInfo)
                {
                        bool bl = false;

                        if ((utInfo.UTypeName != oldutInfo.UTypeName) || (utInfo.ParentId != oldutInfo.ParentId) || (utInfo.UTypeNo != oldutInfo.UTypeNo) || (utInfo.UTOrder != oldutInfo.UTOrder))
                                bl = true;
                        return bl;
                }
        }
}
