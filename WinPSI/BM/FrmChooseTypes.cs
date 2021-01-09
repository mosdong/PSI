using PSI.Common;
using PSI.Models.DModels;
using WinPSI.FModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.Perchase;
using WinPSI.Sale;
using WinPSI.Request;

namespace WinPSI.BM
{
    public partial class FrmChooseTypes : Form
        {
                public FrmChooseTypes()
                {
                        InitializeComponent();
                }
         
              
                public event Action SetType;//赋值类别名称
                private ChooseModel cModel = null;
                private void FrmChooseTypes_Load(object sender, EventArgs e)
                {
                        Action act = () =>
                        {
                                if(this.Tag!=null )
                                {
                                        cModel = this.Tag as ChooseModel;
                                        if(cModel==null)
                                        {
                                                MsgBoxHelper.MsgErrorShow("类别信息初始化失败！");
                                                return;
                                        }
                                }
                                LoadTypeInfos();
                        };
                        act.TryCatch("类别信息初始化加载异常！");
                }

                /// <summary>
                /// 加载类别信息
                /// </summary>
                private void LoadTypeInfos()
                {
                        tvUTypes.Nodes.Clear();
                        string rootName = "";
                        if (cModel.TypeCode.Contains("Goods"))//加载商品类别信息
                        {
                                this.Text = "请选择商品类别";
                                rootName = "商品类别";

                        }
                        else if (cModel.TypeCode == "Units")
                        {
                                this.Text = "请选择单位类别";
                                rootName = "单位类别";
                        }
                        TreeNode rootNode = FormUtility.CreateNode("0", rootName);
                        tvUTypes.Nodes.Add(rootNode);
                        if (cModel.TypeCode.Contains("Goods"))//加载商品类别信息
                        {
                                List<GoodsTypeInfoModel> gtList = RequestStar.LoadAllGoodsTypes();
                                if(gtList.Count >0)
                                        FormUtility.AddTvGTypesNode(gtList, rootNode, 0);
                        }
                        else if (cModel.TypeCode == "Units")
                        {
                              List<UnitTypeInfoModel> utList= RequestStar.LoadAllTVUnitTypes();
                                if(utList.Count >0)
                                 FormUtility.AddTvUTypesNode(utList, rootNode, 0);
                        }
                        tvUTypes.SelectedNode = rootNode;
                        tvUTypes.ExpandAll();
                }

                /// <summary>
                /// 选择类别 
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void btnChoose_Click(object sender, EventArgs e)
                {
                        TreeNode selNode = tvUTypes.SelectedNode;
                        if(selNode!=null)
                        {
                                if(cModel.TypeCode=="Units")
                                {
                                        UnitTypeInfoModel selType = new UnitTypeInfoModel()
                                        {
                                                UTypeId = selNode.Name.GetInt(),
                                                UTypeName = selNode.Text.Trim()
                                        };
                                        FrmUnitInfo fUnitInfo = cModel.FGet as FrmUnitInfo;
                                        fUnitInfo.uType = selType;
                                }
                                else if(cModel.TypeCode.Contains("Goods"))
                                {
                                        GoodsTypeInfoModel selType = new GoodsTypeInfoModel()
                                        {
                                                GTypeId = selNode.Name.GetInt(),
                                                GTypeName = selNode.Text.Trim()
                                        };
                                        if (selType.GTypeId == 0)
                                                selType.GTypeName = null;
                                                        
                                        switch(cModel.TypeCode)
                                        {
                                                case "Goods":
                                                        FrmGoodsInfo fGoodsInfo = cModel.FGet as FrmGoodsInfo;
                                                        fGoodsInfo.gTypeInfo = selType;
                                                        break;
                                                case "Goods-PerQueryBySupplier":
                                                        FrmPerchaseQueryBySupplier fPerQueryBySupplier = cModel.FGet as FrmPerchaseQueryBySupplier;
                                                        fPerQueryBySupplier.gtInfo = selType;
                                                        break;
                                                case "Goods-SaleQueryByCustomer":
                                                        FrmSaleQueryByCustomer fSaleQueryByCustomer = cModel.FGet as FrmSaleQueryByCustomer;
                                                        fSaleQueryByCustomer.gtInfo = selType;
                                                        break;
                                        }
                                }
                                this.SetType?.Invoke();
                        }
                        this.Close();
                }

                private void btnCancel_Click(object sender, EventArgs e)
                {
                        this.Close();
                }
        }
}
