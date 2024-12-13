using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TishkinaEA.Sprint2.Task1.V1.Lib
{
    public class DataService : ISprint2Task1V1
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = (a == b);  // a == b
            result[1] = (c != d);  // c != d
            result[2] = (a < c);   // a < c
            result[3] = (b > d);   // b > d
            result[4] = (c <= d);  // c <= d
            result[5] = (a >= b);  // a >= b
            bool logicalOperation1 = (a == b) && (c != d);  // Пример: (a == b) && (c != d)
            bool logicalOperation2 = (a < c) || (b > d);   // Пример: (a < c) || (b > d)
            bool logicalOperation3 = !(c <= d);             // Пример: !(c <= d)
            bool logicalOperation4 = (a >= b) ^ (a < c);    // Пример: (a >= b) ^ (a < c)

            // Можно комбинировать как хотите:
            result[0] = logicalOperation1;  // Пример: использовать логическую операцию для результата
            result[1] = logicalOperation2;
            result[2] = logicalOperation3;
            result[3] = logicalOperation4;

            return result;
        }
    }
}
