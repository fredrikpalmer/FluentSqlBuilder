using FluentSqlBuilder.Components;
using NUnit.Framework;
using System;

namespace FluentSqlBuilder.Tests.Components
{
    [TestFixture]
    public class GivenOnConditionComponent
    {
        public class WhenCallingBuild
        {
            [Test]
            public void ItShouldMatchStringWhenEmpty()
            {
                var result = new OnConditionComponent("")
                        .GetValue();

                Assert.That(result.Trim() == "ON");
            }

            [Test]
            public void ItShouldMatchStringWhenNotEmpty()
            {
                var result = new OnConditionComponent("col1=col2")
                        .GetValue();

                Assert.That(result == "ON col1=col2");
            }

            [Test]
            public void ItShouldThrowWhenNull()
            {
                Assert.Throws<ArgumentException>(() => new OnConditionComponent(null).GetValue());
            }
        }
    }
}
