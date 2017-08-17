using FluentSqlBuilder.Constants;
using FluentSqlBuilder.Internal;

namespace FluentSqlBuilder.Components
{
    public class OnConditionComponent : ISqlComponent
    {
        public string Column { get; set; }

        public OnConditionComponent(string column)
        {
            Guard.Null(column, "Condition cannot be null.");

            Column = column;
        }

        public string GetValue()
        {
            return $"{SqlKeywords.On} {Column}";
        }
    }
}