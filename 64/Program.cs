// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int number=NumberInput("Введите число: ");

if (number<1) 
{
    Console.WriteLine("Число должно быть натуральным. Попробуйте снова.");
    return;
}

Console.Write($"N = ->  ");

PrintNumberSequence(number);

void PrintNumberSequence(int n)
{
    if (n > 0)
    {
        Console.Write($"{n} ");
        PrintNumberSequence(n - 1);
    }
}
Console.WriteLine();

int NumberInput(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}