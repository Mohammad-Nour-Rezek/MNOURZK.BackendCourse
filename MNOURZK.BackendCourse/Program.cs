namespace MNOURZK.BackendCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Day 2
            //double number1, number2, sum, min, mult, dev = default;
            //string? firstName, lastName, fullName = string.Empty;

            //Console.WriteLine("\tCalculator App");

            //Console.Write("Please enter the first number: ");

            //number1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Please enter the second number: ");

            //number2 = Convert.ToDouble(Console.ReadLine());

            //sum = number1 + number2;

            //min = number1 - number2;

            //mult = number1 * number2;

            //dev = number2 / number2;

            //Console.WriteLine($"{number1} + {number2} = {sum}");
            //Console.WriteLine($"{number1} - {number2} = {min}");
            //Console.WriteLine($"{number1} * {number2} = {mult}");
            //Console.WriteLine($"{number1} / {number2} = {dev}");

            //Console.ReadKey();

            //Console.Write("Please enter your first name: ");

            //firstName = Console.ReadLine();

            //Console.Write("Please enter your last name: ");

            //lastName = Console.ReadLine();

            //fullName = firstName + " " + lastName;

            //Console.WriteLine(@$"Hello '{fullName}',
            //                     Your full name length is {fullName.Length}");

            //Console.WriteLine("\nThank you for using \vthe Calculator App.");

            #endregion

            #region Day 3

            float degree = default;

            Console.WriteLine("Please enter your degree:");

            degree = Convert.ToSingle(Console.ReadLine());

            if (degree >= 0 && degree < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (degree >= 50 && degree <= 65)
            {
                Console.WriteLine("Fair");
            }
            else if (degree >= 66 && degree <= 75)
            {
                Console.WriteLine("Good");
            }
            else if (degree >= 76 && degree <= 85)
            {
                Console.WriteLine("Very Good");
            }
            else if (degree >= 86 && degree <= 100)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Please enter a correct value in a range between 0 and 100");
            }

            bool wantContinueFlag = false;
            byte choice = default;
            string wantContinue = string.Empty;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("1) Good Morning");
                Console.WriteLine("2) Good Afternoon");
                Console.WriteLine("3) Good Evening");
                Console.WriteLine("4) Good Night");
                Console.Write("Please Enter Your Choice:");

                choice = Convert.ToByte(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Good Morning");
                        break;
                    case 2:
                        Console.WriteLine("Good Afternoon");
                        break;
                    case 3:
                        Console.WriteLine("Good Evening");
                        break;
                    case 4:
                        Console.WriteLine("Good Night");
                        break;
                    default:
                        Console.WriteLine("Incorrect Choice. Please try again.");
                        break;
                }

                Console.WriteLine("Do you want to continue? (Y/N)");

                wantContinue = Console.ReadLine().ToLower();

                switch (wantContinue)
                {
                    case "y":
                        wantContinueFlag = true;
                        break;
                    case "n":
                        wantContinueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect choice");
                        break;
                }

                Console.Clear();
            }
            while (wantContinueFlag);

            #endregion
        }
    }
}
