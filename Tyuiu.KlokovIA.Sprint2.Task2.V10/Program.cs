using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KlokovIA.Sprint2.Task2.V10.Lib;

namespace Tyuiu.KlokovIA.Sprint2.Task2.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Клоков И. А. | ИСПБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Клоков Иван Анатальевич | ИСПБ-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит    *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до    *");
            Console.WriteLine("* трех знаков после запятой;                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int result;
            DataService.PrintArea(DataService.Area.array);
            Console.Write("Введите значение x: ");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение y: ");

            int y = Convert.ToInt32(Console.ReadLine());
            x -= 1;
            y -= 1;
            Console.Clear();

            int[,] newArr = DataService.Area.array;
            result = DataService.Area.array[x, y];
            newArr[x, y] = 2;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService.PrintArea(DataService.Area.array);
            if (result == 1)
            {
                Console.WriteLine($"Точка ({x}, {y}) находится в закрашенной области");
            }
            else
            {
                Console.WriteLine($"Точка ({x}, {y}) не находится в закрашенной области");
            }
            Console.ReadLine();
        }
    }
}
