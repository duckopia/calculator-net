namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("------------------------");

            // Main calculator loop
            while (true)
            {
                // Get the first number
                Console.Write("Enter the first number: ");
                double num1 = GetNumberFromUser();

                // Get the operator
                Console.Write("Enter the operator (+, -, *, /): ");
                char operation = GetOperatorFromUser();

                // Get the second number
                Console.Write("Enter the second number: ");
                double num2 = GetNumberFromUser();

                // Perform the calculation
                double result = Calculate(num1, operation, num2);

                // Display the result
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
                Console.WriteLine();

                // Ask if the user wants to continue
                Console.Write("Do you want to perform another calculation? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }
        }

        // Function to get a valid number from the user
        static double GetNumberFromUser()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        // Function to get a valid operator from the user
        static char GetOperatorFromUser()
        {
            while (true)
            {
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (op == '+' || op == '-' || op == '*' || op == '/')
                {
                    return op;
                }
                else
                {
                    Console.WriteLine("Invalid operator. Please enter +, -, *, or /.");
                }
            }
        }

        // Function to perform the calculation based on the operator
        static double Calculate(double num1, char operation, double num2)
        {
            switch (operation)
            {
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                case '*': return num1 * num2;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        return double.NaN; // Not a Number
                    }
                    return num1 / num2;
                default:
                    Console.WriteLine("Invalid operator.");
                    return double.NaN;
            }
        }
    }
}
