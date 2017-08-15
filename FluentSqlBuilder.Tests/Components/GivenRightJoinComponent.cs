using FluentSqlBuilder.Components;
using NUnit.Framework;
using System;

namespace FluentSqlBuilder.Tests.Components
{
    [TestFixture]
    public class GivenRightJoinComponent
    {
        public class WhenCallingBuild
        {
            [Test]
            public void ItShouldMatchStringWhenEmpty()
            {
                var result = new RightJoinComponent("")
                        .Build();

                Assert.That(result.Trim() == "RIGHT JOIN");
            }

            [Test]
            public void ItShouldMatchStringWhenNotEmpty()
            {
                var result = new RightJoinComponent("Table")
                        .Build();

                Assert.That(result == "RIGHT JOIN Table");
            }

            [Test]
            public void ItShouldThrowWhenNull()
            {
                Assert.Throws<ArgumentException>(() => new RightJoinComponent(null).Build());
            }
        }
    }
}
