namespace FluentSqlBuilder.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlBuilder = new SqlBuilder();
            var sqlString = sqlBuilder
                .Select("u.Id, u.Name")
                .From("Users AS u")
                .InnerJoin("Orders AS o")
                .On("o.UserId=u.UserId")
                .Where("u.UserId=@UserId")
                .GetQuery();

            System.Console.WriteLine(sqlString);

            System.Console.ReadLine();
        }
    }
}
