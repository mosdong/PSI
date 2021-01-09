using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PSI.Common
{
    public static class HttpHelper
    {
        /// <summary>
        /// get请求
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static string Get(string uri)
        {
            //Get请求中请求参数等直接拼接在url中
            WebRequest request = WebRequest.Create(uri);

            //返回对Internet请求的响应
            WebResponse resp = request.GetResponse();

            //从网络资源中返回数据流
            Stream stream = resp.GetResponseStream();

            StreamReader sr = new StreamReader(stream, Encoding.UTF8);

            //将数据流转换文字符串
            string result = sr.ReadToEnd();

            //关闭流数据
            stream.Close();
            sr.Close(); 
            return result;
        }


        public static string Post<T>(T value,string uri)
        {
            string data = JsonConvert.SerializeObject(value);
            WebRequest request = WebRequest.Create(uri);
            request.ContentType = "application/json";
            request.Method = "POST";
            var coding = Encoding.UTF8;
            //将字符串数据转化为字节串,这也是POST请求与GET请求区别的地方
            byte[] buffer = coding.GetBytes(data);

            //用于将数据写入Internet资源
            Stream stream = request.GetRequestStream();
            //request.ContentLength = buffer.Length;
            stream.Write(buffer, 0, buffer.Length); 
            WebResponse response = request.GetResponse();

            //从网络资源中返回数据流
            stream = response.GetResponseStream();

            StreamReader sr = new StreamReader(stream, coding);

            //将数据流转换文字符串
            string result = sr.ReadToEnd();

            //关闭流数据
            stream.Close();
            sr.Close();

            return result;
        }
    }
}
