using FluentSqlBuilder.Constants;
using FluentSqlBuilder.Internal;

namespace FluentSqlBuilder.Components
{
    public class RightJoinComponent : ISqlComponent
    {
        public string TableName { get; set; }

        public RightJoinComponent(string tableName)
        {
            Guard.Null(tableName, $"{nameof(tableName)} cannot be null.");

            TableName = tableName;
        }

        public string Build()
        {
            return $"{SqlKeywords.RightJoin} {TableName}";
        }
    }
}
