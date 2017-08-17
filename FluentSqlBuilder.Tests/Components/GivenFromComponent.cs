using FluentSqlBuilder.Components;
using NUnit.Framework;
using System;

namespace FluentSqlBuilder.Tests.Components
{
    [TestFixture]
    public class GivenFromComponent
    {
        public class WhenCallingBuild
        {
            [Test]
            public void ItShouldMatchStringWhenEmpty()
            {
                var result = new FromComponent("")
                        .GetValue();

                Assert.That(result.Trim() == "FROM");
            }

            [Test]
            public void ItShouldMatchStringWhenNotEmpty()
            {
                var result = new FromComponent("Users")
                        .GetValue();

                Assert.That(result == "FROM Users");
            }

            [Test]
            public void ItShouldThrowWhenNull()
            {
                Assert.Throws<ArgumentException>(() => new FromComponent(null).GetValue());
            }
        }
    }
}
