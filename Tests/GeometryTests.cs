namespace Tests
{
    using Geometry;

    public class GeometryTests
    {
        [Fact]
        public void CreateTriangle_WithInvalidSides_ThrowsArgumentException()
        {
            double sideA = 1;
            double sideB = 2;
            double sideC = 3;

            var exception = Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));

            Assert.Equal("Сумма двух сторон треугольника не может быть меньше третьей!", exception.Message);
        }

        [Fact]
        public void GetTriangleArea_WithCorrectSides_GetCorrectArea()
        {
            double sideA = 3.5;
            double sideB = 4.1;
            double sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

            double actualArea = triangle.GetArea();

            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void CheckRightTriangle_WithCorrectRightTriangle_GetTrue()
        {
            double sideA = 5;
            double sideB = 12;
            double sideC = 13;
            var triangle = new Triangle(sideA, sideB, sideC);
            var sides = new[] { sideA, sideB, sideC };
            Array.Sort(sides);
            bool expectedIsRight = Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-10;

            bool actualIsRight = triangle.IsRight();

            Assert.Equal(expectedIsRight, actualIsRight);
        }

        [Fact]
        public void CheckRightTriangle_WithNotCorrectRightTriangle_GetFalse()
        {
            double sideA = 3;
            double sideB = 7;
            double sideC = 9;
            var triangle = new Triangle(sideA, sideB, sideC);
            var sides = new[] { sideA, sideB, sideC };
            Array.Sort(sides);
            bool expectedIsRight = Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-10;

            bool actualIsRight = triangle.IsRight();

            Assert.Equal(expectedIsRight, actualIsRight);
        }

        [Fact]
        public void CreateCircle_WithNegativeRadius_ThrowsArgumentException()
        {
            double radius = -5.4;

            var exception = Assert.Throws<ArgumentException>(() => new Circle(radius));

            Assert.Equal("Радиус не может быть отрицательным!", exception.Message);
        }

        [Fact]
        public void GetCircleArea_WithCorrectRadius_GetCorrectArea()
        {
            double radius = 15.8;
            var circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;

            double actualArea = circle.GetArea();

            Assert.Equal(expectedArea, actualArea);

        }
    }
}