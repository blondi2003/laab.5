class Program
{ 
    static void Main(string[] args)
    {
        double sum = 0;
        double comp = 1;
        Console.WriteLine("Введите х=");
        double x=Convert.ToDouble(Console.ReadLine());
        int n = 10;

        for (int k=1;k<=n;k++)
        {
            sum += x / (Math.Exp(x) * Math.Pow(k, 2));
            comp *= x / (Math.Exp(x) * Math.Pow(k, 2));
            Console.WriteLine($"sum({k})={sum}");
            Console.WriteLine($"comp({k})={comp}");
        }

        Console.WriteLine($"Сумма {sum}");
        Console.WriteLine($"Произведение {comp}");
    }
}
