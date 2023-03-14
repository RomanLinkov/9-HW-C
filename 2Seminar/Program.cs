Console.Clear();

int number=NumberInput("Введите число: ");
int power=NumberInput("Введите степень числа: ");

int PowerNumber(int n, int p)
{
    if (p==0) return 1;
    else return n*PowerNumber(n, p-1);
}


Console.WriteLine($"Возвдённое в степень: {PowerNumber(number, power)}");

int NumberInput(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}