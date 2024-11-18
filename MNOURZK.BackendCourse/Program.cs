namespace MNOURZK.BackendCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, sum, min, mult, dev = default;
            string? firstName, lastName, fullName = default;

            Console.WriteLine("\tCalculator App");

            Console.Write("Please enter the first number: ");

            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the second number: ");

            number2 = Convert.ToDouble(Console.ReadLine());

            sum = number1 + number2;

            min = number1 - number2;

            mult = number1 * number2;

            dev = number2 / number2;

            Console.WriteLine($"{number1} + {number2} = {sum}");
            Console.WriteLine($"{number1} - {number2} = {min}");
            Console.WriteLine($"{number1} * {number2} = {mult}");
            Console.WriteLine($"{number1} / {number2} = {dev}");

            Console.ReadKey();

            Console.Write("Please enter your first name: ");

            firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");

            lastName = Console.ReadLine();

            fullName = firstName + " " + lastName;

            Console.WriteLine(@$"Hello '{fullName}',
                                 Your full name length is {fullName.Length}");

            Console.WriteLine("\nThank you for using \vthe Calculator App.");
        }
    }
}
