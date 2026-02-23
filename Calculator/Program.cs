namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.Write("Enter first number = ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Select the action you want to perform\n\n Addition(add)\n Subtraction(sub)\n Multiplication(mul)\n Division(div)\n\n operation to be performed = ");
            string choose = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter second number = ");
            int num2 = int.Parse(Console.ReadLine());
            if (choose == "add")
            {
                result = num1 + num2;
                Console.WriteLine("\nthe result of the operation = " + result);
            }
            else if (choose == "sub")
            {
                result = num1 - num2;
                Console.WriteLine("\nthe result of the operation = " + result);
            }
            else if (choose == "mul")
            {
                result = num1 * num2;
                Console.WriteLine("\nthe result of the operation = " + result);
            }
            else if (choose == "div")
            {
                result = num1 / num2;
                Console.WriteLine("\nthe result of the operation = " + result);
            }
            else
            {
                Console.WriteLine("\nERROR!");
            }
           

        }
    }
}
