using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace StringCalculator
{
    public class CalculatorTests
    {
        [Fact]
        public void EmptyStringReturnsZero()
        {
            Assert.Equals(0, Calculator.Add(""));
        }
    }
}
