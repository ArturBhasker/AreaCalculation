using System;
using System.Linq;

namespace ArturBkhasker.HomeMade.AreaCalculation
{
    public static class CheckingShapeCondition
    {
        /// <summary>
        /// Проверка - является ли треугольник прямоугольным
        /// </summary>
        /// <param name="firstSide"></param>
        /// <param name="secondSide"></param>
        /// <param name="thirdSide"></param>
        /// <returns></returns>
        public static bool IsTriangleRectangle(double firstSide, double secondSide, double thirdSide)
        {
            CheckValueMoreThanZero(firstSide, secondSide, thirdSide);

            var sides =
                new[]
                {
                    firstSide,
                    secondSide,
                    thirdSide
                };

            var greatestValue = sides
                .Max();

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return 2*Math.Pow(greatestValue, 2) == sides
                .Select(v => Math.Pow(v,2))
                .Sum();
        }

        private static void CheckValueMoreThanZero(params double[] sides)
        {
            foreach (var side in sides)
            {
                if (side <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(side), $"One side is below or equals zero: {side}");
                }
            }
        }
    }
}
