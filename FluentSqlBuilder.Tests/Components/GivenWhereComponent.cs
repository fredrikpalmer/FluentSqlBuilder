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
                        .GetValue();

                Assert.That(result.Trim() == "WHERE");
            }

            [Test]
            public void ItShouldMatchStringWhenNotEmpty()
            {
                var result = new WhereComponent("col1=col2")
                        .GetValue();

                Assert.That(result == "WHERE col1=col2");
            }

            [Test]
            public void ItShouldThrowWhenNull()
            {
                Assert.Throws<ArgumentException>(() => new WhereComponent(null).GetValue());
            }
        }
    }
}
