using FluentSqlBuilder.Components;
using NUnit.Framework;
using System;

namespace FluentSqlBuilder.Tests.Components
{
    [TestFixture]
    public class GivenInnerJoinComponent
    {
        public class WhenCallingBuild
        {
            [Test]
            public void ItShouldMatchStringWhenEmpty()
            {
                var result = new InnerJoinComponent("")
                        .Build();

                Assert.That(result.Trim() == "INNER JOIN");
            }

            [Test]
            public void ItShouldMatchStringWhenNotEmpty()
            {
                var result = new InnerJoinComponent("Table")
                        .Build();

                Assert.That(result == "INNER JOIN Table");
            }

            [Test]
            public void ItShouldThrowWhenNull()
            {
                Assert.Throws<ArgumentException>(() => new InnerJoinComponent(null).Build());
            }
        }
    }
}
