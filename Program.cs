namespace Calculator
{
  class Program
    {
        static void Main(string[] args)
        {
            while (true)
                {
                string oper, yorn;
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter +, - , *, or / :  ");
                oper = Console.ReadLine();

                if (oper == "+")
                {
                    Console.WriteLine(num1 + num2);
                }
                else if (oper == "-")
                {
                    Console.WriteLine(num1 - num2);
                }
                else if (oper == "*")
                {
                    Console.WriteLine(num1 * num2);
                }
                else if (oper == "/")
                {
                    Console.WriteLine(num1 / num2);
                }
                Console.ReadLine();
                Console.Write("Continue?: ");
                yorn = Console.ReadLine();
                if (yorn == "y")
                {
                    continue;
                }
                else if (yorn == "n")
                {
                    break;
                }
            }

        }
    }
}
