class Program
{ 
static void Main()
{
    const int maxDigits = 5;

    Console.WriteLine("Введите число: ");

    if (!int.TryParse(Console.ReadLine(), out int number))
    {
        Console.WriteLine("Введены неверные данные! Вы должны ввести число");
        return;
    }

    int digits = DigitsCount(number);

    int diff = maxDigits - digits;

    if (diff > 0)
    {
        while (diff > 0)
        {
            Console.Write('0');
            diff--;
        }
        Console.Write(number);
    }
    else
    {
        if (diff < 0)
        {
            while (diff < 0)
            {
                number /= 10;
                diff++;
            }
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine(number);
        }
    }
}

//Функция для подсчета количества разрядов
private static int DigitsCount(int number)
{
    int digits = 0;
    while (number > 0)
    {
        number /= 10;
        digits++;
    }

    return digits;
}
}    


