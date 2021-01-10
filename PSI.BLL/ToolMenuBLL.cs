using PSI.DAL;
using PSI.Models.DModels;
using System.Collections.Generic;
using System.Linq;

namespace PSI.BLL
{
    public class ToolMenuBLL : BaseBLL<ToolMenuInfoModel>
    {
        ToolMenuDAL tmDAL = new ToolMenuDAL();
        RoleToolMenuDAL rtmDAL = new RoleToolMenuDAL();
        /// <summary>
        /// 获取工具栏菜单项数据
        /// </summary>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        public List<ToolMenuInfoModel> GetToolMenuList(List<int> roleIds)
        {
            string ids = string.Join(",", roleIds);
            return tmDAL.GetToolMenuList(ids);
        }

        /// <summary>
        /// 获取所有的工具菜单项（绑定TreeView）
        /// </summary>
        /// <returns></returns>
        public List<ToolMenuInfoModel> GetToolMenuList()
        {
            return tmDAL.GetToolMenuList();
        }



        /// <summary>
        /// 获取指定角色的工具栏菜单编号集合
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public List<int> GetRoleTMenuIds(int roleId)
        {
            List<RoleTMenuInfoModel> list = rtmDAL.GetRoleTMenuIds(roleId);
            return list.Select(m => m.TMenuId).ToList();
        }

        /// <summary>
        /// 关键字查询工具菜单项列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public List<ToolMenuInfoModel> GetToolMenuInfos(string keywords, bool blShow)
        {
            return tmDAL.GetToolMenuInfos(keywords, blShow);
        }

        /// <summary>
        /// 删除工具菜单项（假删除）
        /// </summary>
        /// <param name="tmenuId"></param>
        /// <returns></returns>
        public bool DeleteToolMenuLogic(int tmenuId)
        {
            List<int> ids = new List<int>();
            ids.Add(tmenuId);
            return tmDAL.UpdateToolMenusDelState(ids, 0, 1);
        }

        /// <summary>
        ///  删除工具菜单项（真删除）
        /// </summary>
        /// <param name="tmenuId"></param>
        /// <returns></returns>
        public bool DeleteToolMenu(int tmenuId)
        {
            List<int> ids = new List<int>();
            ids.Add(tmenuId);
            return tmDAL.UpdateToolMenusDelState(ids, 1, 2);
        }

        /// <summary>
        ///  删除多个工具菜单项（真删除）
        /// </summary>
        /// <param name="delIds"></param>
        /// <returns></returns>
        public bool DeleteToolMenus(List<int> delIds)
        {
            return tmDAL.UpdateToolMenusDelState(delIds, 1, 2);
        }

        /// <summary>
        ///  删除多个工具菜单项（假删除）
        /// </summary>
        /// <param name="delIds"></param>
        /// <returns></returns>
        public bool DeleteToolMenusLogic(List<int> delIds)
        {
            return tmDAL.UpdateToolMenusDelState(delIds, 0, 1);
        }

        /// <summary>
        /// 工具菜单数据恢复  多条
        /// </summary>
        /// <param name="delIds"></param>
        /// <returns></returns>
        public bool RecoverToolMenus(List<int> delIds)
        {
            return tmDAL.UpdateToolMenusDelState(delIds, 0, 0);
        }

        /// <summary>
        /// 工具菜单数据恢复 单条
        /// </summary>
        /// <param name="tmenuId"></param>
        /// <returns></returns>
        public bool RecoverToolMenu(int tmenuId)
        {
            List<int> ids = new List<int>();
            ids.Add(tmenuId);
            return tmDAL.UpdateToolMenusDelState(ids, 0, 0);
        }

        /// <summary>
        /// 判断指定工具组下是否已添加工具菜单项
        /// </summary>
        /// <param name="tgId"></param>
        /// <returns></returns>
        public bool HasToolMenus(List<int> tgIds)
        {
            return tmDAL.HasToolMenus(tgIds);
        }
    }
}
