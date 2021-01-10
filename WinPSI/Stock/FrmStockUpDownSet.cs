using PSI.Common;
using PSI.Models.DModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinPSI.FModels;
using WinPSI.Request;

namespace WinPSI.Stock
{
    public partial class FrmStockUpDownSet : Form
    {
        public FrmStockUpDownSet()
        {
            InitializeComponent();
        } 
         
        List<ViewStoreStockUpDownModel> listStart = null;
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStockUpDownSet_Load(object sender, EventArgs e)
        {
            Action act = () =>
            {
                LoadCboStores();//加载仓库下拉框
                            LoadTVGTypes();//加载商品类别节点树
                            LoadGoodsStockUpDownList();//加载商品上下限列表
                        };
            act.TryCatch("加载商品库存查询异常！");
        }

        private void LoadGoodsStockUpDownList()
        {
            int storeId = cboStores.SelectedValue.GetInt();
            int gTypeId = 0;
            if (tvGoodsType.SelectedNode != null)
                gTypeId = tvGoodsType.SelectedNode.Name.GetInt();
            List<ViewStoreStockUpDownModel> list = RequestStar.GetGoodsStockUpDownList(gTypeId, storeId);
            listStart = RequestStar.GetGoodsStockUpDownList(gTypeId, storeId);
            if (list.Count > 0)
            {
                dgvList.AutoGenerateColumns = false;
                dgvList.DataSource = list;
                tsbtnSetMore.Enabled = true;
            }
            else
            {
                dgvList.DataSource = null;
                tsbtnSetMore.Enabled = false;
                dgvList.AllowUserToAddRows = false;
            }
        }

        /// <summary>
        /// 加载商品类别
        /// </summary>
        private void LoadTVGTypes()
        {
            tvGoodsType.Nodes.Clear();
            TreeNode rootNode = FormUtility.CreateNode("0", "商品类别");
            tvGoodsType.Nodes.Add(rootNode);
            //获取节点数据
            List<GoodsTypeInfoModel> typeList = RequestStar.LoadAllGoodsTypes();
            FormUtility.AddTvGTypesNode(typeList, rootNode, 0);//递归加载节点
            tvGoodsType.SelectedNode = rootNode;
            tvGoodsType.ExpandAll();//展开所有节点
        }

        /// <summary>
        /// 加载仓库下拉框
        /// </summary>
        private void LoadCboStores()
        {
            List<StoreInfoModel> storeList = RequestStar.LoadAllStores();
            storeList.Insert(0, new StoreInfoModel()
            {
                StoreId = 0,
                StoreName = "全部"
            });
            cboStores.DisplayMember = "StoreName";
            cboStores.ValueMember = "StoreId";
            cboStores.DataSource = storeList;
            cboStores.SelectedIndex = 0;
        }

        private void tvGoodsType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadGoodsStockUpDownList();
        }

        private void cboStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGoodsStockUpDownList();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            tvGoodsType.SelectedNode = tvGoodsType.Nodes[0];
            cboStores.SelectedIndex = 0;
            LoadGoodsStockUpDownList();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }

        /// <summary>
        /// 打开批量设置页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnSetMore_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                if (dgvList.SelectedRows.Count == 0)
                {
                    MsgBoxHelper.MsgErrorShow("请选择要设置库存上下限的商品！");
                    return;
                }
                else
                {
                    if (MsgBoxHelper.MsgBoxConfirm("设置上下限", $"您确定设置这{dgvList.SelectedRows.Count}个商品的库存上下限吗？") == DialogResult.Yes)
                    {
                                    //要进行统一设置的商品列表
                                    List<ViewStoreStockUpDownModel> list = new List<ViewStoreStockUpDownModel>();
                        foreach (DataGridViewRow row in dgvList.SelectedRows)
                        {
                            var info = row.DataBoundItem as ViewStoreStockUpDownModel;
                            list.Add(info);
                        }
                                    //打开批量设置页面      list   storeName  刷新列表  订阅事件
                                    FrmSetMore fSetMore = new FrmSetMore();
                        fSetMore.Tag = new StockSetMoreModel()
                        {
                            StoreUpDownList = list,
                            StoreName = cboStores.Text.Trim()
                        };
                        fSetMore.ReloadList += LoadGoodsStockUpDownList;
                        fSetMore.ShowDialog();
                    }
                }

            };
            act.TryCatch("批量设置库存上下限出现异常！");
        }

        /// <summary>
        /// 保存上下限设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                            //获取列表数据，判断是否有修改的数据，移除未修改的数据，保存提交
                            List<ViewStoreStockUpDownModel> list = dgvList.DataSource as List<ViewStoreStockUpDownModel>;
                List<ViewStoreStockUpDownModel> list2 = new List<ViewStoreStockUpDownModel>();
                foreach (var gupdown in list)
                {
                    foreach (var vsud in listStart)
                    {
                        if (vsud.StoreGoodsId == gupdown.StoreGoodsId && (vsud.StockUp != gupdown.StockUp || vsud.StockDown != gupdown.StockDown))
                        {
                            list2.Add(gupdown);
                            break;
                        }
                    }
                }
                if (list2.Count == 0)
                {
                    MsgBoxHelper.MsgErrorShow("没有需要保存的信息！");
                    return;
                }
                bool blSave = RequestStar.SetGoodsStockUpDown(list2);
                if (blSave)
                {
                    MsgBoxHelper.MsgBoxShow("保存库存上下限", "库存上下限设置保存成功！");
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow("库存上下限设置保存失败！");
                    return;
                }
            };
            act.TryCatch("保存库存上下限设置出现异常！");

        }
    }
}
