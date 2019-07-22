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
            merchant.AssignRomanNumberToVariable("prok is V").Should().Be("V");
            merchant.AssignRomanNumberToVariable("pish is X").Should().Be("X");
            merchant.AssignRomanNumberToVariable("tegj is L").Should().Be("L");
        }
    }
}
