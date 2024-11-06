namespace MNOURZK.BackendCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tCalculator App");

            Console.Write("Please enter the first number: ");

            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the second number: ");

            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
            Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");

            Console.ReadKey();

            Console.Write("Please enter your first name: ");

            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");

            string lastName = Console.ReadLine();

            string fullName = firstName + " " + lastName;

            Console.WriteLine(@$"Hello '{fullName}',
                                 Your full name length is {fullName.Length}");

            Console.WriteLine("\nThank you for using \vthe Calculator App.");
        }
    }
}
