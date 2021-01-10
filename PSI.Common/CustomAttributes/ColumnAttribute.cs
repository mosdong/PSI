using System;

namespace PSI.Common.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public string ColName { get; protected set; }
        public ColumnAttribute(string colName)
        {
            this.ColName = colName;
        }
    }
}
