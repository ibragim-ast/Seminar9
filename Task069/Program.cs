// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число A в целую степень B с помощью рекурсии.

int NumberToPower(int a, int b)
{
    if (b == 0)
        return 1;

    return a * NumberToPower(a, b - 1);
}

System.Console.WriteLine(NumberToPower(2, 3));

