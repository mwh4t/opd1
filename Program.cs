using System;

namespace opd
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 разных числа:");
            int x = int.Parse(Console.ReadLine());  // считывание 1-го числа
            int y = int.Parse(Console.ReadLine());  // считывание 2-го числа
            int z = int.Parse(Console.ReadLine());  // считывание 3-го числа

            if (x < y && y < z)  // проверка, является ли x наименьшим, а z наибольшим
            {
                Console.WriteLine("{0}, {1}, {2}", x, y, z);
            }
            else if (y < x && x < z)  // проверка, является ли y наименьшим, а z наибольшим
            {
                Console.WriteLine("{0}, {1}, {2}", y, x, z);
            }
            else if (y < z && z < x)  // проверка, является ли y наименьшим, а x наибольшим
            {
                Console.WriteLine("{0}, {1}, {2}", y, z, x);
            }
            else if (z < y && y < x)  // проверка, является ли z наименьшим, а x наибольшим
            {
                Console.WriteLine("{0}, {1}, {2}", z, y, x);
            }
            else if (z < x && x < y)  // проверка, является ли z наименьшим, а y наибольшим
            {
                Console.WriteLine("{0}, {1}, {2}", z, x, y);
            }
            else  // числа - одинаковы
            {
                Console.WriteLine("Числа - одинаковы.");
            }

            Console.ReadLine();  // ожидание нажатия кнопки
        }
    }
}