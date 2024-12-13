using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TishkinaEA.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            if (k < 1 || k > 365)
            {
                throw new ArgumentException("Некорректный номер дня. Допустимые значения: 1-365.");
            }

            // Определяем день недели с использованием сокращенной формы switch
            return (k % 7) switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                0 => "Воскресенье",
                _ => throw new InvalidOperationException("Неверный расчет дня недели.")
            };
        }
    }
}
