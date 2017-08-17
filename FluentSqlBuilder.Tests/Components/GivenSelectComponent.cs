using FluentSqlBuilder.Components;
using NUnit.Framework;
using System;

namespace FluentSqlBuilder.Tests.Components
{
    [TestFixture]
    public class GivenSelectComponent
    {
        public class WhenCallingBuild
        {
            [Test]
            public void ItShouldMatchStringWhenEmpty()
            {
                var result = new SelectComponent("")
                        .GetValue();

                Assert.That(result.Trim() == "SELECT");
            }

            [Test]
            public void ItShouldMatchStringWhenNotEmpty()
            {
                var result = new SelectComponent("*")
                        .GetValue();

                Assert.That(result == "SELECT *");
            }

            [Test]
            public void ItShouldThrowWhenNull()
            {
                Assert.Throws<ArgumentException>(() => new SelectComponent(null).GetValue());
            }
        }
    }
}
