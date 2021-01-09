using Newtonsoft.Json;
using PSI.Common;
using PSI.Models.APIModels;
using PSI.Models.DModels;
using PSI.Models.UIModels;
using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPSI.Request
{
    /// <summary>
    /// 发送远程服务器请求
    /// </summary>
    public class RequestStar
    {
        private static string url = ConfigurationManager.AppSettings["ServerIP"];
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="enPwd"></param>
        /// <returns></returns>
        public static List<ViewUserRoleModel> Login(string userName, string enPwd)
        {
            UserInfo userInfo = new UserInfo() { UserName = userName, UserPwd = enPwd };
            string result = HttpHelper.Post(userInfo, url + "/api/login/CheckUser");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(result);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                List<ViewUserRoleModel> viewUsers = JsonConvert.DeserializeObject<List<ViewUserRoleModel>>(resultStr);
                return viewUsers;
            }
            return null;
        }



        #region Goods商品
        /// <summary>
        /// 获取商品列表
        /// </summary>
        /// <param name="gtypeId"></param>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public static List<ViewGoodsInfoModel> GetGoodsList(int gtypeId, string keywords)
        {
            var result = HttpHelper.Get(url + $"api/choose/GetGoodsList?gtypeId={gtypeId}&&keywords={keywords}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(result);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                List<ViewGoodsInfoModel> viewUsers = JsonConvert.DeserializeObject<List<ViewGoodsInfoModel>>(resultStr);
                return viewUsers;
            }
            return null;
        }

        public static PageModel<ViewGoodsInfoModel> LoadGoodsList(int gTypeId, string keywords, bool isStopped, bool isShowDel, int startIndex, int pageSize)
        {
            PageInfo pageInfo = new PageInfo() { IsShowDel = isShowDel, KeyId = gTypeId, KeyWord = keywords, IsStopped = isStopped, StartIndex = startIndex, PageSize = pageSize };
            var result = HttpHelper.Post(pageInfo, url + $"api/choose/GoodsList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(result);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                PageModel<ViewGoodsInfoModel> viewUsers = JsonConvert.DeserializeObject<PageModel<ViewGoodsInfoModel>>(resultStr);
                return viewUsers;
            }
            return null;
        }


        /// <summary>
        /// 获取指定的商品信息
        /// </summary>
        /// <param name="goodsId"></param>
        /// <returns></returns>
        public GoodsInfoModel GetGoodsInfo(int goodsId)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/GetGoodsInfo?goodsId={goodsId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<GoodsInfoModel>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 批量逻辑删除商品信息
        /// </summary>
        /// <param name="goodsIds"></param>
        /// <param name="delType"></param>
        /// <param name="isDeleted"></param>
        /// <param name="uName"></param>
        /// <returns></returns>
        public bool DeleteGoodsInfos(List<int> goodsIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = goodsIds };
            var returnStr = HttpHelper.Post(reqQueryInfo,url + $"api/choose/DeleteGoodsInfos");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 单个商品的删除 
        /// </summary>
        /// <param name="goodsId"></param>
        /// <returns></returns>
        public bool DeleteGoodsInfo(int goodsId)
        { 
            var returnStr = HttpHelper.Get(url + $"api/choose/DeleteGoodsInfo?goodsId={goodsId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 批量恢复商品信息
        /// </summary>
        /// <param name="goodsIds"></param>
        /// <param name="delType"></param>
        /// <param name="isDeleted"></param>
        /// <param name="uName"></param>
        /// <returns></returns>
        public bool RecoverGoodsInfos(List<int> goodsIds, string uName)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = goodsIds, Name = uName };
            var returnStr = HttpHelper.Post(reqQueryInfo,url + $"api/choose/RecoverGoodsInfos");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 单个商品的恢复
        /// </summary>
        /// <param name="goodsId"></param>
        /// <returns></returns>
        public bool RecoverGoodsInfo(int goodsId, string uName)
        { 
            var returnStr = HttpHelper.Get(url + $"api/choose/RecoverGoodsInfo?goodsId={goodsId}&&uName={uName}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 批量移除商品信息
        /// </summary>
        /// <param name="goodsIds"></param>
        /// <param name="delType"></param>
        /// <param name="isDeleted"></param>
        /// <param name="uName"></param>
        /// <returns></returns>
        public bool RemoveGoodsInfos(List<int> goodsIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = goodsIds };
            var returnStr = HttpHelper.Post(reqQueryInfo,url + $"api/choose/RemoveGoodsInfos");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 单个商品的移除
        /// </summary>
        /// <param name="goodsId"></param>
        /// <returns></returns>
        public bool RemoveGoodsInfo(int goodsId)
        { 
            var returnStr = HttpHelper.Get( url + $"api/choose/RemoveGoodsInfo?goodsId={goodsId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 判断指定商品是否在使用中
        /// </summary>
        /// <param name="goodsId"></param>
        /// <returns></returns>
        public bool CheckIsGoodsUse(int goodsId)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/CheckIsGoodsUse?goodsId={goodsId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="goodsInfo"></param>
        /// <returns></returns>
        public bool AddGoodsInfo(GoodsInfoModel goodsInfo)
        {
            var returnStr = HttpHelper.Post(goodsInfo,url + $"api/choose/AddGoodsInfo");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 修改商品信息
        /// </summary>
        /// <param name="goodsInfo"></param>
        /// <returns></returns>
        public bool UpdateGoodsInfo(GoodsInfoModel goodsInfo)
        {
            var returnStr = HttpHelper.Post(goodsInfo, url + $"api/choose/UpdateGoodsInfo");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 判断商品名称是否已存在
        /// </summary>
        /// <param name="goodsName"></param>
        /// <returns></returns>
        public bool ExistGoodsName(string goodsName)
        {
            var returnStr = HttpHelper.Get( url + $"api/choose/ExistGoodsName?goodsName={goodsName}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 关键词获取商品名称
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public string GetGoodsInfoByKeywords(string keywords)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/GetGoodsInfoByKeywords?keywords={keywords}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<string>(resultStr);
                return result;
            }
            return "";
        }

        /// <summary>
        /// 根据类别获取商品列表
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public List<GoodsInfoModel> GetGoodsListByTypeId(int typeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/GetGoodsListByTypeId?typeId={typeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<GoodsInfoModel>>(resultStr);
                return result;
            }
            return null;
        }
        /// <summary>
        /// 加载所有商品类型
        /// </summary>
        /// <returns></returns>
        public static List<GoodsTypeInfoModel> LoadAllGoodsTypes()
        {
            var result = HttpHelper.Get(url + $"api/choose/GetAllGoodsTypes");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(result);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                List<GoodsTypeInfoModel> viewUsers = JsonConvert.DeserializeObject<List<GoodsTypeInfoModel>>(resultStr);
                return viewUsers;
            }
            return null;
        }



        #endregion


        #region Store商店
        /// <summary>
        /// 获取下拉
        /// </summary>
        /// <returns></returns>
        public static List<StoreTypeInfoModel> LoadAllDrpStoreTypes()
        {
            var result = HttpHelper.Get(url + $"api/choose/GetAllDrpStoreTypes");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(result);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                List<StoreTypeInfoModel> viewUsers = JsonConvert.DeserializeObject<List<StoreTypeInfoModel>>(resultStr);
                return viewUsers;
            }
            return null;
        }

        /// <summary>
        /// 条件查询仓库列表
        /// </summary>
        /// <param name="sTypeId"></param>
        /// <param name="keywords"></param>
        /// <param name="isShowDel"></param>
        /// <returns></returns>
        public static List<ViewStoreInfoModel> LoadStoreList(int sTypeId, string keywords, bool isShowDel)
        {
            var result = HttpHelper.Get(url + $"api/choose/GetStoreList?sTypeId={sTypeId}&&keywords={keywords}&&isShowDel={isShowDel}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(result);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                List<ViewStoreInfoModel> viewUsers = JsonConvert.DeserializeObject<List<ViewStoreInfoModel>>(resultStr);
                return viewUsers;
            }
            return null;
        }



        public static List<StoreInfoModel> LoadAllStores()
        {
            var resultStr = HttpHelper.Get(url + $"api/choose/LoadAllStores");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<StoreInfoModel>>(Str);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 检查仓库是否在使用中
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public static bool CheckStoreUse(int storeId)
        {
            var resultStr = HttpHelper.Get(url + $"api/choose/CheckStoreUse?storeId={storeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(Str);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 获取指定的仓库信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public static StoreInfoModel GetStoreInfo(int storeId)
        {
            var resultStr = HttpHelper.Get(url + $"api/choose/GetStoreInfo?storeId={storeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<StoreInfoModel>(Str);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 单个仓库的删除 
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public static bool DeleteStoreInfo(int storeId)
        {
            var resultStr = HttpHelper.Get(url + $"api/choose/DeleteStoreInfo?storeId={storeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(Str);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 批量仓库的删除 
        /// </summary>
        /// <param name="storeIds"></param>
        /// <returns></returns>
        public static bool DeleteStoreInfos(List<int> storeIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = storeIds };
            var resultStr = HttpHelper.Post(reqQueryInfo, url + $"api/choose/DeleteStoreInfos");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(Str);
                return result;
            }
            return false;
        }


        /// <summary>
        /// 批量恢复仓库信息
        /// </summary>
        /// <param name="goodsIds"></param>
        /// <param name="uName"></param>
        /// <returns></returns>
        public static bool RecoverStoreInfos(List<int> storeIds, string uName)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = storeIds, Name = uName };
            var resultStr = HttpHelper.Post(reqQueryInfo, url + $"api/choose/RecoverStoreInfos");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(Str);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 单个仓库的恢复
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public static bool RecoverStoreInfo(int storeId, string uName)
        {
            var resultStr = HttpHelper.Get(url + $"api/choose/RecoverStoreInfo?storeId={storeId}&&uName={uName}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(Str);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 批量移除仓库信息
        /// </summary>
        /// <param name="storeIds"></param>
        /// <returns></returns>
        public static bool RemoveStoreInfos(List<int> storeIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = storeIds };
            var resultStr = HttpHelper.Post(reqQueryInfo, url + $"api/choose/RemoveStoreInfos");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(Str);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 单个仓库的移除
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public static bool RemoveStoreInfo(int storeId)
        {
            var resultStr = HttpHelper.Get(url + $"api/choose/RemoveStoreInfo?storeId={storeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(Str);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 判断仓库是否已存在（同一类别下不能重名）
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="sTypeId"></param>
        /// <returns></returns>
        public static bool ExistsStore(string storeName, int sTypeId)
        {
            var resultStr = HttpHelper.Get(url + $"api/choose/ExistsStore?storeName={storeName}&&sTypeId={sTypeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(Str);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 修改仓库信息
        /// </summary>
        /// <param name="storeInfo"></param>
        /// <returns></returns>
        public static bool UpdateStoreInfo(StoreInfoModel storeInfo)
        {
            var resultStr = HttpHelper.Post(storeInfo, url + $"api/choose/UpdateStoreInfo");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(Str);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 添加仓库信息
        /// </summary>
        /// <param name="storeInfo"></param>
        /// <param name="goodsIds">所有商品的编号集合</param>
        /// <returns></returns>
        public static bool AddStoreInfo(StoreInfoModel storeInfo)
        {
            var resultStr = HttpHelper.Post(storeInfo, url + $"api/choose/AddStoreInfo");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(Str);
                return result;
            }
            return false;
        }

        #endregion


        #region Unit单位


        #region 删除
        /// <summary>
        /// 根据Id删除  这里id是主键  假删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns> 
        public static bool UnitLogicDelete(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/UnitLogicDelete?unitId={id}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 根据Id真删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="delType"></param>
        /// <returns></returns> 
        public static bool UnitDelete(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/UnitDelete?unitId={id}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 批量删除(真删除)
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns> 
        public static bool UnitDeleteList(List<int> idList)
        {
            var returnStr = HttpHelper.Post(idList, url + $"api/unit/UnitDeleteList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }
        public static bool UnitLogicDeleteList(List<int> idList)
        {
            var returnStr = HttpHelper.Post(idList, url + $"api/unit/UnitLogicDeleteList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }




        #endregion

        #region 恢复
        /// <summary>
        /// 根据Id恢复  这里id是主键 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns> 
        public static bool UnitRecover(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/UnitRecover?id={id}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 批量恢复  这里id是主键 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns> 
        public static bool UnitRecoverList(List<int> ids)
        {
            var returnStr = HttpHelper.Post(ids, url + $"api/unit/UnitRecoverList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }
        #endregion


        public static PageModel<ViewUnitInfoModel> GetUnitList(int uTypeId, string keywords, bool isShowDel, int startIndex, int pageSize)
        {
            PageInfo pageInfo = new PageInfo()
            {
                KeyId = uTypeId,
                KeyWord = keywords,
                StartIndex = startIndex,
                IsShowDel = isShowDel,
                PageSize = pageSize
            };
            var result = HttpHelper.Post(pageInfo, url + $"api/unit/GetUnitList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(result);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                PageModel<ViewUnitInfoModel> viewUsers = JsonConvert.DeserializeObject<PageModel<ViewUnitInfoModel>>(resultStr);
                return viewUsers;
            }
            return null;
        }
        public static List<UnitInfoModel> GetUnitList(int uTypeId, string utypeName, string keywords)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyID = uTypeId, KeyWords = keywords, Name = utypeName };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/unit/GetUnitList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<UnitInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 检查单位是否在使用中
        /// </summary>
        /// <param name="unitId"></param>
        /// <returns></returns>
        public static bool CheckUnitUse(int unitId)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/CheckUnitUse?unitId={unitId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 获取指定的单位信息
        /// </summary>
        /// <param name="unitId"></param>
        /// <returns></returns>
        public static UnitInfoModel GetUnitInfo(int unitId)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/GetUnitInfo?unitId={unitId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                UnitInfoModel result = JsonConvert.DeserializeObject<UnitInfoModel>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 添加单位信息
        /// </summary>
        /// <param name="unitInfo"></param>
        /// <returns></returns>
        public static bool AddUnitInfo(UnitInfoModel unitInfo)
        {
            var returnStr = HttpHelper.Post(unitInfo, url + $"api/unit/AddUnitInfo");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 修改单位信息
        /// </summary>
        /// <param name="unitInfo"></param>
        /// <returns></returns>
        public static bool UpdateUnitInfo(UnitInfoModel unitInfo)
        {
            var returnStr = HttpHelper.Post(unitInfo, url + $"api/unit/UpdateUnitInfo");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 判断单位是否已存在
        /// </summary>
        /// <param name="unitName"></param>
        /// <returns></returns>
        public static bool ExistUnit(string unitName, int uTypeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/ExistUnit?unitName={unitName}&&uTypeId={uTypeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 关键词获取单位信息
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public static string GetUnitNameByKeywords(string keywords)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/GetUnitNameByKeywords?keywords={keywords}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                string result = JsonConvert.DeserializeObject<string>(resultStr);
                return result;
            }
            return "";
        }
        #endregion

        #region UnitType单位类型



        #region 删除
        /// <summary>
        /// 根据Id删除  这里id是主键  假删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns> 
        public static bool UnitTypeLogicDelete(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/UnitTypeLogicDelete?unitId={id}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 根据Id真删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="delType"></param>
        /// <returns></returns> 
        public static bool UnitTypeDelete(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/UnitTypeDelete?unitId={id}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 批量删除(真删除)
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns> 
        public static bool UnitTypeDeleteList(List<int> idList)
        {
            var returnStr = HttpHelper.Post(idList, url + $"api/unit/UnitTypeDeleteList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }
        public static bool UnitTypeLogicDeleteList(List<int> idList)
        {
            var returnStr = HttpHelper.Post(idList, url + $"api/unit/UnitTypeLogicDeleteList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }




        #endregion

        #region 恢复
        /// <summary>
        /// 根据Id恢复  这里id是主键 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns> 
        public static bool UnitTypeRecover(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/UnitTypeRecover?id={id}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 批量恢复  这里id是主键 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns> 
        public static bool UnitTypeRecoverList(List<int> ids)
        {
            var returnStr = HttpHelper.Post(ids, url + $"api/unit/UnitTypeRecoverList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }
        #endregion

        /// <summary>
        /// 获取所有的往来单位类别列表（绑定下拉框）
        /// </summary>
        /// <returns></returns>
        public static List<UnitTypeInfoModel> LoadAllDrpUnitTypes()
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/LoadAllDrpUnitTypes");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<UnitTypeInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取所有的往来单位类别列表（绑定TreeView）
        /// </summary>
        /// <returns></returns>
        public static List<UnitTypeInfoModel> LoadAllTVUnitTypes()
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/LoadAllTVUnitTypes");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<UnitTypeInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取指定的子类别列表
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static List<UnitTypeInfoModel> GetAllUnitTypes(string typeName)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/GetAllUnitTypes?typeName={typeName}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<UnitTypeInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 条件查询往来单位列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public static List<UnitTypeInfoModel> LoadUnitTypeList(string keywords, bool blShowDel)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/LoadUnitTypeList?keywords={keywords}&&blShowDel={blShowDel}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<UnitTypeInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取指定的类别信息实体
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static UnitTypeInfoModel GetUnitType(int typeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/GetUnitType?typeId={typeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<UnitTypeInfoModel>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 判断名称是否已存在
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public static bool ExistsUnitType(string typeName)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/ExistsUnitType?typeName={typeName}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 添加往来单位类别信息
        /// </summary>
        /// <param name="utInfo"></param>
        /// <returns>类别编号</returns>
        public static int AddUnitType(UnitTypeInfoModel utInfo)
        {
            var returnStr = HttpHelper.Post(utInfo, url + $"api/unit/AddUnitType");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<int>(resultStr);
                return result;
            }
            return 0;
        }

        /// <summary>
        /// 修改往来单位类别信息
        /// </summary>
        /// <param name="utInfo"></param>
        /// <param name="blUpdate"></param>
        /// <returns></returns>
        public static bool UpdateUnitType(UnitTypeInfoModel utInfo, string oldName)
        {
            UnitTypeInfoModelApi unitTypeInfoModelApi = new UnitTypeInfoModelApi
            {
                TypeInfoModel = utInfo,
                OldName = oldName
            };
            var returnStr = HttpHelper.Post(unitTypeInfoModelApi, url + $"api/unit/UpdateUnitType");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 指定类别是否添加了子类别
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static bool IsAddChilds(int typeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/IsAddChilds?typeId={typeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 是否添加了单位信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static bool IsAddUnits(int typeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/IsAddUnits?typeId={typeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        /// <summary>
        /// 关键词获取单位信息
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public static string GetUTypeNameByKeywords(string keywords)
        {
            var returnStr = HttpHelper.Get(url + $"api/unit/GetUTypeNameByKeywords?keywords={keywords}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<string>(resultStr);
                return result;
            }
            return "";
        }
        #endregion

    }
}
