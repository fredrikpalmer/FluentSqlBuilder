namespace FluentSqlBuilder
{
    public interface ISqlBuilder
    {
        ISqlBuilder Select(string columns);

        ISqlBuilder From(string table);

        ISqlBuilder InnerJoin(string table);

        ISqlBuilder LeftJoin(string table);

        ISqlBuilder RightJoin(string table);

        ISqlBuilder On(string condition);

        ISqlBuilder Where(string condition);

        string GetQuery();
    }
}
