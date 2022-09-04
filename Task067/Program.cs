// Напишите программу, которая на вход принимает число и возвращает сумму его цифр

int SumNumbers(int num)
{
    if (num == 0)
        return 0;
    
    return (num % 10) + SumNumbers(num / 10);
}

System.Console.WriteLine(SumNumbers(632));