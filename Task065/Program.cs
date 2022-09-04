﻿// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.

System.Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

void PrintNumbersM2N(int m, int n)
{
    if (m > n)
    return;

    Console.Write($"{m} ");

    PrintNumbersM2N(m + 1, n);
}

PrintNumbersM2N(M, N);