using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TishkinaEA.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double distanceFromCenter = Math.Sqrt(x * x + y * y);
            if (distanceFromCenter > 1)
            {
                return false;
            }

            if (y >= x && y >= -x && x >= 0)
            {
                return true;
            }

            return false;
        }
    }
}
