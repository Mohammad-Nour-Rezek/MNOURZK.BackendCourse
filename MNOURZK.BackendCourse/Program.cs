using MNOURZK.BackendCourse.Basics;
using MNOURZK.BackendCourse.Basics.Advance_C_;
using MNOURZK.BackendCourse.Basics.OOP_Assignment5;
using MNOURZK.BackendCourse.Basics.Polymorphism;

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

            #region Arrays

            //int[,] temp;

            //temp = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            //Console.WriteLine("2D Array Elements:");

            //for (int i = 0; i < temp.GetLength(0); i++) // rows
            //{
            //    for (int j = 0; j < temp.GetLength(1); j++) // columns
            //    {
            //        Console.Write(temp[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //// jagged array
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[] { 1, 2, 3 };
            //jaggedArray[1] = new int[] { 4, 5 };
            //jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            //Console.WriteLine("Jagged Array Elements:");

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();

            //Console.WriteLine("Thank you for using the Array Example.");


            //ushort occurence = getoccurenceCount(new int[] { 1, 2, 3, 4, 5, 1, 2, 1, 1 }, 1);

            //Console.WriteLine($"The number of occurence is: {occurence}");

            //Console.ReadKey();


            //int[] reversedArray = ReverseArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            //Console.WriteLine("Reversed Array: " + string.Join(", ", reversedArray));

            //Console.ReadKey();


            //int[] arrayWithoutDuplication = RemoveDuplication(new int[] { 1, 2, 3, 4, 5, 1, 2, 1, 1 });

            //Console.WriteLine("Array Without Duplication: " + string.Join(", ", arrayWithoutDuplication));

            //Console.ReadKey();

            #endregion

            #endregion

            #region OOP

            #region Day 5

            //Car car1 = new Car();
            //Car car2 = new Car();

            //car1.speed = 100;
            //car2.speed = 200;

            //car1.setColor('b');
            //car2.setColor('r');

            //car1.displayInfo();
            //car2.displayInfo();

            //Employee[] employees = new Employee[3];
            // we can have a loop that loop on the array and take the information from the user
            // then assign the object to the array


            //employees[0] = new Employee();
            //employees[0].name = "Mourad Nourzhanov";
            //employees[0].setPhone("0791234567");
            //employees[0].setSalary(7000);
            //employees[0].increaseSalary(1000);

            //employees[1] = new Employee();
            //employees[1].setPhone("0751234567");
            //employees[1].setSalary(4000);
            //employees[1].increaseSalary(-1000);

            //employees[0].displayInfo();

            //employees[1].displayInfo();

            //Console.ReadKey();

            #endregion

            #region Day 6

            //BankAccount nourAccount = new BankAccount(initialBalance:4500) { name = "Nour2", SSN = 55, Mobile = "0654" };
            ////nourAccount.Setbalance(1000);
            ////decimal currentBalance = nourAccount.GetBalance("password");
            //decimal currentBalance = nourAccount.Balance;
            //nourAccount.Balance = 2500.68m;
            ////nourAccount.SSN = 987654321;
            //decimal newBalance = nourAccount.Balance;
            //Console.WriteLine($"Current Balance: {currentBalance}, new balance is: {newBalance}");
            //Console.WriteLine($"The SSN is: {nourAccount.SSN}, Name: {nourAccount.name}");

            //BankAccount abdullahAccount = new BankAccount("Abdullah", "password", 2000);
            ////decimal abdullahBalance = abdullahAccount.GetBalance("password");
            //decimal abdullahBalance = abdullahAccount.Balance;
            //Console.WriteLine($"Abdullah Balance: {abdullahBalance}");

            //BankAccountV2 bankAccountV2 = new BankAccountV2(name:"Test") { Email = "avc" };
            ////bankAccountV2.Balance = 5000;
            //Console.WriteLine($"Bank Account V2 - Name: {bankAccountV2.Name}, Balance: {bankAccountV2.Balance}, Id: {bankAccountV2.Id}, Email: {bankAccountV2.Email}");


            //Employee employee1 = new Employee();
            //employee1.Salary = 8000;
            //Console.WriteLine($"Employee1 Id: {employee1.Id}, Name: {employee1.Name}, ");

            //Student student1 = new Student("Nour", 30, studentId: "12345", "A");
            ////student1.Grade = "A";
            ////Console.WriteLine($"Student1 Name: {student1.Name}, Age: {student1.Age}, Grade: {student1.Grade}, StudentId: {student1.StudentId}");
            //student1.DisplayStudentInfo();
            //student1.UpdateGrade("A+");
            //student1.DisplayStudentInfo();

            //Indexer
            //StudentList studentList = new StudentList(5);
            //studentList[0] = new Student("Nour", 30, "5", "A+");

            //Console.WriteLine($"Student name is: {studentList[0].Name}");
            //Console.WriteLine($"Student name is: {studentList[0]}, {studentList["first"].Age}");

            //// instead of doing it this way, we have the indexer
            //studentList.AddStudent(0, "Nour");
            //string student = studentList.GetStudent(0);

            //need to be checked later
            //Student student = studentList.FindStudentByName("Nour");

            //Student student1 = new Student("Nour", 30, "5", "A+");
            //Student student2 = new Student("Mourad", 31, "6", "A");

            //student1 = student2; // both variables will point to the same object in the heap

            //UpdateStudentName(student2); // we are passing the reference to the function

            //student1.DisplayStudentInfo();
            //student2.DisplayStudentInfo();

            //string city = "KSA";

            ////Employee employee1 = new Employee() { Name = "Nour", Phone = "0791234567", Salary = 7000, Email = "test@domail.com" };
            //Employee employee1 = new Employee(
            //    email: "test2@domail.com",                
            //    streetName: "Olaya",
            //    streetNumber: "10",
            //    postalCode: "19100",
            //    country: "KSA",
            //    city: "Makkah",
            //    latitude: 165.21f,
            //    longitude: 846.23f,
            //    name: "Nour123",
            //    phone: "0796254784",
            //    salary: 7000
            //    );

            //// association
            //employee1.supportStudent(student1, 500);

            //// aggregation, because inside employee we keeped a referance to the bank account
            //BankAccount bankAccount = new BankAccount() { name = "Nour", Email = "test2@domail.com" };
            //employee1.GetRelatedBankAccount(bankAccount);

            //Console.WriteLine($"Employee Address: {employee1.Address.StreetName}, {employee1.Address.Country}");

            // Assignment Day4 OOP
            // Association
            //School school = new School() { Name = "ABC School" };
            //Teacher teacher = new Teacher() { Id = 1, Name = "Mr. Smith" };
            //school.OrganizeClasses(teacher);

            //// Assignment Aggregation
            //Team team = new Team(new Player[3]);
            //team[0] = new Player() { Name = "Player 1", Position = "Forward" };
            //team[1] = new Player() { Name = "Player 2", Position = "Midfielder" };
            //team[2] = new Player() { Name = "Player 3", Position = "Defender" };
            //Console.WriteLine($"Team Players:");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Name: {team[i].Name}, Position: {team[i].Position}");
            //}

            //House house = new House(3) { Address = "123 Main St" };
            //house.AddRoom("Living Room", 25.5f);
            //house.AddRoom("Bedroom", 15.0f);
            //house.AddRoom("Kitchen", 10.0f);

            //house.DisplayHouseInfo();

            // Inheritance
            //Rectangle rectangle = new Rectangle() { Color = "Red", Dim2 = 20, Thickness = 5 };
            //float area = rectangle.Area();
            //rectangle.Display();
            //rectangle.Draw();

            //Console.WriteLine("============");

            //Square square = new Square() { Color = "Blue", Dim2 = 15, Thickness = 3, SquareProp = 10 };
            //float squareArea = square.Area();
            //square.Display();
            //square.DrawSquare();

            //Teacher2[] teachers = new Teacher2[2];
            //Student2[] students = new Student2[3];

            // Assignment Day5 OOP
            //Teacher2 teacher1 = new Teacher2() { Name = "Mr. Smith", Age = 40, Subject = "Math" };
            //Teacher2 teacher2 = new Teacher2() { Name = "Ms. Johnson", Age = 35, Subject = "Science" };

            //Student2 student1 = new Student2() { Name = "Alice", Age = 20, Grade = 90 };
            //Student2 student2 = new Student2() { Name = "Bob", Age = 22, Grade = 85 };
            //Student2 student3 = new Student2() { Name = "Charlie", Age = 21, Grade = 88 };

            //ProjectTeam projectTeam = new ProjectTeam(1, 2)
            //{
            //    TeamName = "Project A"                
            //};

            //projectTeam.AssignTeacher(teacher1);

            //projectTeam.AssignStudent(student1);
            //projectTeam.AssignStudent(student2);

            //projectTeam.GetTeamDetails();

            // polymorphism
            // comment aafter abstract class creation
            ////Elecetronic elecetronic = new Elecetronic() { Price = 1000, Color = "Black" };
            //Mobile mobile = new Mobile() { Storage = 256 };
            //Tablet tablet = new Tablet() { WithPen = true };

            //// in Polymorphism can declare reference from the parent class and assign the object from the child class
            //Elecetronic elecetronicDevice = new Mobile() { Storage = 500 };

            //Elecetronic elecetronicTablet = new Tablet() { WithPen = false };
            //Mobile mobileDevice = new Tablet() { WithPen = true };

            //// called upcasting because we are casting from derived class to base class
            //// so the base class is smaller than the derived class as an object
            //Elecetronic e = mobileDevice; // upcasting, safe

            //// exeplicit casting issue example
            //Mobile mobileDevice2 = new Mobile();
            ////Elecetronic el = new Laptop();
            ////Elecetronic el = new Elecetronic();
            //Elecetronic el = new Tablet();

            //Mobile mobileDevice3;

            // the solution is to check if the object is from a type or not
            //if (el is Mobile)
            //{
            //    mobileDevice3 = (Mobile)el;
            //    mobileDevice3.Storage = 128;
            //}

            // a new way in a new c# version, use only declaration with is in the same line
            //Mobile mobileDevice3;
            // declaration inside the is condition, if its from the type will cast it,
            // if not will be null and no need for else

            // way we can use
            //var mb = el is Mobile md2;

            //if (el is Mobile mobileDevice3)                                             
            //{
            //    //mobileDevice3 = (Mobile)el;
            //    mobileDevice3.Storage = 128;
            //}
            //else
            //{
            //    mobileDevice3 = null;
            //    Console.WriteLine("el is not from Mobile type");
            //}

            //Console.WriteLine($"the mobile device 2: {mobileDevice3.Storage}");


            ////Tablet tablet2 = new Mobile() { Storage = 128 } as Tablet; // downcasting, unsafe, will return null if the object is not from the same type

            //// downcasting, unsafe, will throw exception if the object is not from the same type
            //// why its unsafe, because the Mobile class does not have all the properties and methods of the Tablet class
            //// so this casting from base class to derived class is not always valid
            //// from samall to big
            ////Tablet tablet3 = (Tablet)new Mobile() { Storage = 128 }; 

            //mobileDevice.DisplayInfo();

            //CompanyV2 company = new CompanyV2();

            //// comment aafter abstract class creation
            ////company.AddElectronic(new Elecetronic() { Price = 500, Color = "Gray" });
            //company.AddElectronic(new Mobile() { Price = 1500, Color = "White", Storage = 128 });
            //company.AddElectronic(new Tablet());
            //company.AddElectronic(new Laptop());
            //// now we applied open to extend closed to modify principle
            //// and DRY principle
            //// using polymorphism we can add any electronic type to the company
            //// so now we can add another type like Robot, will inherit from Electronic
            //// and we will not change anything in the CompanyV2 class

            //company.DisplayAllElectronics();


            // Assignment Polymorphism OOP Day6
            //ProjectTeamV2 projectTeamV2 = new ProjectTeamV2(3);

            //Person teacherV2 = new Teacher2() { Name = "Mr. Smith", Age = 40, Subject = "Math" };
            //projectTeamV2.AssignPerson(teacherV2);
            //Person studentV2_1 = new Student2() { Name = "Alice", Age = 20, Grade = 90 };
            //Person studentV2_2 = new Student2() { Name = "Bob", Age = 22, Grade = 85 };
            //projectTeamV2.AssignPerson(studentV2_1);
            //projectTeamV2.AssignPerson(studentV2_2);

            //projectTeamV2.GetTeamDetails();


            #endregion

            #region Advance C#

            // Static Section
            //Complex complex1 = new Complex(17, 25);
            ////complex1.DisplayCounter();
            //Complex.DisplayCounter();
            //Complex.Counter += 10;
            ////complex1.Counter;
            //Complex complex2 = new Complex(10, 5);
            ////complex2.DisplayCounter();
            //Complex.DisplayCounter();
            //complex1.Display();
            //complex2.Display();

            //MyMath.Display();

            // need to get the count of created objects from the Complex class
            // we can use static member to keep the count as shared info
            // if created increament, if destroyed decrement the count

            //// operator overloading
            //Complex complex1 = new Complex(17, 25);
            //Complex complex2 = new Complex(18, 25);

            //Complex complex3 = complex1 + complex2; // operator overloading

            //complex3.Display();

            //bool isEqual = complex1.Equals(complex2);

            //bool isEqual2 = complex1 != complex2;

            //Console.WriteLine($"{isEqual}");

            //Object obj = complex1 as Object; // upcasting

            //Console.WriteLine(complex1.GetType());
            //// MNOURZK.BackendCourse.Basics.Advance_C_.Complex
            //Console.WriteLine("complex1".GetType());
            //// System.String
            //Console.WriteLine(1.GetType());
            //// System.Int32

            //bool isEqual3 = Equals(complex1, complex2);

            ////complex2 = complex1;
            //bool isEqual4 = ReferenceEquals(complex1, complex2);

            //Console.WriteLine(complex1.GetHashCode());
            //Console.WriteLine(complex2.GetHashCode());

            //Complex complex4 = new Complex(120, 250);
            ////Complex complex5 = complex4;
            //Complex complex5 = complex4.Clone(); // deep copy

            //complex4.Display();
            //complex5.Display();

            //complex4.Real = 500;

            //complex4.Display();
            //complex5.Display();

            //Console.WriteLine(complex1.ToString());

            //Console.WriteLine(complex2.ToString());

            ////ComplexStruct cs1; // declare a struct value, if include only methods no need for initialize anything because no fields exist
            //ComplexStruct cs1 = new ComplexStruct(); // declare a struct value, must use constructor to initialize the values

            //cs1.Display();

            ////Console.WriteLine($"{cs1.Real}");

            // OUT and REF Keywords
            int a = 10;
            int b = 20;
            int z = 0;

            Add(a, b, ref z);

            Console.WriteLine(z); // 30

            //int quotient, remainder;
            //Divide(10, 3, out quotient, out remainder); // variables can be uninitialized
            //Console.WriteLine($"{quotient}, {remainder}"); // 3, 1

            int quotient;
            Divide(10, 3, out quotient, out _); // variables can be uninitialized
            Console.WriteLine($"{quotient}"); // 3

            //// Old way:
            //int result;
            //int.TryParse("123", out result);

            //// New way - declare inline:
            //int.TryParse("123", out int result);
            //Console.WriteLine(result);

            if (RequestState.accepted == 0)
            {
                Console.WriteLine(RequestState.accepted);
            }

            int inProgressStatue = (int)RequestState.inProgress;

            Console.WriteLine(inProgressStatue);

            Console.WriteLine("please enter the state to check your request:");
            string state = Console.ReadLine();

            //RequestState requestState = (RequestState)Enum.Parse(typeof(RequestState), state, true);
            //Console.WriteLine($"{requestState} \t {(int)requestState}");
            Enum.TryParse(typeof(RequestState), state, true, out Object? requestStateObj);
            if (requestStateObj != null)
            {
                RequestState requestState = (RequestState)requestStateObj;
                Console.WriteLine($"{requestState} \t {(int)requestState}");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            #endregion

            #endregion

        }

        // out example - must assign, cannot read until assigned
        public static void Divide(int x, int y, out int result, out int remainder)
        {
            // Console.WriteLine(result); // ERROR! Cannot read unassigned out parameter
            result = x / y;
            remainder = x % y;
            // Now we can read result and remainder
        }

        public static void Add(int x, int y, ref int result)
        {
            result = x + y;
        }

        public static void UpdateCity(string cityName)
        {
            cityName = "UAE";
        }

        //in the scope of the function we have a new reference value in the stack will reference the same object in the heap
        //when function call over the reference will be destroyed, any variable in the funcition scope is local variable and will be destroyed
        public static void UpdateStudentName(Student studentRef)
        {
            studentRef.Name = "Updated Name"; //change in the heap
        }

        /* Assignment, function GetOccurenceCount(int [] arr, int number)
        take array and number, return how many times the number exists in the array */
        public static ushort getoccurenceCount(int[] arr, int number)
        {
            ushort count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }

            //foreach (var item in arr)
            //{
            //    if (item == number)
            //    {
            //        count++;
            //    }
            //}

            return count;
        }

        //Assigment2: reverse array, take array and return the revered array [same array or new one]
        public static int[] ReverseArray(int[] arr)
        {
            int[] reversedArray = new int[arr.Length];
            for (int i = 0, j = arr.Length - 1; i < arr.Length; i++, j--)
            {
                reversedArray[i] = arr[j];
            }
            return reversedArray;
        }

        /* Assigment3: remove duplication from the array, take array and return the array without duplication [same array or new one]
        use new array to work */
        public static int[] RemoveDuplication(int[] arr)
        {
            List<int> uniqueList = new List<int>();
            foreach (var item in arr)
            {
                if (!uniqueList.Contains(item))
                {
                    uniqueList.Add(item);
                }
            }
            return uniqueList.ToArray();
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
