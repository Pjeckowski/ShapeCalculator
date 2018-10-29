namespace Calculator
{
    class Calculator : IShapeCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
