// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

int number=NumberInput("Введите число: ");

int SumDigits(int n)
{
    if (n==0) return 0;
    else return n%10+SumDigits(n/10);
}


Console.WriteLine($"Сумма цифр: {SumDigits(number)}");

int NumberInput(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}