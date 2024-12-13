using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TishkinaEA.Sprint2.Task3.V19.Lib
{
    public class DataService : ISprint2Task3V19
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                // y = x^2 + ((x + 1) / (x - 1))^x
                double fraction = (x + 1) / (x - 1);
                y = Math.Pow(x, 2) + Math.Pow(fraction, x);
            }
            else if (x == 0)
            {
                // y = (x^2 + cos(x^2) + 13) / (x^2 + sin(x^2) + 9)
                double numerator = Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) + 13;
                double denominator = Math.Pow(x, 2) + Math.Sin(Math.Pow(x, 2)) + 9;
                y = numerator / denominator;
            }
            else if (-23 < x && x < 2)
            {
                // y = (1 + 1 / x^2)^x
                y = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
            }
            else if (x < -23)
            {
                // y = x + 10x - (1 / x)
                y = x + 10 * x - (1 / x);
            }
            else
            {
                throw new ArgumentException("Invalid input: x does not satisfy any condition.");
            }

            // Округляем до 3 знаков после запятой
            return Math.Round(y, 3);
        }
    }
}
