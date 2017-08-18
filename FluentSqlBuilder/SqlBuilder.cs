using FluentSqlBuilder.Components;
using FluentSqlBuilder.Internal;

namespace FluentSqlBuilder
{
    public class SqlBuilder : ISqlBuilder
    {
        internal ISqlQuery Query { get; }

        public SqlBuilder()
        {
            Query = new SqlQuery();
        }

        public ISqlBuilder Select(string columns)
        {
            Query.AddComponent(new SelectComponent(columns));
            return this;
        }

        public ISqlBuilder From(string table)
        {
            Query.AddComponent(new FromComponent(table));
            return this;
        }

        public ISqlBuilder InnerJoin(string table)
        {
            Query.AddComponent(new InnerJoinComponent(table));
            return this;
        }

        public ISqlBuilder LeftJoin(string table)
        {
            Query.AddComponent(new LeftJoinComponent(table));
            return this;
        }

        public ISqlBuilder RightJoin(string table)
        {
            Query.AddComponent(new RightJoinComponent(table));
            return this;
        }

        public ISqlBuilder On(string condition)
        {
            Query.AddComponent(new OnConditionComponent(condition));
            return this;
        }

        public ISqlBuilder Where(string column)
        {
            Query.AddComponent(new WhereComponent(column));
            return this;
        }

        public string GetQuery()
        {
            return Query.Build();
        }
    }
}
