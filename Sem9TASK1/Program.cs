/* Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от m до N . Выполнить с помощью рекурсии.
M, N = 5, 8 -> "6, 8"
M, N = 2, 4 -> "2, 4" */
using System;
using System.Collections.Generic;
using System.Linq;
 class Program
{
    static void Main(string[] args)
    {
        Console.Write("Напишите натуральное число 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Напишите натуральное число 2: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
    }
}