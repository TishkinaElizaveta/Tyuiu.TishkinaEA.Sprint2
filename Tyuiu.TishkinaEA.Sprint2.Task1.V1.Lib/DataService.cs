using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TishkinaEA.Sprint2.Task1.V1.Lib
{
    public class DataService : ISprint2Task1V1
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            // Выполняем операции с нужными результатами
            result[0] = !(a == b);     // a == b     -> false
            result[1] = !(a != b);     // a != b     -> true
            result[2] = (a < c);      // a < c      -> true
            result[3] = (c > d);      // c > d      -> false
            result[4] = (a <= b);     // a <= b     -> true
            result[5] = (b >= d);     // b >= d     -> false

            return result;
        }
    }
}
