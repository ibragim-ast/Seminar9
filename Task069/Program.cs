// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число A в целую степень B с помощью рекурсии.

int SumNumbers(int a, int b)
{
    if (b == 0)
        return 1;

    return a * SumNumbers(a, b - 1);
}

System.Console.WriteLine(SumNumbers(2, 3));

