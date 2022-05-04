using System;

namespace ArturBkhasker.HomeMade.AreaCalculation
{
    public static class AreaCalculation
    {
        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double CalculateCircleArea(double radius)
        {
            CheckValueMoreThanZero(radius);

            var area = Math.PI * radius * radius;
            
            if (double.IsInfinity(area))
            {
                throw new NotFiniteNumberException(nameof(area));
            }

            return area;
        }

        /// <summary>
        /// Вычисление площиди треугольника по трем сторонам
        /// </summary>
        /// <param name="firstSide"></param>
        /// <param name="secondSide"></param>
        /// <param name="thirdSide"></param>
        /// <returns></returns>
        public static double CalculateTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            CheckValueMoreThanZero(firstSide, secondSide, thirdSide);

            var halfPerimeter = (firstSide + secondSide + thirdSide) / 2;

            var area = Math.Sqrt(
                halfPerimeter * 
                (halfPerimeter - firstSide) *
                (halfPerimeter - secondSide) *
                (halfPerimeter - thirdSide)
            );

            if (double.IsInfinity(area))
            {
                throw new NotFiniteNumberException(nameof(area));
            }

            return area;
        }

        /// <summary>
        /// Вычисление площади прямоугольного треугольника
        /// </summary>
        /// <param name="firstLeg"></param>
        /// <param name="secondLeg"></param>
        /// <returns></returns>
        public static double CalculateRectangleTriangleArea(double firstLeg, double secondLeg)
        {
            CheckValueMoreThanZero(firstLeg, secondLeg);

            var area = firstLeg * secondLeg / 2;

            if (double.IsInfinity(area))
            {
                throw new NotFiniteNumberException(nameof(area));
            }

            return area;
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
