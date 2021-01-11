using Newtonsoft.Json;
using PSI.BLL;
using PSI.Models.APIModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace PSI.API.Filter
{
    public class ActionLogAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 全局请求ID号
        /// </summary>
        private static long ActionId { get; set; }
        /// <summary>
        /// 客户端IP地址
        /// </summary>
        private string ClientIp { get; set; }
        /// <summary>
        /// 请求ID号
        /// </summary>
        private long RequestId { get; set; }

        /// <summary>
        /// 请求的接口
        /// </summary>
        private string controllername { get; set; }
        private const string Key = "action";
        private bool _IsDebugLog = true;
        private HttpWebAPILog log;
        private HttpApiLogBLL httpApiLogBLL = new HttpApiLogBLL();
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            log = new HttpWebAPILog();
            RequestId = ActionId++;
            var strary = actionContext.Request.RequestUri.AbsolutePath.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            controllername = strary[1];
            ClientIp = ((HttpContextWrapper)actionContext.Request.Properties["MS_HttpContext"]).Request.UserHostAddress;
            if (ClientIp == "::1")
            {
                ClientIp = "localhost";
            }
            var par = GetArguments(actionContext);
            log.RequestArguments = par;
            log.RequestIP = ClientIp ?? "localhost";
            log.RequestMethod = actionContext.Request.Method.ToString();
            log.RequestUri = actionContext.Request.RequestUri.ToString();
            log.RequestDate = DateTime.Now;
            var id= httpApiLogBLL.AddLog(log);
            log.ID = id;
            if (_IsDebugLog)
            {
                Stopwatch stopWatch = new Stopwatch();

                actionContext.Request.Properties[Key] = stopWatch; 

                Debug.Print(JsonConvert.SerializeObject(actionContext.ActionArguments));

                stopWatch.Start();
            }


        }

   
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            if (_IsDebugLog)
            {
                Stopwatch stopWatch = actionExecutedContext.Request.Properties[Key] as Stopwatch;

                if (stopWatch != null)
                {

                    stopWatch.Stop();

                    string actionName = actionExecutedContext.ActionContext.ActionDescriptor.ActionName;

                    string controllerName = actionExecutedContext.ActionContext.ActionDescriptor.ControllerDescriptor.ControllerName;

                    Debug.Print(actionExecutedContext.Response.Content.ReadAsStringAsync().Result);

                    Debug.Print(string.Format(@"[{0}/{1} 用时 {2}ms]", controllerName, actionName, stopWatch.Elapsed.Milliseconds));
                    log.Milliseconds = stopWatch.Elapsed.Milliseconds;
                }
            }
            log.ResponseDate = DateTime.Now;
            var response =  actionExecutedContext.Response.Content.ReadAsStringAsync().Result;
            log.ResponseResult = response;
            httpApiLogBLL.UpdateLog(log);
        }

        /// <summary>
        /// 获取请求参数
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        private string GetArguments(HttpActionContext actionContext)
        {
            string postStr = "";
            var test = actionContext.ActionArguments;
            foreach (var b in test)
            {
                var post = actionContext.ActionArguments[b.Key];

                if (null != post)
                {
                    Type t = post.GetType();
                    var str = "";
                    if (typeof(string) == t)
                    {
                        str = $"{b.Key}:{post}";
                        str = "{" + str + "}";
                    }
                    else
                    {
                        var typeArr = t.GetProperties();

                        foreach (var a in typeArr.OrderBy(x => x.Name))
                        {
                            var name = a.Name;
                            var v = a.GetValue(post, null);
                            if (v == null)
                            {
                                str += $"{name}:参数为null";
                                continue;
                            }
                            string curreV = v.ToString();
                            if (v.GetType() != typeof(string))
                            {
                                curreV = JsonConvert.SerializeObject(v);
                            }
                            if (null != v && v.ToString() != "")
                            {
                                str += @"""" + name + @""":" + @"""" + curreV + @""",";
                            }
                        }
                        str = str.TrimEnd(',');
                        str = @"{" + str + "}";
                    }

                    postStr += str + ",";
                }
            }
            return postStr.TrimEnd(',');
        }


    }
}