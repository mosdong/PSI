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
        public partial class FrmStoreInfo : Form
        {
                public FrmStoreInfo()
                {
                        InitializeComponent();
                } 
                StoreTypeBLL stBLL = new StoreTypeBLL();
                public event Action ReLoadHandler;//刷新列表页
                private FInfoModel fModel = null;//页面传值的信息实体
                string oldName = "";//当前编辑前的仓库名称
                int oldTypeId = 0;//当前编辑前的仓库类别编号 
                private void FrmStoreInfo_Load(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                if (this.Tag != null)
                                {
                                        fModel = this.Tag as FInfoModel;
                                }
                                if (fModel == null)
                                {
                                        MsgBoxHelper.MsgErrorShow("仓库信息初始化失败！");
                                        return;
                                }
                                InitDrpStoreTypes();//加载仓库类别下拉框
                                string lblTitleType = "";
                                switch (fModel.ActType)
                                {
                                        case 1:
                                                ClearInfo();
                                                lblTitleType = "新增";
                                                break;
                                        case 2:
                                                InitStoreInfo(fModel.FId);
                                                tsbtnClear.Enabled = false;
                                                lblTitleType = "修改";
                                                break;
                                        case 4:
                                                InitStoreInfo(fModel.FId);
                                                tsbtnClear.Enabled = false;
                                                tsbtnSave.Enabled = false;
                                                lblTitleType = "详情";
                                                break;
                                        default: break;
                                }
                                lblDesp.Text = $"仓库信息{lblTitleType}页面";
                        };
                        act.TryCatch("仓库信息页面初始化异常！");
                }

                /// <summary>
                /// 加载仓库信息
                /// </summary>
                /// <param name="fId"></param>
                private void InitStoreInfo(int storeId)
                {
                        StoreInfoModel storeInfo = RequestStar.GetStoreInfo(storeId);
                        if(storeInfo!=null)
                        {
                                txtStoreName.Text = storeInfo.StoreName;
                                oldName = storeInfo.StoreName;
                                txtStoreNo.Text = storeInfo.StoreNo;
                                txtStorePYNo.Text = storeInfo.StorePYNo;
                                txtStoreOrder.Text = storeInfo.StoreOrder.ToString();
                                txtRemark.Text = storeInfo.StoreRemark;
                                cboSTypes.SelectedValue = storeInfo.STypeId;
                                oldTypeId = storeInfo.STypeId;
                        }
                }

                /// <summary>
                /// 清空信息
                /// </summary>
                private void ClearInfo()
                {
                        foreach (Control c in panelInfo.Controls)
                        {
                                if (c is TextBox)
                                {
                                        TextBox txt = c as TextBox;
                                        txt.Clear();
                                }
                        }
                        cboSTypes.SelectedIndex = 0;
                }

                /// <summary>
                /// 加载类别下拉框
                /// </summary>
                private void InitDrpStoreTypes()
                {
                        List<StoreTypeInfoModel> typeList = stBLL.LoadAllDrpStoreTypes();
                        typeList.Insert(0, new StoreTypeInfoModel()
                        {
                                STypeId = 0,
                                STypeName = "请选择仓库类别"
                        });
                        cboSTypes.DisplayMember = "STypeName";
                        cboSTypes.ValueMember = "STypeId";
                        cboSTypes.DataSource = typeList;
                        cboSTypes.SelectedIndex = 0;
                }

                private void picList_Click(object sender, EventArgs e)
                {
                        FrmStoreTypeList fStoreTypeList = new FrmStoreTypeList();
                        fStoreTypeList.Tag = fModel.UName;
                        fStoreTypeList.TVStoreTypeReload += InitDrpStoreTypes;//刷新类别下拉框
                        fStoreTypeList.ShowDialog();
                }

                /// <summary>
                /// 清空
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnClear_Click(object sender, EventArgs e)
                {
                        ClearInfo();
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
                /// 仓库信息的提交
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnSave_Click(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                //信息获取
                                string storeName = txtStoreName.Text.Trim();
                                string storeNo = txtStoreNo.Text.Trim();
                                string storePYNo = txtStorePYNo.Text.Trim();
                                int sTypeId =cboSTypes.SelectedValue!=null? cboSTypes.SelectedValue.GetInt():0;
                                string remark = txtRemark.Text.Trim();
                                int order = txtStoreOrder.Text.GetInt();
                                //判断
                                if (string.IsNullOrEmpty(storeName))
                                {
                                        MsgBoxHelper.MsgErrorShow("请输入仓库名称");
                                        txtStoreName.Focus();
                                        return;
                                }
                                //判断是否已存在
                                if (fModel.ActType == 1 || (!string.IsNullOrEmpty(oldName) && oldName != storeName)||(!string.IsNullOrEmpty(oldName)&&(oldName ==storeName)&&(oldTypeId !=sTypeId)))
                                {
                                        if (RequestStar.ExistsStore(storeName, sTypeId))
                                        {
                                                MsgBoxHelper.MsgErrorShow("该仓库已存在！");
                                                txtStoreName.Focus();
                                                return;
                                        }
                                }
                                if (sTypeId == 0)
                                {
                                        MsgBoxHelper.MsgErrorShow("请选择仓库类别！");
                                        cboSTypes.Focus();
                                        return;
                                }
                                //信息的封装
                                StoreInfoModel storeInfo = new StoreInfoModel()
                                {
                                        StoreId = fModel.FId,
                                        StoreName = storeName,
                                        StoreNo = storeNo,
                                        StorePYNo = storePYNo,
                                        STypeId = sTypeId,
                                        StoreRemark = remark,
                                        StoreOrder=order,
                                        Creator = fModel.UName
                                };
                                //调用方法
                                bool bl = false;
                                bl = fModel.ActType == 1 ? RequestStar.AddStoreInfo(storeInfo) : RequestStar.UpdateStoreInfo(storeInfo);
                                string actMsg = fModel.ActType == 1 ? "添加" : "修改";
                                string titleMsg = $"{actMsg}仓库信息";
                                string sucType = bl ? "成功" : "失败";
                                string msg = $"仓库信息{actMsg} {sucType}";
                                if (bl)
                                {
                                        MsgBoxHelper.MsgBoxShow(titleMsg, msg);
                                        this.ReLoadHandler?.Invoke();
                                }
                                else
                                {
                                        MsgBoxHelper.MsgErrorShow(msg);
                                        return;
                                }
                        };
                        act.TryCatch("仓库信息提交出现异常");
                }

                /// <summary>
                /// 生成拼音码
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void txtStoreName_TextChanged(object sender, EventArgs e)
                {
                        txtStorePYNo.Text = PingYinHelper.GetFirstSpell(txtStoreName.Text.Trim());
                }
        }
}
