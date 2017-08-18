using NUnit.Framework;

namespace FluentSqlBuilder.Tests
{
    [TestFixture]
    public class GivenSqlBuilder
    {
        public class WhenSqlQueryNotEmpty
        {
            [Test]
            public void ItShouldReturnSqlString()
            {
                var sqlBuilder = new SqlBuilder();
                var sqlString = sqlBuilder.Select("*").From("Users AS u").GetQuery();

                Assert.That(sqlString.Trim() == "SELECT * FROM Users AS u");
            }
        }

        public class WhenSqlQueryEmpty
        {
            [Test]
            public void ItShouldReturnEmpty()
            {
                var sqlBuilder = new SqlBuilder();
                var sqlString = sqlBuilder.GetQuery();

                Assert.That(sqlString.Trim() == "");
            }
        }
    }
}
