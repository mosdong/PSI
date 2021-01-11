using PSI.DAL;
using PSI.Models.APIModels;

namespace PSI.BLL
{
    public class HttpApiLogBLL
    {
        private HttpApiLogDAL apiLogDAL = new HttpApiLogDAL();
        public int AddLog(HttpWebAPILog webAPILog)
        {
          return  apiLogDAL.Add(webAPILog,"",1);
        }

        public bool UpdateLog(HttpWebAPILog webAPILog)
        {
           return apiLogDAL.Update(webAPILog, "ID,Milliseconds,ResponseDate,ResponseResult,StateCode","");
        }
    }
}
