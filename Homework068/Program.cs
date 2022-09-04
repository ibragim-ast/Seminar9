// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();
System.Console.WriteLine("Доброго времени суток, Вячеслав!)");
System.Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.");
System.Console.WriteLine("Введите неотрицательное число M");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите неотрицательное число N");
int N = Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AckermanFunction(n - 1, 1);
    else
      return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}

System.Console.WriteLine($"Решение задачи: {AckermanFunction(N, M)}");
System.Console.WriteLine("Досвидания, Вячеслав! Спасибо за вашу работу и терпение)");


