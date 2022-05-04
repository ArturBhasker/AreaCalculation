using System;
using Xunit;

namespace ArturBkhasker.HomeMade.AreaCalculation.UnitTests
{
    public class CheckingShapeConditionTests
    {
        [Fact]
        public void IsTriangleRectangle_CommonSides_Success()
        {
            //Assemble
            var side1 = 3;
            var side2 = 4;
            var side3 = 5;

            //Act
            var res = CheckingShapeCondition.IsTriangleRectangle(side1, side2, side3);

            //Assert
            Assert.True(res);
        }

        [Fact]
        public void IsTriangleRectangle_CommonSides_Fail()
        {
            //Assemble
            var side1 = 3;
            var side2 = 4;
            var side3 = 4;

            //Act
            var res = CheckingShapeCondition.IsTriangleRectangle(side1, side2, side3);

            //Assert
            Assert.False(res);
        }

        [Fact]
        public void IsTriangleRectangle_TooBigNumbers_Fail()
        {
            //Assemble
            var side1 = int.MaxValue;
            var side2 = int.MaxValue;
            var side3 = int.MaxValue;

            //Act
            var res = CheckingShapeCondition.IsTriangleRectangle(side1, side2, side3);

            //Assert
            Assert.False(res);
        }

        [Fact]
        public void IsTriangleRectangle_ValuesBelowZero_Exception()
        {
            //Assemble
            var side1 = -3;
            var side2 = -4;
            var side3 = -4;

            //Act
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => CheckingShapeCondition.IsTriangleRectangle(side1, side2, side3));

            //Assert
            Assert.NotNull(exception);
        }
    }
}
