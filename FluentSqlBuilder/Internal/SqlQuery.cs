using FluentSqlBuilder.Components;
using System.Collections.Generic;
using System.Text;

namespace FluentSqlBuilder.Internal
{
    internal class SqlQuery : ISqlQuery
    {
        public IList<ISqlComponent> Components { get; }

        public SqlQuery()
        {
            Components = new List<ISqlComponent>();
        }

        public void AddComponent(ISqlComponent component)
        {
            Guard.Null(component, "Component cannot be null.");

            Components.Add(component);
        }

        public string Build()
        {
            var sb = new StringBuilder();
            foreach (var item in Components)
            {
                sb.Append($"{item.Build()} ");
            }

            return sb.ToString();
        }

    }
}
