﻿using PSI.DAL;
using PSI.Models.DModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI.BLL
{
       public  class StoreTypeBLL : BaseBLL<StoreTypeInfoModel>
        {
                StoreDAL storeDAL = new StoreDAL();
                StoreTypeDAL stDAL = new StoreTypeDAL();
                /// <summary>
                /// 判断指定类别是否添加了仓库
                /// </summary>
                /// <param name="typeId"></param>
                /// <returns></returns>
                public bool IsAddStores(int typeId)
                {
                        List<StoreInfoModel> stores = storeDAL.GetStoresByTypeId(typeId);
                        if (stores.Count > 0)
                                return true;
                        else
                                return false;
                }

                /// <summary>
                /// 加载所有的仓库类别信息
                /// </summary>
                /// <param name="isDeleted"></param>
                /// <returns></returns>
                public List<StoreTypeInfoModel> LoadAllStoreTypes(bool isShowDel)
                {
                        int isDeleted = isShowDel ? 1 : 0;
                        return stDAL.LoadAllStoreTypes(isDeleted);
                }

                /// <summary>
                /// 获取所有有效的类别（编号、名称）---用于绑定下拉框或TreeView
                /// </summary>
                /// <returns></returns>
                public List<StoreTypeInfoModel> LoadAllDrpStoreTypes()
                {
                        return stDAL.LoadAllDrpStoreTypes();
                }

                /// <summary>
                /// 获取指定类别信息
                /// </summary>
                /// <param name="typeId"></param>
                /// <returns></returns>
                public StoreTypeInfoModel GetStoreType(int typeId)
                {
                        return stDAL.GetStoreType(typeId);
                }

                /// <summary>
                /// 判断类别名称是否已存在
                /// </summary>
                /// <param name="storeName"></param>
                /// <returns></returns>
                public bool ExistsStoreType(string storeName)
                {
                        return stDAL.ExistsStoreType(storeName);
                }

                /// <summary>
                /// 新增仓库类别信息
                /// </summary>
                /// <param name="storeTypeInfo"></param>
                /// <returns></returns>
                public bool AddStoreType(StoreTypeInfoModel storeTypeInfo)
                {
                        return stDAL.AddStoreType(storeTypeInfo);
                }

                /// <summary>
                /// 修改仓库类别信息
                /// </summary>
                /// <param name="storeTypeInfo"></param>
                /// <returns></returns>
                public bool UpdateStoreType(StoreTypeInfoModel storeTypeInfo)
                {
                        return stDAL.UpdateStoreType(storeTypeInfo);
                }
        }
}
