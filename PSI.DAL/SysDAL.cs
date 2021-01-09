using PSI.Common;
using PSI.DbUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI.DAL
{
    public class SysDAL
    {
        /// <summary>
        /// 获取开账状态
        /// </summary>
        /// <param name="sysId"></param>
        /// <returns></returns>
        public int GetSysOpenState(int sysId)
        {
            string sql = "select IsOpened from SysInfos where SysId=@sysId";
            SqlParameter paraId = new SqlParameter("@sysId", sysId);
            object oIsOpened = SqlHelper.ExecuteScalar(sql, 1, paraId);
            if (oIsOpened != null && oIsOpened.ToString() != "")
                return oIsOpened.GetInt();
            else
                return 0;
        }

        /// <summary>
        /// 备份数据
        /// </summary>
        /// <param name="path"></param>
        /// <param name="dbName"></param>
        /// <param name="backupName"></param>
        /// <returns></returns>
        public int BackupData(string path,string dbName,string backupName )
        {
            SqlParameter[] paras =
            {
                new SqlParameter("@savePath",path),
                new SqlParameter("@dbName",dbName),
                new SqlParameter("@bakName",backupName),
                new SqlParameter("@return",SqlDbType.Int,4)
            };
            paras[3].Direction = ParameterDirection.ReturnValue;//返回值参数
            SqlHelper.ExecuteNonQuery("sp_BackupDB", 2, paras);
            return paras[3].Value.GetInt();
        }
    }
}
