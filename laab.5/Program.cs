class Program
{
    static void Main(string[] args)
    { 
        double f, x, k;
        for (x = -1; x <= 1; x += 0.1)
        {
            for (k = 1; k <= 10; k += 1)
            {
                f = Math.Round ( x / (Math.Exp(x) * Math.Pow(k, 2)),3);
                Console.Write($"{f}" + " " + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");
        Console.WriteLine("Следующий способ");

        double g;
        double m = -1.0;
        double n = 1.0;
        while (n <= 10)
        {
            while (m < 1.1)
            {
                g = Math.Round(m / (Math.Exp(m) * Math.Pow(n, 2)), 3);

                m = m + 0.1;
                Console.Write($"{g}" + " " + " ");
            }
            m = m- 2.1;
            n = n+ 1;
            Console.WriteLine();
        }
        Console.WriteLine(" ");
        Console.WriteLine("Следующий способ");
    
        double w;
        double i = -1;
        double t = 1;
        do
        {
            do
            {
                w = Math.Round(i / (Math.Exp(x) * Math.Pow(t, 2)), 3);
                i = i + 0.1;
                Console.Write($"{w}" + " " + " ");
            }
            while (i < 1.1);
            i = i - 2.1;
            t = t + 1;
            Console.WriteLine();
        }
        while (t <= 10);

        Console.WriteLine("");
    }
}

