
namespace ExtensionMethods
{
    public sealed class MyData
    {
        private double D1, D2, D3;

        public MyData(double d1, double d2, double d3)
        {
            D1 = d1;
            D2 = d2;
            D3 = d3;
        }

        public double Sum()
        {
            return D1 + D2 + D3;
        }
    }
}
