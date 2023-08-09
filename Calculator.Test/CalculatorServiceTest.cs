using Calculator.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Test
{
    public class CalculatorServiceTest
    {
        public CalculatorService CalculatorService { get; set; }
        public CalculatorServiceTest()
        {
            CalculatorService = new CalculatorService();
        }

        [Fact]
        public void Add_StaticActionExecutes_ReturnSum()
        {
            // Arrange
            int x = 5;
            int y = 10;

            // Act
            var actualTotal = CalculatorService.Add(x, y);

            // Assert
            Assert.Equal(15, actualTotal);
        }

        [Theory]
        [InlineData(5, 10, 15)]
        public void Add_DynamicActionExecutes_ReturnSum(int x, int y, int expectedTotal)
        {
            // Act
            var actualTotal = CalculatorService.Add(x, y);

            // Assert
            Assert.Equal(expectedTotal, actualTotal);
        }
    }
}
