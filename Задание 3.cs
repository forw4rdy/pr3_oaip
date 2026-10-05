class Program
{
    static void Main()
    {
        double a, b, c, d, x1, x2;

        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());

        d = b * b - 4 * a * c;

        Console.WriteLine("D = " + d);

        if (d > 0)
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
        else if (d == 0)
        {
            x1 = -b / (2 * a);

            Console.WriteLine("x = " + x1);
        }
        else
        {
            Console.WriteLine("Корней нет");
        }

        Console.ReadKey();
    }
}