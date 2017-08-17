using FluentSqlBuilder.Constants;
using FluentSqlBuilder.Internal;

namespace FluentSqlBuilder.Components
{
    public class WhereComponent : ISqlComponent
    {
        public string Column { get; set; }

        public WhereComponent(string column)
        {
            Guard.Null(column, $"{nameof(column)} cannot be null.");

            Column = column;
        }

        public string GetValue()
        {
            return $"{SqlKeywords.Where} {Column}";
        }
    }
}
