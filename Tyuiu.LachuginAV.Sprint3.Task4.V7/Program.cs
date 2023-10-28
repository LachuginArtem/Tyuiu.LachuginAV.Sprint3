using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.LachuginAV.Sprint3.Task4.V7.Lib;

namespace Tyuiu.LachuginAV.Sprint3.Task4.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue; int stopValue;

            Console.Title = "Спринт #3 | Выполнил: Лачугин. А.В. | АСОиУБ-23-3";
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Спринт #3" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Вариант 7" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Выполнил: Лачугин Артем Викторович | АСОиУБ-23-3" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая запрашивает у пользователя данные, вычисляет *");
            Console.WriteLine("* их и печатает их на экран.                                              *");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine("Введите пременную старта суммирования: ");
            startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите пременную предела суммирования: ");
            stopValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine($"Сумма ряда равна:\n{ds.Calculate(startValue, stopValue)}");
            Console.ReadKey();
        }
    }
}