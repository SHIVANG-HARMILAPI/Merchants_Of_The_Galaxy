using System;
using Xunit;
using FluentAssertions;
namespace Merchants_Of_The_Galaxy.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckRomanNumberOfVariable()
        {
            var merchant = new Merchants();
            merchant.AssignRomanNumberToVariable("glob is I").Should().Be("I");
        }
    }
}
