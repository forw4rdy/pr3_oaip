class Program
{
    static void Main()
    {
        double a, b;
        string oper, result;

        a = Convert.ToDouble(Console.ReadLine());
        oper = Console.ReadLine();
        b = Convert.ToDouble(Console.ReadLine());

        result = "Ошибка";

        switch (oper)
        {
            case "+":
                result = (a + b).ToString();
                break;

            case "-":
                result = (a - b).ToString();
                break;

            case "*":
                result = (a * b).ToString();
                break;

            case "/":
                result = (a / b).ToString();
                break;
        }

        Console.WriteLine(result);
        Console.ReadKey();
    }
}