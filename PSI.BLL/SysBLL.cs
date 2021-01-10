using PSI.DAL;
using System;
using System.Configuration;

namespace PSI.BLL
{
    public class SysBLL
    {
        SysDAL sysDAL = new SysDAL();

        /// <summary>
        /// 获取系统开账状态
        /// </summary>
        /// <param name="sysId"></param>
        /// <returns></returns>
        public bool GetOpenState(int sysId)
        {
            int isOpened = sysDAL.GetSysOpenState(sysId);
            if (isOpened == 1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 备份数据
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool BackupData(string path)
        {
            bool bl = false;
            string dbName = ConfigurationManager.AppSettings["DbName"].ToString();
            string backupName = dbName + DateTime.Today.ToString("yyyyMMdd");
            int reVal = sysDAL.BackupData(path, dbName, backupName);
            bl = reVal == 1 ? true : false;
            return bl;
        }
    }
}
