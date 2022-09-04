// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
System.Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
System.Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int count = M;
int PrintNumbersM2N(int m, int n, int count)
{
    if (count == n)
    return m;

    
    return m + PrintNumbersM2N(m + 1, n, count + 1);
}

System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} = {PrintNumbersM2N(M, N, count)}");