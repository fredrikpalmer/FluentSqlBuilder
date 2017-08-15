using FluentSqlBuilder.Constants;
using FluentSqlBuilder.Internal;

namespace FluentSqlBuilder.Components
{
    public class SelectComponent : ISqlComponent
    {
        public string Columns { get; set; }

        public SelectComponent(string columns)
        {
            Guard.Null(columns, $"{nameof(columns)} cannot be null.");

            Columns = columns;
        }

        public string Build()
        {
            return $"{SqlKeywords.Select} {Columns}";
        }
    }
}
