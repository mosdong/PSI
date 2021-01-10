using System;

namespace PSI.Common.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string Name { get; protected set; }
        public TableAttribute(string tableName)
        {
            this.Name = tableName;
        }

    }
}
