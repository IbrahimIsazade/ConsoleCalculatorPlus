namespace ConsoleCalculatorPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] typesOfCalc = { "Basic", "Advanced" },
                     basicMethods = { "+", "-", "*", "/", "^", "sqrt" };
            string userChoiseCalc, userChoiseMethod, again;
            double number1, number2;
            double? result;
            bool? userResult;

            // Info about calculator
            Console.WriteLine("Console Calculator+ Alpha 2.0\nCreator: IbrahimIsazade\n");

            // Getting type of calculator
            do
            {
                Console.WriteLine();
                // Showing all types of calculator
                LogEveryElement(typesOfCalc);

                // Getting user's choise
                Console.Write("\nWhich type of calculator would you like to use: ");
                userChoiseCalc = Console.ReadLine()!;

                userResult = null;
                if (typesOfCalc.Contains(userChoiseCalc) == false)
                {
                    userResult = false;
                    Console.WriteLine("There's not this type of calculator. Please check, up and down letters.");
                }
            } while (userResult == false);

            // Getting method
            switch (userChoiseCalc)
            {
                case "Basic":
                    do
                    {
                        Console.WriteLine();
                        number1 = double.Parse(Input("Enter first number"));
                        LogEveryElement(basicMethods);
                        userChoiseMethod = Input("\nEnter your method");
                        if (Array.Exists(basicMethods, method => method == userChoiseMethod))
                        {
                            if (userChoiseMethod != "sqrt")
                            {

                                number2 = double.Parse(Input("Enter second number"));
                            }
                            result = (double?)CalculateThis(userChoiseMethod, number1, number2 = 2);
                            Console.WriteLine($"{number1} {userChoiseMethod} {number2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid method choice. Please choose a method that you see on the list.");
                        }
                        again = Input("Would you like to continue ? (y/n)");

                    } while (again == "y");
                    break;
                case "Advanced":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Unexpected error: Can't find type of calculator.");
                    break;
            }

        }

        // As name of func
        static void LogEveryElement(string[] args)
        {
            foreach (var item in args)
            {
                if (item != args[args.Length - 1])
                {
                    Console.Write(item + ", ");
                }
                else
                {
                    Console.Write(item);
                }
            }
        }

        // ReadLine
        static string Input(string text)
        {
            Console.Write(text + ": ");
            string res = Console.ReadLine()!;
            return res;
        }

        // Calculator
        static double CalculateThis(string method, double num1, double num2)
        {
            switch (method)
            {
                case "+":
                    return num1 + num2;

                case "-":
                    return num1 - num2;

                case "*":
                    return num1 * num2;

                case "/":
                    return (double)num1 / num2;

                case "**":
                    for (double power = num1; num2 != 1; num2--)
                    {
                         num1 *= power;
                    }
                    return num1;

                case "sqrt":
                    return Math.Sqrt(num1);

                default:
                    return 0;
            }
        }
    }
}