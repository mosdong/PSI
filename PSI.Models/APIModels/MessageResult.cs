using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI.Models.APIModels
{
    public class MessageResult
    {

        public static MessageResult Success(string message="操作成功",object obj=null)
        {
            MessageResult result = new MessageResult()
            {
                Message = message,
                IsOK = true,
                Data=obj
            };
            return result;
        }

        
        public static MessageResult Success(object obj)
        {
            return Success("操作成功", obj);
        }


        public static MessageResult Fail(string message="操作失败")
        {
            MessageResult result = new MessageResult()
            {
                Message = message,
                IsOK = false
            };
            return result;
        }
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsOK { set; get; }

        /// <summary>
        /// 返回消息
        /// </summary>
        public string Message { set; get; }

        /// <summary>
        /// 数据源
        /// </summary>
        public object Data { set; get; }
    }
}
