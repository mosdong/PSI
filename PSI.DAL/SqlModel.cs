using System.Data.SqlClient;

namespace PSI.DAL
{
    public class SqlModel
    {
        //sql语句
        public string Sql { get; set; }
        //参数数组
        public SqlParameter[] SqlParaArray { get; set; }

    }
}
