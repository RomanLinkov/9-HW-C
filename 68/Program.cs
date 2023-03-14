// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
double n=NumberInput("Введите число n: ");
double m=NumberInput("Введите число m: ");

double res = Ackerman(n, m);

Console.WriteLine($"Функция Аккремана для {n} и {m} = {res}");

double Ackerman(double n, double m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Ackerman(n - 1, 1);
    else
      return Ackerman(n - 1, Ackerman(n, m - 1));
}

double NumberInput(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}