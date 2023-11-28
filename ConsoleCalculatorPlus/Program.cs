namespace ConsoleCalculatorPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] typesOfCalc = { "Basic", "Advanced" },
                     basicMethods = { "+", "-", "*", "/", "^" };
            string userChoiseCalc, userChoiseMethod, again;
            float number1, number2;
            int? result;
            bool? userResult;

            // Info about calculator
            Console.WriteLine("Console Calculator+ Alpha 1.5\nCreator: IbrahimIsazade\n");

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
                        LogEveryElement(basicMethods);
                        userChoiseMethod = Input("\nEnter your method");
                        if (Array.Exists(basicMethods, method => method == userChoiseMethod))
                        {
                            number1 = float.Parse(Input("Enter first number"));
                            number2 = float.Parse(Input("Enter second number"));
                            result = (int?)CalculateThis(userChoiseMethod, number1, number2);
                            Console.WriteLine($"{number1}{userChoiseMethod}{number2} = {result}");
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

        static string Input(string text)
        {
            Console.Write(text + ": ");
            string res = Console.ReadLine()!;
            return res;
        }

        static double CalculateThis(string method, float num1, float num2)
        {
            switch (method)
            {
                case "+":
                    return num1 + num2;
                    break;
                case "-":
                    return num1 - num2;
                    break;
                case "*":
                    return num1 * num2;
                    break;
                case "/":
                    return 5 / 2;
                    break;
                case "**":
                    for (float power = num1; num2 != 1; num2--)
                    {
                         num1 *= power;
                    }
                    return num1;
                    break;
                case "sqrt":
                    return 0;
                    break;
                default:
                    return 0;
            }
        }
    }
}