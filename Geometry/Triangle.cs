namespace Geometry
{
    public class Triangle : IShape
    {
        #region Fields

        private readonly double _sideA, _sideB, _sideC;

        #endregion

        #region Constructors

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValid(sideA, sideB, sideC))
            {
                throw new ArgumentException("Сумма двух сторон треугольника не может быть меньше третьей!");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        #endregion

        #region Methods

        public double GetArea()
        {
            double semiPerimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }

        public bool IsRight()
        {
            var sides = new[] { _sideA, _sideB, _sideC };
            Array.Sort(sides);

            return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-10;
        }

        private bool IsValid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        #endregion
    }
}
