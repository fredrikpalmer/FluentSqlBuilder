using FluentSqlBuilder.Components;

namespace FluentSqlBuilder.Internal
{
    internal interface ISqlQuery
    {
        void AddComponent(ISqlComponent component);

        string GetQuery();
    }
}
