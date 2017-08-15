using FluentSqlBuilder.Constants;
using FluentSqlBuilder.Internal;

namespace FluentSqlBuilder.Components
{
    public class FromComponent : ISqlComponent
    {
        public string TableName { get; set; }

        public FromComponent(string tableName)
        {
            Guard.Null(tableName, $"{nameof(tableName)} cannot be null.");

            TableName = tableName;
        }

        public string Build()
        {
            return $"{SqlKeywords.From} {TableName}";
        }
    }
}
