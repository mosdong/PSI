using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPSI.FModels
{
       public  class ChooseModel
        {
                /// <summary>
                /// 类别代码
                /// </summary>
                public string TypeCode { get; set; }
                /// <summary>
                /// 要设置值的Form
                /// </summary>
                public Form FGet { get; set; }

                /// <summary>
                /// 账号
                /// </summary>
                public string UName { get; set; }
        }
}
