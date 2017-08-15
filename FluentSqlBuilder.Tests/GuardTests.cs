using FluentSqlBuilder.Internal;
using NUnit.Framework;
using System;

namespace FluentSqlBuilder.Tests
{
    [TestFixture]
    public class GuardTests
    {
        [Test]
        public void NullGuardShouldThrowExceptionWhenNull()
        {
            Assert.Throws<ArgumentException>(() => Guard.Null((string)null, "Null message"));
        }
    }
}
