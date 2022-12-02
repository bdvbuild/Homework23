using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.


namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите число: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 10;

            FactorialAsync(n);

            for (int i = 0; i < n; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Выполнение Main: {i} секунд");
            }
            Console.WriteLine("Main завершен");
            Console.ReadKey();
        }
        static void Factorial(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
                Thread.Sleep(500);
            }
            Console.WriteLine($"Подсчет окончен. {n}! = {s}");
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
