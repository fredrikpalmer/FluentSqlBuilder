using FluentSqlBuilder.Constants;
using FluentSqlBuilder.Internal;

namespace FluentSqlBuilder.Components
{
    public class InnerJoinComponent : ISqlComponent
    {
        public string TableName { get; set; }

        public InnerJoinComponent(string tableName)
        {
            Guard.Null(tableName, $"{nameof(tableName)} cannot be null.");

            TableName = tableName;
        }

        public string GetValue()
        {
            return $"{SqlKeywords.InnerJoin} {TableName}";
        }
    }
}
