using PSI.BLL;
using PSI.Common;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPSI.BM
{
        public partial class FrmGoodsTypeList : Form
        {
                GoodsTypeBLL gtBLL = new GoodsTypeBLL();
                public FrmGoodsTypeList()
                {
                        InitializeComponent();
                }
                private string uName = "";
                private int gTypeId = 0;
                private string oldName = "";//存放修改前的类别名称
                private GoodsTypeInfoModel oldInfo = null;//修改前的信息
                public event Action ReloadTVGoodsTypes;
                private void FrmGoodsTypeList_Load(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                //1.获取登录名
                                if (this.Tag != null)
                                {
                                        uName = this.Tag.ToString();
                                }
                                //2.商品信息类别栏的显示 --隐藏
                                gbInfo.Visible = false;
                                //3.初始化上级类别下拉框 
                                InitCboParents();
                             
                                //4.加载所有商品类别信息
                                LoadGoodsTypeList();
                        };
                        act.TryCatch("商品类别管理页面初始化异常！");
                }

                /// <summary>
                /// 条件查询商品类别信息
                /// </summary>
                private void LoadGoodsTypeList()
                {
                        string keywords = txtKeywords.Text.Trim();
                        bool isShowDel = chkShowDel.Checked;
                        //设置数据表的操作列显示以及工具项的可用状态
                        SetColumnsAndToolBtns(isShowDel);
                        //获取数据
                        List<GoodsTypeInfoModel> typeList = gtBLL.LoadAllGoodsTypeList(keywords, isShowDel);
                        dgvGoodsTypeList.AutoGenerateColumns = false;
                        if (typeList.Count > 0)
                                dgvGoodsTypeList.DataSource = typeList;
                        else
                                dgvGoodsTypeList.DataSource = null;
                        dgvGoodsTypeList.AllowUserToAddRows = false;
                }

                /// <summary>
                /// 设置数据表的操作列显示以及工具项的可用状态
                /// </summary>
                /// <param name="isShowDel"></param>
                private void SetColumnsAndToolBtns(bool isShowDel)
                {
                        dgvGoodsTypeList.Columns["AddChilds"].Visible = !isShowDel;
                        dgvGoodsTypeList.Columns["Edit"].Visible = !isShowDel;
                        dgvGoodsTypeList.Columns["Del"].Visible = !isShowDel;
                        dgvGoodsTypeList.Columns["Recover"].Visible = isShowDel;
                        dgvGoodsTypeList.Columns["Remove"].Visible = isShowDel;
                        tsbtnAdd.Enabled = !isShowDel;
                        tsbtnEdit.Enabled = !isShowDel;
                        tsbtnDelete.Enabled = !isShowDel;
                }

                /// <summary>
                /// 初始化上级类别下拉框 
                /// </summary>
                private void InitCboParents()
                {
                        List<GoodsTypeInfoModel> typeList = gtBLL.LoadAllGoodsTypes();
                        typeList.Insert(0, new GoodsTypeInfoModel()
                        {
                                GTypeId = 0,
                                GTypeName = "请选择上级类别"
                        });
                        //指定数据源
                        cboParents.DisplayMember = "GTypeName";
                        cboParents.ValueMember = "GTypeId";
                        cboParents.DataSource = typeList;
                        cboParents.SelectedIndex = 0;
                }

                /// <summary>
                /// 新增类别信息
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
                        gTypeId = 0;
                        txtGTypeName.Clear();
                        txtGTypeNo.Clear();
                        txtGTPYNo.Clear();
                        txtGTOrder.Clear();
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
                private void ShowEditTypeInfo(GoodsTypeInfoModel gtInfo)
                {
                        if (gtInfo != null)
                        {
                                oldInfo = gtInfo;
                                gbInfo.Visible = true;
                                txtGTypeName.Text = gtInfo.GTypeName;
                                txtGTypeNo.Text = gtInfo.GTypeNo;
                                txtGTPYNo.Text = gtInfo.GTPYNo;
                                txtGTOrder.Text = gtInfo.GTOrder.ToString();
                                cboParents.SelectedValue = gtInfo.ParentId;
                                cboParents.Enabled = true;
                                btnSave.Text = "修改";
                                gTypeId = gtInfo.GTypeId;
                                oldName = gtInfo.GTypeName;
                        }
                }

                private void dgvGoodsTypeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                        Action act = () =>
                        {
                                if (e.RowIndex >= 0)
                                {
                                        var curCell = dgvGoodsTypeList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                        GoodsTypeInfoModel gtInfo = dgvGoodsTypeList.Rows[e.RowIndex].DataBoundItem as GoodsTypeInfoModel;
                                        string cellVal = curCell.FormattedValue.ToString();
                                        switch (cellVal)
                                        {
                                                case "添加子类别":
                                                        ShowAddTypeInfo(gtInfo.GTypeId);
                                                        break;
                                                case "修改":
                                                        ShowEditTypeInfo(gtInfo);
                                                        break;
                                                case "删除":
                                                        DeleteGType(1, gtInfo);
                                                        break;
                                                case "恢复":
                                                        DeleteGType(0, gtInfo);
                                                        break;
                                                case "永久删除":
                                                        DeleteGType(2, gtInfo);
                                                        break;
                                        }
                                }
                        };
                        act.TryCatch("操作商品类别数据异常！");
                }

                //isdeleted  1-LogicDelete  0  Recover  2 Delete
                private void DeleteGType(int isDeleted,GoodsTypeInfoModel gt)
                {
                        string delTypeName = FormUtility.GetDeleteTypeName(isDeleted);
                        string msgTitle = $"商品类别{delTypeName}";
                        if(MsgBoxHelper.MsgBoxConfirm(msgTitle,$"您确定要{delTypeName}该商品类别？")==DialogResult.Yes)
                        {
                                bool bl = false;
                                switch(isDeleted)
                                {
                                        case 1://删除
                                                //如果该类别添加了商品，不允许删除
                                                bool hasAddGoods = gtBLL.CheckIsAddGoods(gt.GTypeId);
                                                //如果该类别添加了子类别，不允许删除
                                                bool hasChilds = gtBLL.HasChildTypes(gt.GTypeId);
                                                if(!hasAddGoods&&!hasChilds)
                                                {
                                                        bl = gtBLL.LogicDelete(gt.GTypeId);
                                                }
                                                else if(hasAddGoods)
                                                {
                                                        MsgBoxHelper.MsgErrorShow($"该类别:{gt.GTypeName} 已经添加商品，不能删除！");
                                                        return;
                                                }
                                                else if(hasChilds)
                                                {
                                                        MsgBoxHelper.MsgErrorShow($"该类别:{gt.GTypeName} 已经添加了子类别，不能删除！");
                                                        return;
                                                }
                                                break;
                                        case 0://恢复
                                                bl = gtBLL.Recover(gt.GTypeId);
                                                break;
                                        case 2://移除
                                                bl = gtBLL.Delete(gt.GTypeId);
                                                break;
                                }
                                string sucType = bl ? "成功" : "失败";
                                string delMsg = $"商品类别:{gt.GTypeName} {delTypeName} {sucType}";
                                if (bl)
                                {
                                        MsgBoxHelper.MsgBoxShow(msgTitle, delMsg);
                                        LoadGoodsTypeList();
                                        if (isDeleted!=2)
                                        {
                                                ReloadCboParents(gt, true,isDeleted);
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
                /// 修改商品类别信息
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnEdit_Click(object sender, EventArgs e)
                {
                        if (dgvGoodsTypeList.CurrentRow != null)
                        {
                                GoodsTypeInfoModel gtInfo = dgvGoodsTypeList.CurrentRow.DataBoundItem as GoodsTypeInfoModel;
                                ShowEditTypeInfo(gtInfo);
                        }
                }

                /// <summary>
                /// 查询按钮
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void btnFind_Click(object sender, EventArgs e)
                {
                        LoadGoodsTypeList();
                }
                /// <summary>
                /// 显示已删除复选框响应
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void chkShowDel_CheckedChanged(object sender, EventArgs e)
                {
                        LoadGoodsTypeList();
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
                        LoadGoodsTypeList();
                }

                /// <summary>
                /// 提交功能
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
                                string typeName = txtGTypeName.Text.Trim();
                                string typeNo = txtGTypeNo.Text.Trim();
                                string pyNo = txtGTPYNo.Text.Trim();
                                int gorder = txtGTOrder.Text.GetInt();

                               //判空处理
                               if (string.IsNullOrEmpty(typeName))
                                {
                                        MsgBoxHelper.MsgErrorShow("请输入商品类别名称！");
                                        txtGTypeName.Focus();
                                        return;
                                }
                               //判断已存在
                               if (gTypeId == 0 || (!string.IsNullOrEmpty(oldName) && oldName != typeName))
                                {
                                        if (gtBLL.ExistName(typeName))
                                        {
                                                MsgBoxHelper.MsgErrorShow("该类别名称已存在！");
                                                txtGTypeName.Focus();
                                                return;
                                        }
                                }

                               //信息封装
                               GoodsTypeInfoModel gtInfo = new GoodsTypeInfoModel()
                                {
                                        GTypeId = gTypeId,
                                        GTypeName = typeName,
                                        GTypeNo = typeNo,
                                        GTPYNo = pyNo,
                                        GTOrder = gorder,
                                        ParentId = parentId,
                                        ParentName = parentName,
                                        Creator = uName
                                };

                               //方法执行
                               bool bl = false;
                                int gTypeIdNew = 0;
                                if (gTypeId == 0)
                                {
                                        gTypeIdNew = gtBLL.AddGoodsType(gtInfo);
                                        if (gTypeIdNew > 0)
                                        {
                                                bl = true;
                                                gtInfo.GTypeId = gTypeIdNew;
                                        }
                                }
                                else
                                {
                                        if(CheckGoodsTypeInfo(gtInfo,oldInfo))
                                                 bl = gtBLL.UpdateGoodsType(gtInfo, oldName);
                                        else
                                        {
                                                MsgBoxHelper.MsgErrorShow("没有要提交的信息");
                                                return;
                                        }
                                }
                                string actType = gTypeId == 0 ? "添加" : "修改";
                                string sucType = bl ? "成功" : "失败";
                                string actMsg = $"商品类别信息:{typeName} {actType} {sucType}";
                                string msgTitle = $"{actType}商品类别";
                                if (bl)
                                {
                                        MsgBoxHelper.MsgBoxShow(msgTitle, actMsg);
                                        LoadGoodsTypeList();
                                        ReloadCboParents(gtInfo,false,0);//刷新下拉框
                               }
                                else
                                {
                                        MsgBoxHelper.MsgErrorShow(actMsg);
                                        return;
                                }
                        };
                        act.TryCatch("保存类别信息异常！");
                }

                /// <summary>
                /// 检查类别信息是否发生改变
                /// </summary>
                /// <param name="utInfo"></param>
                /// <param name="oldutInfo"></param>
                /// <returns></returns>
                private bool CheckGoodsTypeInfo(GoodsTypeInfoModel gtInfo, GoodsTypeInfoModel oldgtInfo)
                {
                        bool bl = false;

                        if ((gtInfo.GTypeName != gtInfo.GTypeName) || (gtInfo.ParentId != gtInfo.ParentId) || (gtInfo.GTypeNo != gtInfo.GTypeNo) || (gtInfo.GTOrder != gtInfo.GTOrder))
                                bl = true;
                        return bl;
                }

                /// <summary>
                /// 刷新下拉框
                /// </summary>
                /// <param name="gt"></param>
                private void ReloadCboParents(GoodsTypeInfoModel gt,bool isDel,int isDeleted)
                {
                        List<GoodsTypeInfoModel> parents = cboParents.DataSource as List<GoodsTypeInfoModel>;
                        //清空数据源（cbo DataSource）
                        cboParents.DataSource = null;
                        if(!isDel)
                        {
                                if (gTypeId > 0 && oldName != gt.GTypeName)//修改提交时，类别名称信息发生改变
                                {
                                        parents.Where(t => t.GTypeName == oldName).FirstOrDefault().GTypeName = gt.GTypeName;
                                }
                                else if (gTypeId == 0) //新增或添加子类别
                                {
                                        parents.Add(new GoodsTypeInfoModel()
                                        {
                                                GTypeId = gt.GTypeId,
                                                GTypeName = gt.GTypeName
                                        });
                                }
                        }
                        else
                        {
                                if (isDeleted == 1)
                                        parents.Remove(parents.Where(t => t.GTypeId == gt.GTypeId).FirstOrDefault());
                                else
                                        parents.Add(new GoodsTypeInfoModel()
                                        {
                                                GTypeId = gt.GTypeId,
                                                GTypeName = gt.GTypeName
                                        });
                        }
                        cboParents.DisplayMember = "GTypeName";
                        cboParents.ValueMember = "GTypeId";
                        cboParents.DataSource = parents;
                        cboParents.SelectedValue = gt.ParentId;
                }

                /// <summary>
                /// 拼音码的获取
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void txtGTypeName_TextChanged(object sender, EventArgs e)
                {
                        txtGTPYNo.Text = PingYinHelper.GetFirstSpell(txtGTypeName.Text.Trim());
                }

                /// <summary>
                /// 批量删除（逻辑删除）
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnDelete_Click(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                //SelectedRows 选定行的集合（MultiSelect True ）  多个行
                                if (dgvGoodsTypeList.SelectedRows.Count == 0)
                                {
                                        MsgBoxHelper.MsgErrorShow("请选择要删除的商品类别信息");
                                        return;
                                }
                                string title = "删除商品类别";
                                if (MsgBoxHelper.MsgBoxConfirm(title, "您确定要删除选择的这些商品类别信息吗？") == DialogResult.Yes)
                                {
                                        List<int> typeIds = new List<int>();
                                        string hasChildsNames = "";
                                        string hasAddGoodsNames = "";
                                        foreach (DataGridViewRow row in dgvGoodsTypeList.SelectedRows)
                                        {
                                                GoodsTypeInfoModel gtInfo = row.DataBoundItem as GoodsTypeInfoModel;
                                                //如果该类别添加了商品，不允许删除
                                                bool hasAddGoods = gtBLL.CheckIsAddGoods(gtInfo.GTypeId);
                                                //如果该类别添加了子类别，不允许删除
                                                bool hasChilds = gtBLL.HasChildTypes(gtInfo.GTypeId);
                                                if (!hasAddGoods && !hasChilds)
                                                {
                                                        typeIds.Add(gtInfo.GTypeId);
                                                }
                                                else if (hasAddGoods)
                                                {
                                                        //MsgBoxHelper.MsgErrorShow($"该类别:{gtInfo.GTypeName} 已经添加商品，不能删除！");
                                                        if (hasAddGoodsNames.Length > 0) hasAddGoodsNames += ",";
                                                        hasAddGoodsNames += gtInfo.GTypeName;
                                                }
                                                else if (hasChilds)
                                                {
                                                        //MsgBoxHelper.MsgErrorShow($"该类别:{gtInfo.GTypeName} 已经添加了子类别，不能删除！");
                                                        //return;
                                                        if (hasChildsNames.Length > 0) hasChildsNames += ",";
                                                        hasChildsNames += gtInfo.GTypeName;
                                                }
                                              
                                        }
                                        if(typeIds.Count >0)
                                        {
                                                bool bl = gtBLL.LogicDeleteList(typeIds);//执行批量删除
                                                string sucMsg = bl ? "成功" : "失败";
                                                string msg = $"选择的类别信息中符合删除要求的信息 删除 {sucMsg}!";

                                                if (bl)
                                                {
                                                        if (!string.IsNullOrEmpty(hasChildsNames))
                                                                msg += $" {hasChildsNames} 已经添加了子类别，不能删除！";
                                                        if (!string.IsNullOrEmpty(hasAddGoodsNames))
                                                                msg += $" {hasAddGoodsNames} 已经添加商品，不能删除！";
                                                        MsgBoxHelper.MsgBoxShow(title, msg);
                                                        LoadGoodsTypeList();
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

                private void ReloadCboParents(List<int> typeIds)
                {
                        List<GoodsTypeInfoModel> parents = cboParents.DataSource as List<GoodsTypeInfoModel>;
                        //清空数据源（cbo DataSource）
                        cboParents.DataSource = null;
                        parents.Where(t => typeIds.Contains(t.GTypeId)).ToList().ForEach(t => parents.Remove(t));
                        cboParents.DisplayMember = "GTypeName";
                        cboParents.ValueMember = "GTypeId";
                        cboParents.DataSource = parents;

                }

                private void tsbtnClose_Click(object sender, EventArgs e)
                {
                        this.ReloadTVGoodsTypes?.Invoke();
                        this.CloseForm();
                    
                }
        }
}
