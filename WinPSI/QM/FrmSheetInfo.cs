using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Request;

namespace WinPSI.QM
{
    public partial class FrmSheetInfo : Form
    {
        public FrmSheetInfo()
        {
            InitializeComponent();
        }
        ShInfoModel sModel = null; 
        /// <summary>
        /// 页面加载 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSheetInfo_Load(object sender, EventArgs e)
        {
            //显示  单据类型   供应商/客户/仓库/商品名称       明细数据加载 
            Action act = () =>
            {
                if (this.Tag != null)
                    sModel = this.Tag as ShInfoModel;
                InitInfo();
                LoadSheetGoodsInfoList();
            };
            act.TryCatch("单据明细列表页面初始化异常！");
        }

        private void LoadSheetGoodsInfoList()
        {
            if (sModel != null)
            {
                List<SheetGoodsInfoModel> list = RequestStar.GetSheetGoodsInfoList(sModel.ShType, sModel.TypeId, sModel.Id);
                if (list.Count > 0)
                {
                    dgvList.AutoGenerateColumns = false;
                    dgvList.DataSource = list;
                }
                else
                {
                    dgvList.DataSource = null;
                    dgvList.AllowUserToAddRows = false;
                }
            }

        }

        private void InitInfo()
        {
            if (sModel != null)
            {
                switch (sModel.TypeId)
                {
                    case 1:

                        if (sModel.ShType == 1)
                        {
                            lblShTypeName.Text = "采购入库单";
                            lblUnitDesp.Text = "供应商";
                        }
                        else
                        {
                            lblShTypeName.Text = "销售出库单";
                            lblUnitDesp.Text = "客户";
                        }

                        break;
                    case 2:
                        lblUnitDesp.Text = "仓库";
                        if (sModel.ShType == 1)
                            lblShTypeName.Text = "采购入库单";
                        else
                            lblShTypeName.Text = "销售出库单";
                        break;
                    case 3:
                        lblUnitDesp.Text = "商品";
                        if (sModel.ShType == 1)
                            lblShTypeName.Text = "采购入库单";
                        else
                            lblShTypeName.Text = "销售出库单";
                        break;
                }
                lblUnitName.Text = sModel.InfoName;
            }
        }

        /// <summary>
        /// 导出明细数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnOutToExcel_Click(object sender, EventArgs e)
        {
            List<SheetGoodsInfoModel> list = dgvList.DataSource as List<SheetGoodsInfoModel>;
            string fileName = lblUnitName.Text + "的相关" + lblShTypeName.Text + "明细数据";
            FormUtility.DataToExcel<SheetGoodsInfoModel>(list, dgvList.Columns, fileName + ".xls", fileName, fileName, "导出明细数据");
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }
    }
}
