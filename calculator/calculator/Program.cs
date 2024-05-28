internal class Program
{
    private static void Main(string[] args)
    {
        int num1,num2;
        string operation;
        Console.WriteLine("Hello, welcome to the calculator");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("please enter your first number");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("--------------------------------");
        Console.WriteLine("please enter your second number");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("--------------------------------");
        Console.WriteLine("what type of operation you need\n");
        Console.WriteLine("for adding enter a" +
            "\nfor substracting enter s" +
            "\nfor multiblying enter m" +
            "\nfor divisoin enter d");
        operation = Console.ReadLine();
        Console.WriteLine("--------------------------------");
        switch (operation)
        {
            case "a":
                Console.WriteLine($"Result of {num1} + {num2} is: {num1 + num2}");
                break;
            case "s":
                Console.WriteLine($"Result of {num1} - {num2} is: {num1 - num2}");
                break;
            case "m":
                Console.WriteLine($"Result of {num1} * {num2} is: {num1 * num2}");
                break;
            case "d":
                if (num2 != 0)
                {
                    Console.WriteLine($"Result of {num1} / {num2} is: {num1 / (double)num2}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }
    }
}