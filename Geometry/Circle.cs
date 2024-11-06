namespace Geometry
{
    public class Circle : IShape
    {
        #region Fields

        private readonly double _radius;

        #endregion

        #region Constructors

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным!");
            }

            _radius = radius;
        }

        #endregion

        #region Methods

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }

        #endregion
    }
}
