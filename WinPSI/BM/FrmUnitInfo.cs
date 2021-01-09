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
        public partial class FrmUnitInfo : Form
        {
                public FrmUnitInfo()
                {
                        InitializeComponent();
                } 
                private RegionBLL regionBLL = new RegionBLL(); 
                public event Action ReLoadHandler;//刷新列表页事件
                private FInfoModel fModel = null;
                private string oldName = "";//修改前的单位名称
                public UnitTypeInfoModel uType = null;//单位类别实体
                private int oldTypeId = 0;//修改前的类别编号
                private void FrmUnitInfo_Load(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                if (this.Tag != null)
                                {
                                        fModel = this.Tag as FInfoModel;
                                }
                                if (fModel == null)
                                {
                                        MsgBoxHelper.MsgErrorShow("单位信息初始化失败！");
                                        return;
                                }
                                InitUnitProperties();//加载单位性质列表
                                txtNation.Text =regionBLL.GetRegion(1).RegionName;
                                InitProvinces();//加载所有的省区域列表
                                string lblTitleType = "";
                                switch (fModel.ActType)
                                {
                                        case 1:
                                                ClearInfo();
                                                lblTitleType = "新增";
                                                break;
                                        case 2:
                                                InitUnitInfo(fModel.FId);
                                                tsbtnClear.Enabled = false;
                                                lblTitleType = "修改";
                                                break;
                                        case 4:
                                                InitUnitInfo(fModel.FId);
                                                tsbtnClear.Enabled = false;
                                                tsbtnSave.Enabled = false;
                                                lblTitleType = "详情";
                                                break;
                                        default: break;
                                }
                                lblDesp.Text = $"单位信息{lblTitleType}页面";
                        };
                        act.TryCatch("单位信息页面初始化异常！");
                }

                /// <summary>
                /// 加载指定的单位信息
                /// </summary>
                /// <param name="fId"></param>
                private void InitUnitInfo(int unitId)
                {
                        UnitInfoModel unitInfo = RequestStar.GetUnitInfo(unitId);
                        if(unitInfo!=null)
                        {
                                //将信息加载到信息框
                                txtUnitName.Text  = unitInfo.UnitName;
                                oldName = unitInfo.UnitName;
                                txtUnitNo.Text = unitInfo.UnitNo;
                                txtUnitPYNo.Text = unitInfo.UnitPYNo;
                                txtUnitType.Text = RequestStar.GetUnitType(unitInfo.UTypeId).UTypeName;
                                uType = new UnitTypeInfoModel()
                                {
                                        UTypeId = unitInfo.UTypeId,
                                        UTypeName = txtUnitType.Text
                                };
                                oldTypeId = unitInfo.UTypeId;
                                cboUnitProperties.Text = unitInfo.UnitProperties;
                                int regionId = unitInfo.RegionId;
                                SetRegion(regionId);//区域信息加载
                                txtAddress.Text = unitInfo.Address;
                                txtRemark.Text = unitInfo.Address;
                                txtContactPerson.Text = unitInfo.ContactPerson;
                                txtPhoneNumber.Text = unitInfo.PhoneNumber;
                                txtEmail.Text = unitInfo.Email;
                                txtFax.Text = unitInfo.Fax;
                                txtTelephone.Text = unitInfo.Telephone;
                                txtPostalCode.Text = unitInfo.PostalCode;
                        }
                }

                /// <summary>
                /// 初始化区域信息(三个下拉框)
                /// </summary>
                /// <param name="regionId"></param>
                private void SetRegion(int regionId)
                {
                        RegionInfoModel region = regionBLL.GetRegion(regionId);
                        if(region !=null )
                        {
                                switch(region.RegionLevel)
                                {
                                        case 1:
                                                cboProvinces.SelectedValue = regionId;
                                                cboCitys.SelectedValue = 0;
                                                cboCountries.SelectedValue = 0;
                                                break;
                                        case 2:
                                                cboProvinces.SelectedValue = region.ParentId;
                                                cboCitys.SelectedValue = regionId;
                                                cboCountries.SelectedValue = 0;
                                                break;
                                        case 3:
                                                RegionInfoModel cityRegion = regionBLL.GetRegion(region.ParentId);
                                                cboProvinces.SelectedValue =cityRegion.ParentId;
                                                cboCitys.SelectedValue = region.ParentId;
                                                cboCountries.SelectedValue =regionId;
                                                break;
                                        default:break;
                                }
                        }
                }

                /// <summary>
                /// 清空
                /// </summary>
                private void ClearInfo()
                {
                        foreach (TabPage page in tcUnit.TabPages)
                        {
                                foreach(Control c in page.Controls)
                                {
                                        if (c is TextBox)
                                        {
                                                TextBox txt = c as TextBox;
                                                if(txt.Name!="txtNation")
                                                         txt.Clear();
                                        }
                                }  
                        }
                        uType = new UnitTypeInfoModel();
                        cboProvinces.SelectedIndex = 0;
                        cboUnitProperties.SelectedIndex = 0;
                }

                /// <summary>
                /// 加载省列表下拉框
                /// </summary>
                private void InitProvinces()
                {
                        List<RegionInfoModel> provinces = regionBLL.GetProvinces();
                        provinces.Insert(0,new RegionInfoModel()
                        {
                                RegionId = 0,
                                RegionName = ""
                        });
                        cboProvinces.DisplayMember = "RegionName";
                        cboProvinces.ValueMember = "RegionId";
                        cboProvinces.DataSource = provinces;
                        cboProvinces.SelectedIndex = 0;
                        //InitCities();//加载市列表下拉框
                        //InitCountries();//加载区/县下拉框
                }


                private void InitCountries()
                {
                        List<RegionInfoModel> countries = regionBLL.GetCountries(cboCitys.SelectedValue.GetInt());
                        countries.Insert(0,new RegionInfoModel()
                        {
                                RegionId = 0,
                                RegionName = ""
                        });
                        cboCountries.DisplayMember = "RegionName";
                        cboCountries.ValueMember = "RegionId";
                        cboCountries.DataSource = countries;
                        cboCountries.SelectedIndex = 0;
                }

                private void InitCities()
                {
                        List<RegionInfoModel> cities = regionBLL.GetCities(cboProvinces.SelectedValue.GetInt());
                        cities.Insert(0,new RegionInfoModel()
                        {
                                RegionId = 0,
                                RegionName = ""
                        });
                        cboCitys.DisplayMember = "RegionName";
                       cboCitys.ValueMember = "RegionId";
                       cboCitys.DataSource = cities;
                        cboCitys.SelectedIndex = 0;
                }

                /// <summary>
                /// 加载单位性质下拉框
                /// </summary>
                private void InitUnitProperties()
                {
                        List<string> list = new List<string>() { "供应商", "客户", "供应商既客户" };
                        cboUnitProperties.DataSource = list;
                        cboUnitProperties.SelectedIndex = 0;
                }

                private void cboProvinces_SelectedIndexChanged(object sender, EventArgs e)
                {
                        InitCities();
                }

                private void cboCitys_SelectedIndexChanged(object sender, EventArgs e)
                {
                        InitCountries();
                }

                /// <summary>
                /// 打开单位类别选择页面
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void picUType_Click(object sender, EventArgs e)
                {
                        FrmChooseTypes fChooseTypes = new FrmChooseTypes();
                        fChooseTypes.Tag = new ChooseModel()
                        {
                                TypeCode = "Units",
                                FGet = this
                        };
                        fChooseTypes.SetType += () =>
                        {
                                txtUnitType.Text = uType.UTypeName;
                        };
                        fChooseTypes.ShowDialog();
                }

                /// <summary>
                /// 单位信息提交
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tsbtnSave_Click(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                              //信息获取
                              string unitName = txtUnitName.Text.Trim();
                                string unitNo = txtUnitNo.Text.Trim();
                                string unitPYNo = txtUnitPYNo.Text.Trim();
                                int uTypeId = uType.UTypeId;
                                string unitProperties = cboUnitProperties.Text;
                                int regionId = 0;
                                if (cboCountries.SelectedValue != null || cboCountries.SelectedValue.ToString() != "0")
                                        regionId = cboCountries.SelectedValue.GetInt();
                                else if (cboCitys.SelectedValue != null || cboCitys.SelectedValue.ToString() != "0")
                                        regionId = cboCitys.SelectedValue.GetInt();
                                else if (cboProvinces.SelectedValue != null || cboProvinces.SelectedValue.ToString() != "0")
                                        regionId = cboProvinces.SelectedValue.GetInt();
                                string address = txtAddress.Text.Trim();
                              //包括选择的区域+详细地址
                              string fullAddress = regionBLL.GetRegionAddress(regionId) + address;
                                string remark = txtRemark.Text.Trim();
                                string contactPerson = txtContactPerson.Text.Trim();
                                string email = txtEmail.Text.Trim();
                                string fax = txtFax.Text.Trim();
                                string pcode = txtPostalCode.Text.Trim();
                                string phoneNumber = txtPhoneNumber.Text.Trim();
                                string telephone = txtTelephone.Text.Trim();
                              //判断
                              if (string.IsNullOrEmpty(unitName))
                                {
                                        MsgBoxHelper.MsgErrorShow("请输入单位名称");
                                        txtUnitName.Focus();
                                        return;
                                }
                              //判断是否已存在
                              if (fModel.ActType == 1 || (!string.IsNullOrEmpty(oldName) && oldName != unitName)||(!string.IsNullOrEmpty(oldName) && oldName == unitName&&(uTypeId!=oldTypeId)))
                                {
                                        if (RequestStar.ExistUnit(unitName, uTypeId))
                                        {
                                                MsgBoxHelper.MsgErrorShow("该单位已存在！");
                                                txtUnitName.Focus();
                                                return;
                                        }
                                }
                                if (uTypeId == 0)
                                {
                                        MsgBoxHelper.MsgErrorShow("请选择单位类别！");
                                        txtUnitType.Focus();
                                        return;
                                }
                              //信息的封装
                              UnitInfoModel unitInfo = new UnitInfoModel()
                                {
                                        UnitId = fModel.FId,
                                        UnitName = unitName,
                                        UnitNo = unitNo,
                                        UnitPYNo = unitPYNo,
                                        UnitProperties = unitProperties,
                                        UTypeId = uTypeId,
                                        RegionId = regionId,
                                        Address = address,
                                        FullAddress = fullAddress,
                                        Remark = remark,
                                        ContactPerson = contactPerson,
                                        Email = email,
                                        Fax = fax,
                                        Telephone = telephone,
                                        PhoneNumber = phoneNumber,
                                        PostalCode = pcode,
                                        Creator = fModel.UName
                                };
                              //调用方法
                              bool bl = false;
                                bl = fModel.ActType == 1 ? RequestStar.AddUnitInfo(unitInfo) : RequestStar.UpdateUnitInfo(unitInfo);
                                string actMsg = fModel.ActType == 1 ? "添加" : "修改";
                                string titleMsg = $"{actMsg}单位信息";
                                string sucType = bl ? "成功" : "失败";
                                string msg = $"单位信息{actMsg} {sucType}";
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
                        act.TryCatch("单位信息提交出现异常");
                }

                private void tsbtnClear_Click(object sender, EventArgs e)
                {
                        ClearInfo();
                }

                private void tsbtnClose_Click(object sender, EventArgs e)
                {
                        this.CloseForm();
                }
                /// <summary>
                /// 拼音码的生成
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void txtUnitName_TextChanged(object sender, EventArgs e)
                {
                        txtUnitPYNo.Text = PingYinHelper.GetFirstSpell(txtUnitName.Text.Trim());
                }

                private void txtUnitType_TextChanged(object sender, EventArgs e)
                {
                        txtUnitType.Text = RequestStar.GetUTypeNameByKeywords(txtUnitType.Text.Trim());
                }
        }
}
