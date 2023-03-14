// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int m=NumberInput("Введите число M: ");
int n=NumberInput("Введите число N: ");

if (n<m)
{
    int temp = n;
    n=m;
    m=temp;
}

Console.Write($"Сумма натуральных элементов в промежутке от меньшего до большего из M или N включительно: ");

Console.WriteLine(SumBetween(n, m));

int SumBetween(int n, int m)
{
    if (n == m) return n;
    else return n+SumBetween(n-1, m);        
}


int NumberInput(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}