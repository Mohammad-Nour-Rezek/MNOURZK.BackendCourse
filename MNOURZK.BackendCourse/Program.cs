namespace MNOURZK.BackendCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Day 2
            //Console.WriteLine("Hello, Please enter a char:");

            //char result = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine((int)result); // ASCII value

            //int a, b, c = 10;

            //Console.WriteLine("result.GetType() " + result.GetType());

            //int comparingResult =  result.CompareTo('A');

            //Console.WriteLine("comparingResult " + comparingResult);

            //Console.WriteLine("result.GetTypeCode() " + result.GetTypeCode());

            //Console.WriteLine("result.Equals('A') " + result.Equals('A'));

            //string escapeChars = "Hello \"Mourad\"\nNew Line\tTab\\Backslash\v\vafter two lines\\ 'here' thanks";

            //int size = sizeof(char);           

            //Console.WriteLine("size " + size);

            //string name = "Mourad Nourzhanov";
            //Console.WriteLine("name.Contains(\"Mourad\") " + name.Contains("Mourad"));
            //Console.WriteLine(@"name.StartsWith(""Mourad"")" + name.StartsWith("Mourad"));
            //Console.WriteLine("name.EndsWith(\"Nourzhanov\")" + name.EndsWith("Nourzhanov"));
            //Console.WriteLine(name.IndexOf("Nourzhanov"));
            //Console.WriteLine(name.Insert(0, "Mr. "));
            //Console.WriteLine(name.ToLower());
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.Replace("Mourad", "John"));

            //Console.WriteLine(name.Substring(0, 6));
            //Console.WriteLine(name.Trim());
            //Console.WriteLine(name.Length);
            //Console.WriteLine(string.IsNullOrEmpty(name));
            //Console.WriteLine(string.IsNullOrWhiteSpace(name));
            //Console.WriteLine("string.Join(\" \", name)" + string.Join(" ", name));
            //Console.WriteLine(string.Concat(name, " - ", "Backend Developer"));
            //Console.WriteLine(string.Compare("abc", "ABC", true));  
            //Console.WriteLine(string.Compare("abc", "ABC", false));
            //Console.WriteLine(string.Format("Hello, {0}", name));
            //Console.WriteLine($"Hello, {name}");
            //Console.WriteLine($"Hello, {name}. Your name length is {name.Length}");
            //Console.WriteLine($"Hello, {name}. Today is {DateTime.Now.ToString("D")}");
            //Console.WriteLine($"Hello, {name}. Today is {DateTime.Now:dddd, MMMM dd yyyy}");
            //Console.WriteLine($"Hello, {name}. Current time is {DateTime.Now:HH:mm:ss tt}");
            //Console.WriteLine($"Hello, {name}. Current time is {DateTime.Now:h:mm:ss tt}");
            //Console.WriteLine($"Hello, {name}. Current time is {DateTime.Now:hh:mm:ss tt}");
            //Console.WriteLine($"Hello, {name}. Current time is {DateTime.Now:HH:mm:ss.fff tt}");
            //Console.WriteLine($"Hello, {name}. Current time is {DateTime.Now:hh:mm:ss.fff tt}");
            //Console.WriteLine($"Hello, {name}. Current time is {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff tt}");
            //Console.WriteLine($"Hello, {name}. Current time is {DateTime.Now:yyyy-MM-dd hh:mm:ss.fff tt}");
            //Console.WriteLine($"Hello, {name[0]}");
            //Console.WriteLine($"Hello, {name[name.Length - 1]}");

            //Console.ReadLine();

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

            //float degree = 0.0f;

            //Console.WriteLine("Please enter your degree:");

            //degree = Convert.ToSingle(Console.ReadLine());

            //if (degree >= 0 && degree < 50)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else if (degree >= 50 && degree <= 65)
            //{
            //    Console.WriteLine("Fair");
            //}
            //else if (degree >= 66 && degree <= 75)
            //{
            //    Console.WriteLine("Good");
            //}
            //else if (degree >= 76 && degree <= 85)
            //{
            //    Console.WriteLine("Very Good");
            //}
            //else if (degree >= 86 && degree <= 100)
            //{
            //    Console.WriteLine("Excellent");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a correct value in a range between 0 and 100");
            //}

            //bool wantContinueFlag = false;
            //byte choice = default;
            //string wantContinue = string.Empty;

            //do
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("1) Good Morning");
            //    Console.WriteLine("2) Good Afternoon");
            //    Console.WriteLine("3) Good Evening");
            //    Console.WriteLine("4) Good Night");
            //    Console.Write("Please Enter Your Choice:");

            //    choice = Convert.ToByte(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine("Good Morning");
            //            break;
            //        case 2:
            //            Console.WriteLine("Good Afternoon");
            //            break;
            //        case 3:
            //            Console.WriteLine("Good Evening");
            //            break;
            //        case 4:
            //            Console.WriteLine("Good Night");
            //            break;
            //        default:
            //            Console.WriteLine("Incorrect Choice. Please try again.");
            //            break;
            //    }

            //    Console.WriteLine("Do you want to continue? (Y/N)");

            //    wantContinue = Console.ReadLine().ToLower();

            //    switch (wantContinue)
            //    {
            //        case "y":
            //            wantContinueFlag = true;
            //            break;
            //        case "n":
            //            wantContinueFlag = false;
            //            break;
            //        default:
            //            Console.WriteLine("Incorrect choice");
            //            break;

            //    }

            //    Console.Clear();
            //}
            //while (wantContinueFlag);

            // *** Book Example ***
            // Inclusive lower bound but exclusive upper bound.
            //int number = Random.Shared.Next(minValue: 1, maxValue: 7);
            //Console.WriteLine($"My random number is {number}");
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("One");
            //        break; // Jumps to end of switch statement.
            //    case 2:
            //        Console.WriteLine("Two");
            //        goto case 1;
            //    case 3: // Multiple case section.
            //    case 4:
            //        Console.WriteLine("Three or four");
            //        goto case 1;
            //    case 5:
            //        goto A_label;
            //    default:
            //        Console.WriteLine("Default");
            //        break;
            //} // End of switch statement.
            //Console.WriteLine("After end of switch");
            //A_label:
            //Console.WriteLine($"After A_label");

            //int i = 0;
            //for (int j, f = 1; i <= 10 && j == 1; )
            //{
            //    Console.WriteLine($"i = {i}");
            //    //i++;
            //    i += 2;
            //    if (i % 2 == 0 || i == 5)
            //        Console.WriteLine("continue");
            //        continue;

            //    Console.WriteLine("I value " + i);

            //    if (i == 6)
            //        break;
            //}
            //Console.ReadKey();

            #endregion

            #region Day 4

            #region Calculator with Functions

            //Calculator();

            #endregion

            #endregion

        }

        public static void Calculator()
        {
            float number1, number2 = 0.0f;

            Console.WriteLine("\tCalculator App");
            Console.Write("Please enter the first number: ");

            number1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Please enter the second number: ");

            number2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Addition Result is: {Add(number1, number2)}");
            Console.WriteLine($"Subtraction Result is: {Subtract(number1, number2)}");
            Console.WriteLine($"Multiplication Result is: {Multiply(number1, number2)}");

            if (number2 == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                Console.WriteLine($"Division Result is: {Divide(number1, number2)}");
            }

            Console.ReadKey();

            Console.WriteLine("\nThank you for using \vthe Calculator App.");
        }

        public static float Add(float number1, float number2)
        {
            return number1 + number2;
        }

        public static float Subtract(float number1, float number2)
        {
            return number1 - number2;
        }

        public static float Multiply(float number1, float number2)
        {
            return number1 * number2;
        }

        public static float Divide(float number1, float number2)
        {
            return number1 / number2;
        }
    }
}
