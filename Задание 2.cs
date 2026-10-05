class Program
{
    static void Main()
    {
        double a, b, result;
        string oper;

        a = Convert.ToDouble(Console.ReadLine());
        oper = Console.ReadLine();
        b = Convert.ToDouble(Console.ReadLine());

        result = 0;

        switch (oper)
        {
            case "+":
                result = a + b;
                break;

            case "-":
                result = a - b;
                break;

            case "*":
                result = a * b;
                break;

            case "/":
                result = a / b;
                break;

            case "%":
                result = a % b;
                break;

            case "^":
                result = Math.Pow(a, b);
                break;

            case "//":
                result = Math.Sqrt(a);
                break;
        }

        Console.WriteLine(result);
        Console.ReadKey();
    }
}