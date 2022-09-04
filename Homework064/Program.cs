// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

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