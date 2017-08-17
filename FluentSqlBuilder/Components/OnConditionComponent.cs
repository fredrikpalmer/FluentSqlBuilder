using FluentSqlBuilder.Constants;
using FluentSqlBuilder.Internal;

namespace FluentSqlBuilder.Components
{
    public class OnConditionComponent : ISqlComponent
    {
        public string Condition { get; set; }

        public OnConditionComponent(string condition)
        {
            Guard.Null(condition, "Condition cannot be null.");

            Condition = condition;
        }

        public string GetValue()
        {
            return $"{SqlKeywords.On} {Condition}";
        }
    }
}