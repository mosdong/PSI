using PSI.Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI.Models.APIModels
{
	/// <summary>
	/// 接口日志
	/// </summary> 
	[Table("HttpWebAPILog")]
	//[Serializable]
	[PrimaryKey("ID")]
	public class HttpWebAPILog
    {
		public int ID { set; get; }
		public string RequestIP { set; get; }
		public string RequestUri { set; get; }
		public string RequestMethod { set; get; }
		public string RequestArguments { set; get; }
		public string ResponseResult { set; get; }
		public string StateCode { set; get; }
		public string Message { set; get; }
		/// <summary>
		/// 耗时 单位毫秒
		/// </summary>
		public double Milliseconds  { set; get; } 
		public DateTime? RequestDate { set; get; }
		public DateTime? ResponseDate { set; get; }
	}
}
