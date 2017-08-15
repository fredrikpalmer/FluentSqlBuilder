using FluentSqlBuilder.Components;
using NUnit.Framework;
using System;

namespace FluentSqlBuilder.Tests.Components
{
    [TestFixture]
    public class GivenLeftJoinComponent
    {
        public class WhenCallingBuild
        {
            [Test]
            public void ItShouldMatchStringWhenEmpty()
            {
                var result = new LeftJoinComponent("")
                        .Build();

                Assert.That(result.Trim() == "LEFT JOIN");
            }

            [Test]
            public void ItShouldMatchStringWhenNotEmpty()
            {
                var result = new LeftJoinComponent("Table")
                        .Build();

                Assert.That(result == "LEFT JOIN Table");
            }

            [Test]
            public void ItShouldThrowWhenNull()
            {
                Assert.Throws<ArgumentException>(() => new LeftJoinComponent(null).Build());
            }
        }
    }
}
