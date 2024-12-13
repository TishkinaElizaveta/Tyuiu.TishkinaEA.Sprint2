using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TishkinaEA.Sprint2.Task0.V11.Lib
{
    public class DataService : ISprint2Task0V11
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[]
           {
                x == y,   // Сравнение на равенство
                x != y,   // Сравнение на неравенство
                x < y,    // Меньше
                x > y,    // Больше
                x <= y,   // Меньше или равно
                x >= y    // Больше или равно
           };
        }
    }
}
