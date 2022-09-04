// Задайте значение N. Напишите программу, которая выводит все натуральные числа от 1 до N

System.Console.WriteLine("Введите число N");
int num = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int N)
{
    if (N == 0)
    return;

    System.Console.Write($"{N} ");
    
    PrintNumbers(N -1);
}

PrintNumbers(num);

