using FluentSqlBuilder.Constants;
using FluentSqlBuilder.Internal;

namespace FluentSqlBuilder.Components
{
    public class LeftJoinComponent : ISqlComponent
    {
        public string TableName { get; set; }

        public LeftJoinComponent(string tableName)
        {
            Guard.Null(tableName, $"{nameof(tableName)} cannot be null.");

            TableName = tableName;
        }

        public string Build()
        {
            return $"{SqlKeywords.LeftJoin} {TableName}";
        }
    }
}
