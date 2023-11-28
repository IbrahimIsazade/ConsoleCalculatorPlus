namespace ConsoleCalculatorPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] typesOfCalc = { "Basic", "Advanced" };
            string userChoise;
            bool userResult;

            // Info about calculator
            Console.WriteLine("Console Calculator+ Alpha 1.0\nCreator: IbrahimIsazade\n");

            do
            {
                Console.WriteLine();
                // Showing all types of calculator
                foreach (var type in typesOfCalc)
                {
                    if (type != typesOfCalc[typesOfCalc.Length - 1])
                    {
                        Console.Write(type + ", ");
                    }
                    else
                    {
                        Console.Write(type);
                    }
                }

                // Getting user's choise
                Console.Write("\nWhich type of calculat would you like to use: ");
                userChoise = Console.ReadLine()!;


                if (userResult = typesOfCalc.Contains(userChoise))
                {
                    Console.WriteLine("Contains");
                }
                else
                {
                    Console.WriteLine("There's not this type of calculator. Please check, up and down letters.");
                }
            } while (userResult == false);

        }
    }
}