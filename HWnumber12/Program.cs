using HWnumber12.Classes;
using System;
using System.Reflection;
using System.Threading;

namespace HWnumber12
{
    internal class Program
    {
        static void Zadanie1()
        {
            Console.WriteLine("Задание 1. Потоки выводят на экран числа от 1 до 10\n");
            Thread currentThread = Thread.CurrentThread;

            Thread myThread1 = new Thread(Print1);
            Thread myThread2 = new Thread(Print2);
            Thread myThread3 = new Thread(Print3);

            myThread1.Start();

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"Первый поток: {i}");
                Thread.Sleep(3);
            }
            void Print1() { }

            myThread2.Start();
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine($"Второй поток: {i}");
                    Thread.Sleep(30);
                }
            }
            void Print2() { }

            myThread3.Start();
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine($"Трейтий поток: {i}");
                    Thread.Sleep(30);
                }
            }
            void Print3() { }

        }

        static void Zadanie3()
        {
            Console.WriteLine("\nЗадание 3. Программа возвращает имена методов объекта\n\nСписок всех найденных методов:\n");

            Type type = typeof(Refl);

            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance);
            foreach (MethodInfo method in type.GetMethods())
            {
                Console.WriteLine($"{method.Name}");
            }
        }

        static void Main(string[] args)
        {

            Zadanie1();
            Console.WriteLine("\nНажмите ВВОД, чтобы перейти к следующему заданию :Р");
            Console.ReadKey();
            Console.Clear();

            Zadanie3();
            Console.WriteLine("\nНажмите ВВОД, чтобы завершить работу программы :З");
            Console.ReadKey();

        }
    }
}
