using FluentSqlBuilder.Components;
using NUnit.Framework;
using System;

namespace FluentSqlBuilder.Tests.Components
{
    [TestFixture]
    public class GivenWhereComponent
    {
        public class WhenCallingBuild
        {
            [Test]
            public void ItShouldMatchStringWhenEmpty()
            {
                var result = new WhereComponent("")
                        .Build();

                Assert.That(result.Trim() == "WHERE");
            }

            [Test]
            public void ItShouldMatchStringWhenNotEmpty()
            {
                var result = new WhereComponent("col1=col2")
                        .Build();

                Assert.That(result == "WHERE col1=col2");
            }

            [Test]
            public void ItShouldThrowWhenNull()
            {
                Assert.Throws<ArgumentException>(() => new WhereComponent(null).Build());
            }
        }
    }
}
