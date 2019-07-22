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

        [Fact]
        public void CsubtractionIV()
        {
            string input = "IV";
            var obj = new RomanToNumeralConvertor();
            obj.Convert(input).Should().Be("4");
        }

        [Fact]
        public void XsubtractionC()
        {
            string input = "XC";
            var obj = new RomanToNumeralConvertor();
            obj.Convert(input).Should().Be("90");
        }

        [Fact]
        public void CsubtractionDM()
        {
            string input = "CDM";
            var obj = new RomanToNumeralConvertor();
            obj.Convert(input).Should().Be("Invalid Format");
        }

        [Fact]
        public void IaddII()
        {
            string input = "III";
            var obj = new RomanToNumeralConvertor();
            obj.Convert(input).Should().Be("3");
        }
        [Fact]
        public void Check()
        {
            string input = "MCMXLIV";
            var obj = new RomanToNumeralConvertor();
            obj.Convert(input).Should().Be("1944");
        }
        [Fact]
        public void Check1()
        {
            string input = "MMVI";
            var obj = new RomanToNumeralConvertor();
            obj.Convert(input).Should().Be("2006");
        }
    }
}
