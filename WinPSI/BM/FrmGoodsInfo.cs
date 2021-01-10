using PSI.Common;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Request;

namespace WinPSI.BM
{
    public partial class FrmGoodsInfo : Form
    {
        public FrmGoodsInfo()
        {
            InitializeComponent();
        } 
         
        //刷新列表页数据事件
        public event Action ReLoadHandler;
        private FInfoModel fModel = null;
        private string oldName = "";//当前编辑前的商品名称
        public GoodsTypeInfoModel gTypeInfo = null;
        private string oldPic = "";//修改前的图片路径
        private void FrmGoodsInfo_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (this.Tag != null)
                {
                    fModel = this.Tag as FInfoModel;
                }
                if (fModel == null)
                {
                    MsgBoxHelper.MsgErrorShow("商品信息初始化失败！");
                    return;
                }
                InitDrpGUnits();//加载单位下拉框（计量单位）
                            InitDrpGoodsProperties();//加载商品性质下拉框
                            string lblTitleType = "";
                switch (fModel.ActType)
                {
                    case 1:
                        ClearInfo();
                        lblTitleType = "新增";
                        break;
                    case 2:
                        InitGoodsInfo(fModel.FId);
                        tsbtnClear.Enabled = false;
                        lblTitleType = "修改";
                        break;
                    case 4:
                        InitGoodsInfo(fModel.FId);
                        tsbtnClear.Enabled = false;
                        tsbtnSave.Enabled = false;
                        lblTitleType = "详情";
                        break;
                    default: break;
                }
                lblDesp.Text = $"商品信息{lblTitleType}页面";
            };
            act.TryCatch("商品信息页面初始化异常！");

        }

        /// <summary>
        /// 加载商品信息
        /// </summary>
        /// <param name="fId"></param>
        private void InitGoodsInfo(int goodsId)
        {
            GoodsInfoModel goodsInfo = RequestStar.GetGoodsInfo(goodsId);
            if (goodsInfo != null)
            {
                txtBidPrice.Text = goodsInfo.BidPrice.ToString();
                txtDiscount.Text = goodsInfo.Discount.ToString();
                txtGoodsName.Text = goodsInfo.GoodsName;
                oldName = goodsInfo.GoodsName;
                txtGoodsNo.Text = goodsInfo.GoodsNo;
                txtGoodsPYNo.Text = goodsInfo.GoodsPYNo;
                txtGoodsSName.Text = goodsInfo.GoodsSName;
                string gtypeName = RequestStar.GetGoodsType(goodsInfo.GTypeId).GTypeName;
                txtGoodsType.Text = gtypeName;
                gTypeInfo = new GoodsTypeInfoModel()
                {
                    GTypeId = goodsInfo.GTypeId,
                    GTypeName = gtypeName
                };
                txtGoodTXNo.Text = goodsInfo.GoodsTXNo;
                txtLowPrice.Text = goodsInfo.LowPrice.ToString();
                txtPrePrice.Text = goodsInfo.PrePrice.ToString();
                txtRemark.Text = goodsInfo.Remark;
                txtRetailPrice.Text = goodsInfo.RetailPrice.ToString();
                if (goodsInfo.IsStopped == 1)
                    chkStop.Checked = true;
                cboGoodsProperties.Text = goodsInfo.GProperties;
                cboGUnits.Text = goodsInfo.GUnit;
                if (!string.IsNullOrEmpty(goodsInfo.GoodsPic))
                {
                    string picPath = Application.StartupPath + "/" + goodsInfo.GoodsPic;
                    picGoods.ImageLocation = picPath;
                    oldPic = picPath;
                }

            }
        }

        /// <summary>
        /// 计量单位下拉框加载
        /// </summary>
        private void InitDrpGUnits()
        {
            List<GoodsUnitInfoModel> list = RequestStar.GetAllUnits(0);
            cboGUnits.DisplayMember = "GUnitName";
            cboGUnits.ValueMember = "GUnitId";
            cboGUnits.DataSource = list;
            cboGUnits.SelectedIndex = 0;
        }

        /// <summary>
        /// 商品性质下拉框加载
        /// </summary>
        private void InitDrpGoodsProperties()
        {
            List<string> list = new List<string>() { "商品", "商品(服务)", "商品(无成本)" };
            cboGoodsProperties.DataSource = list;
            cboGoodsProperties.SelectedIndex = 0;
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
            cboGoodsProperties.SelectedIndex = 0;
            cboGUnits.SelectedIndex = 0;
            picGoods.ImageLocation = "";
            chkStop.Checked = false;
        }

        /// <summary>
        /// 显示类别选择页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void typeList_Click(object sender, EventArgs e)
        {
            FrmChooseTypes fCTypes = new FrmChooseTypes();
            fCTypes.Tag = new ChooseModel()
            {
                TypeCode = "Goods",
                FGet = this
            };
            fCTypes.SetType += FCTypes_SetType;
            fCTypes.ShowDialog();
        }

        /// <summary>
        /// 将选择的类别名称显示在类别文本框中
        /// </summary>
        private void FCTypes_SetType()
        {
            txtGoodsType.Text = gTypeInfo.GTypeName;
        }

        /// <summary>
        /// 打开单位管理页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unitList_Click(object sender, EventArgs e)
        {
            //刷新下拉框
            FrmGUnitList fGUnitList = new FrmGUnitList();
            //uName  刷新的委托--old     不需要
            fGUnitList.Tag = fModel.UName;
            fGUnitList.GUnitsReLoad += InitDrpGUnits;
            fGUnitList.ShowDialog();
        }


        private void btnPicChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdialog = new OpenFileDialog();
            // ofdialog.Filter = "(*.jpg,*.png,*.bmp.*.jpeg)|*.jpg;*.png;*.bmp;*.jpeg";
            //可以选择的图片类型
            ofdialog.Filter = "jpg 图片(*.jpg)|*.jpg|png图片(*.png)|*.png|bmp图片(*.bmp)|*.bmp|jpeg图片(*.jpeg)|*.jpeg";
            if (ofdialog.ShowDialog() == DialogResult.OK)
            {
                string path = ofdialog.FileName;
                picGoods.ImageLocation = path;
            }
        }

        /// <summary>
        /// 保存按钮提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnSave_Click(object sender, EventArgs e)
        {

            Action act = () =>
            {
                            //获取信息
                            string goodsName = txtGoodsName.Text.Trim();
                string goodsNo = txtGoodsNo.Text.Trim();
                string goodsPYNo = txtGoodsPYNo.Text.Trim();
                int gTypeId = gTypeInfo == null ? 0 : gTypeInfo.GTypeId;
                string goodsProperties = cboGoodsProperties.Text;
                string goodsSName = txtGoodsSName.Text.Trim();
                string goodsTXNo = txtGoodTXNo.Text.Trim();
                string gUnit = cboGUnits.Text.Trim();
                decimal rPrice = txtRetailPrice.Text.Trim().GetDecimal();
                decimal lPrice = txtLowPrice.Text.Trim().GetDecimal();
                decimal pPrice = txtPrePrice.Text.Trim().GetDecimal();
                decimal bPrice = txtBidPrice.Text.Trim().GetDecimal();
                int disCount = txtDiscount.Text.Trim().GetInt();
                if (disCount == 0)
                    disCount = 100;
                string remark = txtRemark.Text.Trim();
                string goodsPic = null;
                if (!string.IsNullOrEmpty(picGoods.ImageLocation))
                {
                    goodsPic = GetImgPath();
                }
                int isStopped = chkStop.Checked ? 1 : 0;
                            //判断
                            if (string.IsNullOrEmpty(goodsName))
                {
                    MsgBoxHelper.MsgErrorShow("请输入商品名称");
                    txtGoodsName.Focus();
                    return;
                }
                else if (fModel.ActType == 1 || (!string.IsNullOrEmpty(oldName) && oldName != goodsName))
                {
                    if (RequestStar.ExistGoodsName(goodsName))
                    {
                        MsgBoxHelper.MsgErrorShow("商品名称已存在！");
                        txtGoodsName.Focus();
                        return;
                    }
                }
                if (gTypeId == 0)
                {
                    MsgBoxHelper.MsgErrorShow("请选择商品类别！");
                    return;
                }
                            //封装商品信息
                            GoodsInfoModel goodsInfo = new GoodsInfoModel()
                {
                    GoodsId = fModel.FId,
                    GoodsName = goodsName,
                    GoodsNo = goodsNo,
                    GoodsPYNo = goodsPYNo,
                    GProperties = goodsProperties,
                    GTypeId = gTypeId,
                    GoodsTXNo = goodsTXNo,
                    GoodsSName = goodsSName,
                    Remark = remark,
                    GUnit = gUnit,
                    RetailPrice = rPrice,
                    LowPrice = lPrice,
                    PrePrice = pPrice,
                    BidPrice = bPrice,
                    Discount = disCount,
                    GoodsPic = goodsPic,
                    IsStopped = isStopped,
                    Creator = fModel.UName
                };
                            //执行
                            bool bl = false;
                bl = fModel.ActType == 1 ? RequestStar.AddGoodsInfo(goodsInfo) : RequestStar.UpdateGoodsInfo(goodsInfo);
                string actMsg = fModel.ActType == 1 ? "添加" : "修改";
                string titleMsg = $"{actMsg}商品信息";
                string sucType = bl ? "成功" : "失败";
                string msg = $"商品信息{actMsg} {sucType}";
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
            act.TryCatch("商品信息提交异常！");

        }

        /// <summary>
        /// 获取图片路径
        /// </summary>
        /// <returns></returns>
        private string GetImgPath()
        {
            string dict = "Imgs/products";
            if (!string.IsNullOrEmpty(picGoods.ImageLocation))
            {
                if (string.IsNullOrEmpty(oldPic) || fModel.ActType == 1 || (!string.IsNullOrEmpty(oldPic) && oldPic != picGoods.ImageLocation))
                {
                    //将图片保存到项目文件夹：Imgs/products/
                    if (!Directory.Exists(dict))
                        Directory.CreateDirectory(dict);
                    //扩展名
                    string ext = Path.GetExtension(picGoods.ImageLocation);
                    //生成文件名
                    string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ext;
                    string savePath = dict + "/" + fileName;
                    //保存到数据里的路径
                    if (!File.Exists(savePath))
                        File.Copy(picGoods.ImageLocation, Application.StartupPath + "/" + savePath);
                    if (!string.IsNullOrEmpty(oldPic) && oldPic != picGoods.ImageLocation)
                    {
                        File.Delete(Application.StartupPath + "/" + oldPic);
                    }
                    return dict + "/" + fileName;

                }
                else if (!string.IsNullOrEmpty(oldPic) && oldPic == picGoods.ImageLocation)
                {
                    return oldPic;
                }

            }
            return null;
        }

        /// <summary>
        /// 拼音码获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGoodsName_TextChanged(object sender, EventArgs e)
        {
            txtGoodsPYNo.Text = PingYinHelper.GetFirstSpell(txtGoodsName.Text.Trim());
        }

        private void tsbtnClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }
    }
}
