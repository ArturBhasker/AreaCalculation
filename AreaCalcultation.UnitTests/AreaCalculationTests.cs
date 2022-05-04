using System;
using Xunit;

namespace ArturBkhasker.HomeMade.AreaCalculation.UnitTests
{
    public class AreaCalculationTests
    {
        [Fact]
        public void CalculateTriangleArea_ThreeCommonSides_Success()
        {
            //Assemble
            var firstSide = 3;
            var secondSide = 4;
            var thirdSide = 5;

            //Act
            var area = AreaCalculation.CalculateTriangleArea(firstSide, secondSide, thirdSide);

            //Assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void CalculateTriangleArea_TooBigNumbers_Exception()
        {
            //Assemble
            var firstSide = double.MaxValue;
            var secondSide = double.MaxValue;
            var thirdSide = double.MaxValue;

            //Act
            var exception = Assert.Throws<NotFiniteNumberException>(() => AreaCalculation.CalculateTriangleArea(firstSide, secondSide, thirdSide));

            //Assert
            Assert.NotNull(exception);
        }

        [Fact]
        public void CalculateTriangleArea_ValuesBelowZero_Exception()
        {
            //Assemble
            var firstSide = -3;
            var secondSide = -4;
            var thirdSide = -5;

            //Act
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => AreaCalculation.CalculateTriangleArea(firstSide, secondSide, thirdSide));

            //Assert
            Assert.NotNull(exception);
        }


        [Fact]
        public void CalculateCircleArea_CommonRadius_Success()
        {
            //Assemble
            var radius = 1;

            //Act
            var area = AreaCalculation.CalculateCircleArea(radius);

            //Assert
            Assert.InRange(area, 3, 4);
        }

        [Fact]
        public void CalculateCircleArea_TooBigNumbers_Exception()
        {
            //Assemble
            var radius = double.MaxValue;

            //Act
            var exception = Assert.Throws<NotFiniteNumberException>(() => AreaCalculation.CalculateCircleArea(radius));

            //Assert
            Assert.NotNull(exception);
        }

        [Fact]
        public void CalculateCircleArea_ValuesBelowZero_Exception()
        {
            //Assemble
            var radius = -3;

            //Act
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => AreaCalculation.CalculateCircleArea(radius));

            //Assert
            Assert.NotNull(exception);
        }

        [Fact]
        public void CalculateRectangleTriangleArea_CommonLegs_Success()
        {
            //Assemble
            var leg1 = 3;
            var leg2 = 4;

            //Act
            var area = AreaCalculation.CalculateRectangleTriangleArea(leg1, leg2);

            //Assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void CalculateRectangleTriangleArea_TooBigNumbers_Exception()
        {
            //Assemble
            var leg1 = double.MaxValue;
            var leg2 = double.MaxValue;

            //Act
            var exception = Assert.Throws<NotFiniteNumberException>(() => AreaCalculation.CalculateRectangleTriangleArea(leg1, leg2));

            //Assert
            Assert.NotNull(exception);
        }

        [Fact]
        public void CalculateRectangleTriangleArea_ValuesBelowZero_Exception()
        {
            //Assemble
            var leg1 = -3;
            var leg2 = -3;

            //Act
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => AreaCalculation.CalculateRectangleTriangleArea(leg1, leg2));

            //Assert
            Assert.NotNull(exception);
        }
    }
}