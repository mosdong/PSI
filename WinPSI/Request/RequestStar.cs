using Newtonsoft.Json;
using PSI.Common;
using PSI.Models.APIModels;
using PSI.Models.DModels;
using PSI.Models.UIModels;
using PSI.Models.VModels;
using System.Collections.Generic;
using System.Configuration;

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
        public static GoodsInfoModel GetGoodsInfo(int goodsId)
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
        public static bool DeleteGoodsInfos(List<int> goodsIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = goodsIds };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/choose/DeleteGoodsInfos");
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
        public static bool DeleteGoodsInfo(int goodsId)
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
        public static bool RecoverGoodsInfos(List<int> goodsIds, string uName)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = goodsIds, Name = uName };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/choose/RecoverGoodsInfos");
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
        public static bool RecoverGoodsInfo(int goodsId, string uName)
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
        public static bool RemoveGoodsInfos(List<int> goodsIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = goodsIds };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/choose/RemoveGoodsInfos");
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
        public static bool RemoveGoodsInfo(int goodsId)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/RemoveGoodsInfo?goodsId={goodsId}");
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
        public static bool CheckIsGoodsUse(int goodsId)
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
        public static bool AddGoodsInfo(GoodsInfoModel goodsInfo)
        {
            var returnStr = HttpHelper.Post(goodsInfo, url + $"api/choose/AddGoodsInfo");
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
        public static bool UpdateGoodsInfo(GoodsInfoModel goodsInfo)
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
        public static bool ExistGoodsName(string goodsName)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/ExistGoodsName?goodsName={goodsName}");
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
        public static string GetGoodsInfoByKeywords(string keywords)
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
        public static List<GoodsInfoModel> GetGoodsListByTypeId(int typeId)
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
        public static  List<GoodsTypeInfoModel> LoadAllGoodsTypes()
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


        /// <summary>
        /// 加载商品类别信息（模糊查询）
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public static List<GoodsTypeInfoModel> LoadAllGoodsTypeList(string keywords, bool blShow)
        {
            var result = HttpHelper.Get(url + $"api/choose/LoadAllGoodsTypeList?keywords={keywords}&&blShow={blShow}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(result);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                List<GoodsTypeInfoModel> viewUsers = JsonConvert.DeserializeObject<List<GoodsTypeInfoModel>>(resultStr);
                return viewUsers;
            }
            return null;
        }



        /// <summary>
        /// 获取指定商品类别信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static GoodsTypeInfoModel GetGoodsType(int typeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/GetGoodsType?typeId={typeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<GoodsTypeInfoModel>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 检查该商品类别是否已添加商品
        /// </summary>
        /// <param name="gtypeId"></param>
        /// <returns></returns>
        public static bool CheckIsAddGoods(int gtypeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/CheckIsAddGoods?gtypeId={gtypeId}");
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
        /// 检查该商品类别是否已添加子类别
        /// </summary>
        /// <param name="gTypeId"></param>
        /// <returns></returns>
        public static bool HasChildTypes(int gTypeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/HasChildTypes?gTypeId={gTypeId}");
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
        /// 检查类别名称是否已存在
        /// </summary>
        /// <param name="gtypeName"></param>
        /// <returns></returns>
        public static bool ExistName(string gtypeName)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/ExistName?gtypeName={gtypeName}");
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
        /// 添加商品类别
        /// </summary>
        /// <param name="gtInfo"></param>
        /// <returns></returns>
        public static int AddGoodsType(GoodsTypeInfoModel gtInfo)
        {
            var returnStr = HttpHelper.Post(gtInfo, url + $"api/choose/AddGoodsType");
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
        /// 更新商品类别信息
        /// </summary>
        /// <param name="gtInfo"></param>
        /// <param name="blUpdate"></param>
        /// <returns></returns>
        public static bool UpdateGoodsType(GoodsTypeInfoModel gtInfo, string oldName)
        {
            GoodsTypeInfoApi goodsTypeInfoApi = new GoodsTypeInfoApi() { TypeInfoModel = gtInfo, OldName = oldName };
            var returnStr = HttpHelper.Post(goodsTypeInfoApi, url + $"api/choose/UpdateGoodsType");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        //Goodtype
        #region 删除
        /// <summary>
        /// 根据Id删除  这里id是主键  假删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns> 
        public static bool GoodsTypeLogicDelete(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/GoodsTypeLogicDelete?unitId={id}");
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
        public static bool GoodsTypeDelete(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/GoodsTypeDelete?unitId={id}");
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
        public static bool GoodsTypeDeleteList(List<int> idList)
        {
            var returnStr = HttpHelper.Post(idList, url + $"api/choose/GoodsTypeDeleteList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }
        public static bool GoodsTypeLogicDeleteList(List<int> idList)
        {
            var returnStr = HttpHelper.Post(idList, url + $"api/choose/GoodsTypeLogicDeleteList");
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
        public static bool GoodsTypeRecover(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/GoodsTypeRecover?id={id}");
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
        public static bool GoodsTypeRecoverList(List<int> ids)
        {
            var returnStr = HttpHelper.Post(ids, url + $"api/choose/GoodsTypeRecoverList");
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



        #endregion

        #region GoodsUnit
        /// <summary>
        ///  获取所有的单位列表
        /// </summary>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public static List<GoodsUnitInfoModel> GetAllUnits(int isDeleted)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/GetAllUnits?isDeleted={isDeleted}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<GoodsUnitInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        //删除（真假 多个 、单个）  恢复   省略不写


        #region 删除
        /// <summary>
        /// 根据Id删除  这里id是主键  假删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns> 
        public static bool GoodsUnitLogicDelete(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/GoodsUnitLogicDelete?unitId={id}");
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
        public static bool GoodsUnitDelete(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/GoodsUnitDelete?unitId={id}");
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
        public static bool GoodsUnitDeleteList(List<int> idList)
        {
            var returnStr = HttpHelper.Post(idList, url + $"api/choose/GoodsUnitDeleteList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }
        public static bool GoodsUnitLogicDeleteList(List<int> idList)
        {
            var returnStr = HttpHelper.Post(idList, url + $"api/choose/GoodsUnitLogicDeleteList");
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
        public static bool GoodsUnitRecover(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/GoodsUnitRecover?id={id}");
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
        public static bool GoodsUnitRecoverList(List<int> ids)
        {
            var returnStr = HttpHelper.Post(ids, url + $"api/choose/GoodsUnitRecoverList");
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
        /// 检查是否有商品已应用该单位
        /// </summary>
        /// <param name="unitName"></param>
        /// <returns></returns>
        public static bool GetGoodsUnitUse(string unitName)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/GetGoodsUnitUse?unitName={unitName}");
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
        /// 添加单位信息
        /// </summary>
        /// <param name="guInfo"></param>
        /// <returns></returns>
        public static bool AddGoodsUnit(GoodsUnitInfoModel guInfo)
        {
            var returnStr = HttpHelper.Post(guInfo, url + $"api/choose/GetGoodsUnitUse");
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
        /// 修改单位信息
        /// </summary>
        /// <param name="guInfo"></param>
        /// <returns></returns>
        public static bool UpdatGoodsUnit(GoodsUnitInfoModel guInfo, bool isUpdateName, string oldName)
        {
            GoodsUnitInfoApi goodsUnitInfoApi = new GoodsUnitInfoApi() { GoodsUnitInfoModel = guInfo, IsUpdateName = isUpdateName, OldName = oldName };
            var returnStr = HttpHelper.Post(goodsUnitInfoApi, url + $"api/choose/UpdatGoodsUnit");
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
        /// 判断单位名称是否已存在
        /// </summary>
        /// <param name="unitName"></param>
        /// <returns></returns>
        public static bool GoodsUnitExistName(string unitName)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/GoodsUnitExistName?unitName={unitName}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
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

        #region StoreType
        /// <summary>
        /// 判断指定类别是否添加了仓库
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static bool IsAddStores(int typeId)
        {
            var resultStr = HttpHelper.Get(url + $"api/choose/IsAddStores?typeId={typeId}");
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
        /// 加载所有的仓库类别信息
        /// </summary>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public static List<StoreTypeInfoModel> LoadAllStoreTypes(bool isShowDel)
        {
            var resultStr = HttpHelper.Get(url + $"api/choose/LoadAllStoreTypes?isShowDel={isShowDel}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<StoreTypeInfoModel>>(Str);
                return result;
            }
            return null;
        }



        /// <summary>
        /// 获取指定类别信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static StoreTypeInfoModel GetStoreType(int typeId)
        {
            var resultStr = HttpHelper.Get(url + $"api/choose/StoreTypeInfoModel?typeId={typeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<StoreTypeInfoModel>(Str);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 判断类别名称是否已存在
        /// </summary>
        /// <param name="storeName"></param>
        /// <returns></returns>
        public static bool ExistsStoreType(string storeName)
        {
            var resultStr = HttpHelper.Get(url + $"api/choose/ExistsStoreType?storeName={storeName}");
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
        /// 新增仓库类别信息
        /// </summary>
        /// <param name="storeTypeInfo"></param>
        /// <returns></returns>
        public static bool AddStoreType(StoreTypeInfoModel storeTypeInfo)
        {
            var resultStr = HttpHelper.Post(storeTypeInfo, url + $"api/choose/AddStoreType");
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
        /// 修改仓库类别信息
        /// </summary>
        /// <param name="storeTypeInfo"></param>
        /// <returns></returns>
        public static bool UpdateStoreType(StoreTypeInfoModel storeTypeInfo)
        {
            var resultStr = HttpHelper.Post(storeTypeInfo, url + $"api/choose/UpdateStoreType");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(resultStr);
            if (message.IsOK)
            {
                var Str = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(Str);
                return result;
            }
            return false;
        }


        #region 删除
        /// <summary>
        /// 根据Id删除  这里id是主键  假删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns> 
        public static  bool StoreTypeLogicDelete(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/StoreTypeLogicDelete?unitId={id}");
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
        public static  bool StoreTypeDelete(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/StoreTypeDelete?unitId={id}");
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
        public static  bool StoreTypeDeleteList(List<int> idList)
        {
            var returnStr = HttpHelper.Post(idList, url + $"api/choose/StoreTypeDeleteList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                bool result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }
        public static  bool StoreTypeLogicDeleteList(List<int> idList)
        {
            var returnStr = HttpHelper.Post(idList, url + $"api/choose/StoreTypeLogicDeleteList");
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
        public static  bool StoreTypeRecover(int id)
        {
            var returnStr = HttpHelper.Get(url + $"api/choose/StoreTypeRecover?id={id}");
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
        public static  bool StoreTypeRecoverList(List<int> ids)
        {
            var returnStr = HttpHelper.Post(ids, url + $"api/choose/StoreTypeRecoverList");
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
        #endregion

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


        #region System--Menu
        /// <summary>
        /// 获取角色菜单列表
        /// </summary>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        public static List<MenuInfoModel> GetMenuList(List<int> roleIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = roleIds };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/system/GetMenuList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<MenuInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取指定角色的菜单编号集合
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public static List<int> GetRoleMenuIds(int roleId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetMenuList?roleId={roleId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<int>>(resultStr);
                return result;
            }
            return null;
        }


        /// <summary>
        /// 关键字查询菜单列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public static List<MenuInfoModel> GetMenuListByKeyWords(string keywords)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetMenuListByKeyWords?keywords={keywords}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<MenuInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取所有菜单信息（编号，名称） 用于下拉框或列表的绑定
        /// </summary>
        /// <returns></returns>
        public static List<MenuInfoModel> GetAllMenus()
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetAllMenus");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<MenuInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取所有菜单列表（绑定TreeView）
        /// </summary>
        /// <returns></returns>
        public static List<MenuInfoModel> GetTvMenus()
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetTvMenus");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<MenuInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取指定的菜单信息
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public static MenuInfoModel GetMenuInfo(int menuId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetMenuInfo?menuId={menuId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<MenuInfoModel>(resultStr);
                return result;
            }
            return null;
        }



        /// <summary>
        /// 判断菜单名称是否已存在
        /// </summary>
        /// <param name="mName"></param>
        /// <returns></returns>
        public static bool ExistMenu(string mName)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/ExistMenu?mName={mName}");
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
        /// 新增菜单信息
        /// </summary>
        /// <param name="menuInfo"></param>
        /// <returns></returns>
        public static bool AddMenuInfo(MenuInfoModel menuInfo)
        {
            var returnStr = HttpHelper.Post(menuInfo, url + $"api/system/AddMenuInfo");
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
        /// 修改菜单信息
        /// </summary>
        /// <param name="menuInfo"></param>
        /// <param name="blUpdate"></param>
        /// <returns></returns>
        public static bool UpdateMenuInfo(MenuInfoModel menuInfo, bool blUpdate)
        {
            MenuInfoApi menuInfoApi = new MenuInfoApi() { MenuInfoModel = menuInfo, BlUpdate = blUpdate };
            var returnStr = HttpHelper.Post(menuInfoApi, url + $"api/system/UpdateMenuInfo");
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
        /// 删除菜单信息
        /// </summary>
        /// <param name="menuIds"></param>
        /// <param name="delType"></param>
        /// <returns></returns>
        public static bool DeleteMenu(List<int> menuIds, int delType)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = menuIds, TypeId = delType };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/system/DeleteMenu");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }
        #endregion

        #region Sheet
        /// <summary>
        /// 分页查询单据列表
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PageModel<SheetInfoModel> GetSheetList(ShQueryParaModel paraModel, int startIndex, int pageSize)
        {
            PageInfo pageInfo = new PageInfo()
            {
                ShQueryParaModel = paraModel,
                StartIndex = startIndex,
                PageSize = pageSize
            };
            var returnStr = HttpHelper.Post(pageInfo, url + $"api/system/GetSheetList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<PageModel<SheetInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取指定 供应商/客户 、 仓库 、商品的相关单据明细列表
        /// </summary>
        /// <param name="shType"></param>
        /// <param name="typeId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<SheetGoodsInfoModel> GetSheetGoodsInfoList(int shType, int typeId, int id)
        {

            var returnStr = HttpHelper.Get(url + $"api/system/GetSheetGoodsInfoList?shType={shType}&&typeId={typeId}&&id={id}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<SheetGoodsInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取审核状态列表
        /// </summary>
        /// <returns></returns>
        public static List<CheckModel> GetCheckList()
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetCheckList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<CheckModel>>(resultStr);
                return result;
            }
            return null;
        }




        #endregion

        #region System-Sys
        /// <summary>
        /// 获取系统开账状态
        /// </summary>
        /// <param name="sysId"></param>
        /// <returns></returns>
        public static bool GetOpenState(int sysId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetOpenState?sysId={sysId}");
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
        /// 备份数据
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool BackupData(string path)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/BackupData?path={path}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }
        #endregion

        #region System-Region
        /// <summary>
        /// 根据区域编号获取区域完整信息
        /// </summary>
        /// <param name="regionId"></param>
        /// <returns></returns>
        public static string GetRegionAddress(int regionId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetRegionAddress?regionId={regionId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<string>(resultStr);
                return result;
            }
            return "";
        }

        public static RegionInfoModel GetRegion(int regionId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetRegion?regionId={regionId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<RegionInfoModel>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取省区域列表
        /// </summary>
        /// <returns></returns>
        public static List<RegionInfoModel> GetProvinces()
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetProvinces");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<RegionInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取市区域列表
        /// </summary>
        /// <returns></returns>
        public static List<RegionInfoModel> GetCities(int provinceId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetCities?provinceId={provinceId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<RegionInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取县/区 区域列表
        /// </summary>
        /// <returns></returns>
        public static List<RegionInfoModel> GetCountries(int cityId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetCountries?cityId={cityId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<RegionInfoModel>>(resultStr);
                return result;
            }
            return null;
        }
        #endregion

        #region System-Role
        /// <summary>
        /// 获取绑定的角色列表（主要用于绑定下拉框或列表框）
        /// </summary>
        /// <returns></returns>
        public static List<RoleInfoModel> GetAllRoles()
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetAllRoles");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<RoleInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取所有角色列表
        /// </summary>
        /// <returns></returns>
        public static List<RoleInfoModel> GetAllRoleList()
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetAllRoleList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<RoleInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 判断角色名称是否已存在
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public static bool ExistRoleName(string roleName)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/ExistRoleName?roleName={roleName}");
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
        /// 添加角色信息
        /// </summary>
        /// <param name="roleInfo"></param>
        /// <returns></returns>
        public static bool AddRoleInfo(RoleInfoModel roleInfo)
        {
            var returnStr = HttpHelper.Post(roleInfo, url + $"api/system/AddRoleInfo");
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
        /// 修改角色信息
        /// </summary>
        /// <param name="roleInfo"></param>
        /// <returns></returns>
        public static bool UpdateRoleInfo(RoleInfoModel roleInfo)
        {
            var returnStr = HttpHelper.Post(roleInfo, url + $"api/system/UpdateRoleInfo");
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
        /// 获取指定的角色信息
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public static RoleInfoModel GetRole(int roleId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetRole?roleId={roleId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<RoleInfoModel>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 删除单个角色信息
        /// </summary>
        /// <param name="roleId"></param>
        ///  <param name="delType">0 ---logic   1= real</param>
        /// <returns></returns>
        public static bool DeleteRoleLogic(int roleId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/DeleteRoleLogic?roleId={roleId}");
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
        /// 删除角色信息（真删除）
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public static bool DeleteRoleReal(int roleId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/DeleteRoleReal?roleId={roleId}");
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
        /// 删除多个角色信息
        /// </summary>
        /// <param name="roleIds"></param>
        /// <param name="delType"></param>
        /// <returns></returns>
        public static bool DeleteRoles(List<int> roleIds, int delType)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo()
            {

                KeyIds = roleIds,
                TypeId = delType
            };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/system/DeleteRoles");
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
        /// 保存权限设置
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="menuIds"></param>
        /// <param name="tmenuIds"></param>
        /// <param name="uName"></param>
        /// <returns></returns>
        public static bool SetRoleRight(int roleId, List<int> menuIds, List<int> tmenuIds, string uName)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo()
            {
                Name = uName,
                KeyID = roleId,
                KeyIds = menuIds,
                TemKeyIds = tmenuIds
            };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/system/SetRoleRight");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }
        #endregion

        #region ToolGroup
        /// <summary>
        /// 获取所有的工具组（绑定下拉框）
        /// </summary>
        /// <returns></returns>
        public static List<ToolGroupInfoModel> GetToolGroups()
        {
            var returnStr = HttpHelper.Get(url + $"api/tool/GetToolGroups");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<ToolGroupInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 加载所有的工具组数据（未删除 或 已删除）
        /// </summary>
        /// <param name="blShow"></param>
        /// <returns></returns>
        public static List<ToolGroupInfoModel> GetToolGroups(bool blShow)
        {
            var returnStr = HttpHelper.Post(blShow,url + $"api/tool/GetToolGroups?blShow={blShow}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<ToolGroupInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 检查组名是否已存在
        /// </summary>
        /// <param name="gName"></param>
        /// <returns></returns>
        public static bool ToolGroupExistName(string gName)
        {
            var returnStr = HttpHelper.Get(url + $"api/tool/ExistName?gName={gName}");
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
        /// 添加工具组
        /// </summary>
        /// <param name="tgInfo"></param>
        /// <returns></returns>
        public static bool AddToolGroup(ToolGroupInfoModel tgInfo)
        {
            var returnStr = HttpHelper.Post(tgInfo, url + $"api/tool/AddToolGroup");
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
        /// 修改工具组
        /// </summary>
        /// <param name="tgInfo"></param>
        /// <returns></returns>
        public static bool UpdateToolGroup(ToolGroupInfoModel tgInfo)
        {
            var returnStr = HttpHelper.Post(tgInfo, url + $"api/tool/UpdateToolGroup");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        public static bool ConfirmToolGroup(ToolGroupInfoModel tgInfo)
        {
            var returnStr = HttpHelper.Post(tgInfo, url + $"api/tool/ConfirmToolGroup");
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
        /// 删除工具组（多个）逻辑删除
        /// </summary>
        /// <param name="tgIds"></param>
        /// <returns></returns>
        public static bool LogicDeleteToolGroups(List<int> tgIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = tgIds };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/tool/LogicDeleteToolGroups");
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
        /// 恢复工具组数据（多个）
        /// </summary>
        /// <param name="tgIds"></param>
        /// <returns></returns>
        public static bool RecoverToolGroups(List<int> tgIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = tgIds };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/tool/RecoverToolGroups");
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
        /// 删除工具组（单个）逻辑删除
        /// </summary>
        /// <param name="tgId"></param>
        /// <returns></returns>
        public static bool LogicDeleteToolGroup(int tgId)
        {
            var returnStr = HttpHelper.Get(url + $"api/tool/LogicDeleteToolGroup?tgId={tgId}");
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
        /// 恢复工具组数据（单个）
        /// </summary>
        /// <param name="tgIds"></param>
        /// <returns></returns>
        public static bool RecoverToolGroup(int tgId)
        {
            var returnStr = HttpHelper.Get(url + $"api/tool/RecoverToolGroup?tgId={tgId}");
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
        /// 永久删除工具组(单个)
        /// </summary>
        /// <param name="tgId"></param>
        /// <returns></returns>
        public static bool DeleteToolGroup(int tgId)
        {
            var returnStr = HttpHelper.Get(url + $"api/tool/DeleteToolGroup?tgId={tgId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }
        #endregion

        #region ToolMenu
        /// <summary>
        /// 获取工具栏菜单项数据
        /// </summary>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        public static List<ToolMenuInfoModel> GetToolMenuList(List<int> roleIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = roleIds };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/tool/GetToolMenuList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<ToolMenuInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取所有的工具菜单项（绑定TreeView）
        /// </summary>
        /// <returns></returns>
        public static List<ToolMenuInfoModel> GetToolMenuList()
        {
            var returnStr = HttpHelper.Get(url + $"api/tool/GetToolMenuList");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<ToolMenuInfoModel>>(resultStr);
                return result;
            }
            return null;
        }



        /// <summary>
        /// 获取指定角色的工具栏菜单编号集合
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public static List<int> GetRoleTMenuIds(int roleId)
        {
            var returnStr = HttpHelper.Get(url + $"api/tool/GetRoleTMenuIds?roleId={roleId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<int>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 关键字查询工具菜单项列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public static List<ToolMenuInfoModel> GetToolMenuInfos(string keywords, bool blShow)
        {
            var returnStr = HttpHelper.Get(url + $"api/tool/GetToolMenuInfos?keywords={keywords}&&blShow={blShow}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<ToolMenuInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 删除工具菜单项（假删除）
        /// </summary>
        /// <param name="tmenuId"></param>
        /// <returns></returns>
        public static bool DeleteToolMenuLogic(int tmenuId)
        {
            var returnStr = HttpHelper.Get(url + $"api/tool/DeleteToolMenuLogic?tmenuId={tmenuId}");
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
        ///  删除工具菜单项（真删除）
        /// </summary>
        /// <param name="tmenuId"></param>
        /// <returns></returns>
        public static bool DeleteToolMenu(int tmenuId)
        {
            var returnStr = HttpHelper.Get(url + $"api/tool/DeleteToolMenu?tmenuId={tmenuId}");
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
        ///  删除多个工具菜单项（真删除）
        /// </summary>
        /// <param name="delIds"></param>
        /// <returns></returns>
        public static bool DeleteToolMenus(List<int> delIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = delIds };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/tool/DeleteToolMenus");
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
        ///  删除多个工具菜单项（假删除）
        /// </summary>
        /// <param name="delIds"></param>
        /// <returns></returns>
        public static bool DeleteToolMenusLogic(List<int> delIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = delIds };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/tool/DeleteToolMenusLogic");
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
        /// 工具菜单数据恢复  多条
        /// </summary>
        /// <param name="delIds"></param>
        /// <returns></returns>
        public static bool RecoverToolMenus(List<int> delIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = delIds };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/tool/RecoverToolMenus");
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
        /// 工具菜单数据恢复 单条
        /// </summary>
        /// <param name="tmenuId"></param>
        /// <returns></returns>
        public static bool RecoverToolMenu(int tmenuId)
        {
            var returnStr = HttpHelper.Get(url + $"api/tool/RecoverToolMenu?tmenuId={tmenuId}");
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
        /// 判断指定工具组下是否已添加工具菜单项
        /// </summary>
        /// <param name="tgId"></param>
        /// <returns></returns>
        public static bool HasToolMenus(List<int> tgIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = tgIds };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/tool/HasToolMenus");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }
        #endregion

        #region Pay
        /// <summary>
        /// 进入付款页面,获取付款 列表
        /// </summary>
        /// <param name="payType"></param>
        /// <returns></returns>
        public static List<PayInfoModel> GetFirstPayInfos(string payType, string strPayFor)
        {
            var returnStr = HttpHelper.Get(url + $"api/tool/GetFirstPayInfos?payType={payType}&&strPayFor={strPayFor}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<PayInfoModel>>(resultStr);
                return result;
            }
            return null;
        }
        #endregion

        #region User
        /// <summary>
        /// 条件查询用户列表
        /// </summary>
        /// <param name="uName"></param>
        /// <returns></returns>
        public static List<UserInfoModel> GetUserList(string uName)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetUserList?uName={uName}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<UserInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 启用用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static bool EnableUser(int userId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/EnableUser?userId={userId}");
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
        /// 停用用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static bool StopUser(int userId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/StopUser?userId={userId}");
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
        /// 多用户停用
        /// </summary>
        /// <param name="userIds"></param>
        /// <returns></returns>
        public static bool StopUsers(List<int> userIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = userIds };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/system/StopUsers");
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
        /// 多用户启用
        /// </summary>
        /// <param name="userIds"></param>
        /// <returns></returns>
        public static bool EnableUsers(List<int> userIds)
        {
            ReqQueryInfo reqQueryInfo = new ReqQueryInfo() { KeyIds = userIds };
            var returnStr = HttpHelper.Post(reqQueryInfo, url + $"api/system/EnableUsers");
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
        /// 获取用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static UserInfoModel GetUserInfo(int userId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetUserInfo?userId={userId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<UserInfoModel>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取用户角色列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static List<ViewUserRoleModel> GetUserRoleList(int userId)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetUserRoleList?userId={userId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<ViewUserRoleModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 添加用户 信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="urList"></param>
        /// <returns></returns>
        public static bool AddUserInfo(UserInfoModel userInfo, List<UserRoleInfoModel> urList)
        {
            UserInfoApi userInfoApi = new UserInfoApi()
            {
                UserInfoModel = userInfo,
                UserRoleInfoModels = urList
            };
            var returnStr = HttpHelper.Post(userInfoApi, url + $"api/system/AddUserInfo");
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
        /// 修改用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="urList"></param>
        /// <param name="urListNew"></param>
        /// <returns></returns>
        public static bool UpdateUserInfo(UserInfoModel userInfo, List<UserRoleInfoModel> urList, List<UserRoleInfoModel> urListNew)
        {
            UserInfoApi userInfoApi = new UserInfoApi()
            {
                UserInfoModel = userInfo,
                UserRoleInfoModels = urList,
                NewUserRoleInfoModels = urListNew
            };
            var returnStr = HttpHelper.Post(userInfoApi, url + $"api/system/UpdateUserInfo");
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
        /// 获取用户原始密码
        /// </summary>
        /// <param name="uName"></param>
        /// <returns></returns>
        public static string GetOldPwd(string uName)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/GetOldPwd?uName={uName}");
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
        /// 修改用户密码
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="enNewPwd"></param>
        /// <returns></returns>
        public static bool UpdateUserPwd(string uName, string enNewPwd)
        {
            var returnStr = HttpHelper.Get(url + $"api/system/UpdateUserPwd?uName={uName}&&enNewPwd={enNewPwd}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }
        #endregion

        #region PerchaseInStore
        /// <summary>
        /// 获取指定的采购单信息
        /// </summary>
        /// <param name="perId"></param>
        /// <returns></returns>
        public static PerchaseInStoreInfoModel GetPerchaseInfo(int perId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/GetPerchaseInfo?perId={perId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<PerchaseInStoreInfoModel>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取指定单据的商品明细列表
        /// </summary>
        /// <param name="perId"></param>
        /// <returns></returns>
        public static List<ViewPerGoodsInfoModel> GetPerGoodsList(int perId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/GetPerGoodsList?perId={perId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<ViewPerGoodsInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 添加采购单
        /// </summary>
        /// <param name="perInfo"></param>
        /// <param name="perGoodsList"></param>
        /// <returns></returns>
        public static string AddPerchaseInfo(PerchaseInStoreInfoModel perInfo, List<ViewPerGoodsInfoModel> perGoodsList)
        {
            PerchaseInStoreInfoApi perchaseInStoreInfoApi = new PerchaseInStoreInfoApi()
            {
                perchaseInStoreInfoModel = perInfo,
                viewPerGoodsInfoModels = perGoodsList
            };
            var returnStr = HttpHelper.Post(perchaseInStoreInfoApi, url + $"api/business/AddPerchaseInfo");
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
        /// 修改采购单
        /// </summary>
        /// <param name="perInfo"></param>
        /// <param name="perGoodsList"></param>
        /// <returns></returns>
        public static bool UpdatePerchaseInfo(PerchaseInStoreInfoModel perInfo, List<ViewPerGoodsInfoModel> perGoodsList)
        {
            PerchaseInStoreInfoApi perchaseInStoreInfoApi = new PerchaseInStoreInfoApi()
            {
                perchaseInStoreInfoModel = perInfo,
                viewPerGoodsInfoModels = perGoodsList
            };
            var returnStr = HttpHelper.Post(perchaseInStoreInfoApi, url + $"api/business/UpdatePerchaseInfo");
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
        /// 审核指定的采购单
        /// </summary>
        /// <param name="perId"></param>
        /// <param name="checkPerson"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public static bool CheckPerchaseInfo(int perId, string checkPerson, int storeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/CheckPerchaseInfo?perId={perId}&&checkPerson={checkPerson}&&storeId={storeId}");
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
        /// 作废采购单
        /// </summary>
        /// <param name="perId"></param>
        /// <returns></returns>
        public static bool NoUsePerchaseInfo(int perId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/NoUsePerchaseInfo?perId={perId}");
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
        /// 红冲
        /// </summary>
        /// <param name="perId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public static bool RedCheckPerchaseInfo(int perId, int storeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/RedCheckPerchaseInfo?perId={perId}&&storeId={storeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }





        #region 采购统计

        /// <summary>
        /// 按供应商统计采购数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PageModel<PerQuerySupplierModel> GetPerDataBySupplier(QueryParaModel paraModel, int startIndex, int pageSize)
        {
            PageInfo pageInfo = new PageInfo()
            {
                QueryParaModel = paraModel,
                StartIndex = startIndex,
                PageSize = pageSize
            };
            var returnStr = HttpHelper.Post(pageInfo, url + $"api/business/GetPerDataBySupplier");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<PageModel<PerQuerySupplierModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 按仓库统计采购数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PageModel<PerQueryStoreModel> GetPerDataByStore(QueryParaModel paraModel, int startIndex, int pageSize)
        {
            PageInfo pageInfo = new PageInfo()
            {
                QueryParaModel = paraModel,
                StartIndex = startIndex,
                PageSize = pageSize
            };
            var returnStr = HttpHelper.Post(pageInfo, url + $"api/business/GetPerDataByStore");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<PageModel<PerQueryStoreModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 按商品统计采购数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PageModel<PerQueryGoodsModel> GetPerDataByGoods(QueryParaModel paraModel, int startIndex, int pageSize)
        {
            PageInfo pageInfo = new PageInfo()
            {
                QueryParaModel = paraModel,
                StartIndex = startIndex,
                PageSize = pageSize
            };
            var returnStr = HttpHelper.Post(pageInfo, url + $"api/business/GetPerDataByGoods");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<PageModel<PerQueryGoodsModel>>(resultStr);
                return result;
            }
            return null;
        }
        #endregion
        #endregion

        #region SaleOutStore
        /// <summary>
        /// 获取指定的销售单信息
        /// </summary>
        /// <param name="saleId"></param>
        /// <returns></returns>
        public static SaleOutStoreInfoModel GetSaleInfo(int saleId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/GetSaleInfo?perId={saleId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<SaleOutStoreInfoModel>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取指定销售单据的商品明细列表
        /// </summary>
        /// <param name="saleId"></param>
        /// <returns></returns>
        public static List<ViewSaleGoodsInfoModel> GetSaleGoodsList(int saleId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/GetSaleGoodsList?perId={saleId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<ViewSaleGoodsInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 添加销售单
        /// </summary>
        /// <param name="saleInfo"></param>
        /// <param name="saleGoodsList"></param>
        /// <returns></returns>
        public static string AddSaleInfo(SaleOutStoreInfoModel saleInfo, List<ViewSaleGoodsInfoModel> saleGoodsList)
        {
            SaleOutStoreInfoApi saleOutStoreInfoApi = new SaleOutStoreInfoApi()
            {
                saleOutStoreInfoModel = saleInfo,
                viewSaleGoodsInfoModels = saleGoodsList
            };
            var returnStr = HttpHelper.Post(saleOutStoreInfoApi, url + $"api/business/AddSaleInfo");
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
        /// 修改销售单
        /// </summary>
        /// <param name="saleInfo"></param>
        /// <param name="saleGoodsList"></param>
        /// <returns></returns>
        public static bool UpdateSaleInfo(SaleOutStoreInfoModel saleInfo, List<ViewSaleGoodsInfoModel> saleGoodsList)
        {
            SaleOutStoreInfoApi saleOutStoreInfoApi = new SaleOutStoreInfoApi()
            {
                saleOutStoreInfoModel = saleInfo,
                viewSaleGoodsInfoModels = saleGoodsList
            };
            var returnStr = HttpHelper.Post(saleOutStoreInfoApi, url + $"api/business/UpdateSaleInfo");
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
        /// 审核指定的销售单
        /// </summary>
        /// <param name="saleId"></param>
        /// <param name="checkPerson"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public static bool CheckSaleInfo(int saleId, string checkPerson, int storeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/CheckSaleInfo?perId={saleId}&&checkPerson={checkPerson}&&storeId={storeId}");
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
        /// 作废销售单
        /// </summary>
        /// <param name="saleId"></param>
        /// <returns></returns>
        public static bool NoUseSaleInfo(int saleId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/NoUseSaleInfo?perId={saleId}");
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
        /// 红冲
        /// </summary>
        /// <param name="saleId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public static bool RedCheckSaleInfo(int saleId, int storeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/RedCheckSaleInfo?perId={saleId}&&storeId={storeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }



        #region 销售数据统计

        /// <summary>
        /// 按客户统计销售数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PageModel<SaleQueryCustomerModel> GetSaleDataByCustomer(QueryParaModel paraModel, int startIndex, int pageSize)
        {
            PageInfo pageInfo = new PageInfo()
            {
                QueryParaModel = paraModel,
                StartIndex = startIndex,
                PageSize = pageSize
            };
            var returnStr = HttpHelper.Post(pageInfo, url + $"api/business/GetSaleDataByCustomer");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<PageModel<SaleQueryCustomerModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 按仓库统计销售数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PageModel<SaleQueryStoreModel> GetSaleDataByStore(QueryParaModel paraModel, int startIndex, int pageSize)
        {
            PageInfo pageInfo = new PageInfo()
            {
                QueryParaModel = paraModel,
                StartIndex = startIndex,
                PageSize = pageSize
            };
            var returnStr = HttpHelper.Post(pageInfo, url + $"api/business/GetSaleDataByStore");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<PageModel<SaleQueryStoreModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 按商品统计销售数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PageModel<SaleQueryGoodsModel> GetSaleDataByGoods(QueryParaModel paraModel, int startIndex, int pageSize)
        {
            PageInfo pageInfo = new PageInfo()
            {
                QueryParaModel = paraModel,
                StartIndex = startIndex,
                PageSize = pageSize
            };
            var returnStr = HttpHelper.Post(pageInfo, url + $"api/business/GetSaleDataByGoods");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<PageModel<SaleQueryGoodsModel>>(resultStr);
                return result;
            }
            return null;
        }
        #endregion
        #endregion

        #region StockBll
        /// <summary>
        /// 获取指定的入库单信息
        /// </summary>
        /// <param name="stockId"></param>
        /// <returns></returns>
        public static StockStoreInfoModel GetStockInfo(int stockId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/GetStockInfo?stockId={stockId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<StockStoreInfoModel>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取指定单据的商品明细列表
        /// </summary>
        /// <param name="stockId"></param>
        /// <returns></returns>
        public static List<ViewStStockGoodsInfoModel> GetStockGoodsList(int stockId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/GetStockGoodsList?stockId={stockId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<ViewStStockGoodsInfoModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 添加入库单
        /// </summary>
        /// <param name="stockInfo"></param>
        /// <param name="stockGoodsList"></param>
        /// <returns></returns>
        public static string AddStockInfo(StockStoreInfoModel stockInfo, List<ViewStStockGoodsInfoModel> stockGoodsList)
        {
            StockStoreInfoApi stockStoreInfoApi = new StockStoreInfoApi()
            {
                stockGoodsList = stockGoodsList,
                stockStoreInfoModel = stockInfo
            };
            var returnStr = HttpHelper.Post(stockStoreInfoApi, url + $"api/business/AddStockInfo");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<string>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 修改入库单
        /// </summary>
        /// <param name="stockInfo"></param>
        /// <param name="stockGoodsList"></param>
        /// <returns></returns>
        public static bool UpdateStockInfo(StockStoreInfoModel stockInfo, List<ViewStStockGoodsInfoModel> stockGoodsList)
        {
            StockStoreInfoApi stockStoreInfoApi = new StockStoreInfoApi()
            {
                stockGoodsList = stockGoodsList,
                stockStoreInfoModel = stockInfo
            };
            var returnStr = HttpHelper.Post(stockStoreInfoApi, url + $"api/business/UpdateStockInfo");
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
        /// 审核指定的入库单
        /// </summary>
        /// <param name="stockId"></param>
        /// <param name="checkPerson"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public static bool CheckStockInfo(int stockId, string checkPerson, int storeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/CheckStockInfo?stockId={stockId}&&checkPerson={checkPerson}&&storeId={storeId}");
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
        /// 作废入库单
        /// </summary>
        /// <param name="stockId"></param>
        /// <returns></returns>
        public static bool NoUseStockInfo(int stockId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/NoUseStockInfo?stockId={stockId}");
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
        /// 红冲
        /// </summary>
        /// <param name="stockId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public static bool RedCheckStockInfo(int stockId, int storeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/RedCheckStockInfo?stockId={stockId}&&storeId={storeId}");
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
        /// 检查商品（多个）库存量
        /// </summary>
        /// <param name="listGoods"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public static string CheckGoodsCurCount(List<ViewSaleGoodsInfoModel> listGoods, int storeId)
        {
            ViewSaleGoodsInfoApi viewSaleGoodsInfoApi = new ViewSaleGoodsInfoApi()
            {
                ViewSaleGoodsInfoModels = listGoods,
                StoreId = storeId
            };
            var returnStr = HttpHelper.Post(viewSaleGoodsInfoApi, url + $"api/business/CheckGoodsCurCount");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<string>(resultStr);
                return result;
            }
            return "";
        }




        #region 库存查询统计

        /// <summary>
        /// 获取商品库存统计数据
        /// </summary>
        /// <param name="qModel"></param>
        /// <returns></returns>
        public static List<StoreStockQueryModel> GetStoreStockData(StockQueryParaModel qModel)
        {
            var returnStr = HttpHelper.Post(qModel, url + $"api/business/GetStoreStockData");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<StoreStockQueryModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取指定商品的库存分布
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="storeId"></param>
        /// <param name="storeName"></param>
        /// <returns></returns>
        public static List<GoodsStoreStockModel> GetGoodsStoreStock(int goodsId, int storeId, string storeName)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/GetGoodsStoreStock?goodsId={goodsId}&&storeId={storeId}&&storeName={storeName}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<GoodsStoreStockModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 获取指定商品的库存变动明细
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="storeId"></param>
        /// <param name="storeName"></param>
        /// <returns></returns>
        public static List<StockChangeInfoModel> GetGoodsStockChangeList(int goodsId, int storeId, string storeName)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/GetGoodsStockChangeList?goodsId={goodsId}&&storeId={storeId}&&storeName={storeName}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<StockChangeInfoModel>>(resultStr);
                return result;
            }
            return null;
        }
        #endregion

        #region 库存上下限设置

        /// <summary>
        /// 获取商品上下限列表
        /// </summary>
        /// <param name="gTypeId"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public static List<ViewStoreStockUpDownModel> GetGoodsStockUpDownList(int gTypeId, int storeId)
        {
            var returnStr = HttpHelper.Get(url + $"api/business/GetGoodsStockUpDownList?gTypeId={gTypeId}&&storeId={storeId}");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<List<ViewStoreStockUpDownModel>>(resultStr);
                return result;
            }
            return null;
        }

        /// <summary>
        /// 保存库存上下限
        /// </summary>
        /// <param name="goodsStockUpdownList"></param>
        /// <returns></returns>
        public static bool SetGoodsStockUpDown(List<ViewStoreStockUpDownModel> goodsStockUpdownList)
        {
            ViewStoreStockUpDownApi viewStoreStockUpDownApi = new ViewStoreStockUpDownApi()
            {
                viewStoreStockUpDownModels = goodsStockUpdownList
            };
            var returnStr = HttpHelper.Post(viewStoreStockUpDownApi, url + $"api/business/SetGoodsStockUpDown");
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
        /// 批量保存库存上下限设置（设置统一的上限下限）
        /// </summary>
        /// <param name="goodsStockUpdownList"></param>
        /// <param name="up"></param>
        /// <param name="down"></param>
        /// <returns></returns>
        public static bool SetMoreGoodsStockUpDown(List<ViewStoreStockUpDownModel> goodsStockUpdownList, int up, int down)
        {
            ViewStoreStockUpDownApi viewStoreStockUpDownApi = new ViewStoreStockUpDownApi()
            {
                viewStoreStockUpDownModels = goodsStockUpdownList,
                up = up,
                down = down
            };
            var returnStr = HttpHelper.Post(viewStoreStockUpDownApi, url + $"api/business/SetMoreGoodsStockUpDown");
            MessageResult message = JsonConvert.DeserializeObject<MessageResult>(returnStr);
            if (message.IsOK)
            {
                var resultStr = JsonConvert.SerializeObject(message.Data);
                var result = JsonConvert.DeserializeObject<bool>(resultStr);
                return result;
            }
            return false;
        }

        #endregion
        #endregion
    }
}
