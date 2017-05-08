using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharpGund
{
    class Program
    {
        private static void RunExerciseOne()
        {
            string firstname = "Svitlana";
            string lastname = "Paradovska";
            Console.WriteLine("Hello, {0} {1}! I’m glad to inform you that you are the test subject of my very first assignment!", firstname, lastname);
        }

        private static void RunExerciseTwo()
        {
            Console.WriteLine("input please your firstname and press Enter: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("input please yout surname and press Enter:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Hello, {0} {1}! Have a nice day!", firstname, lastname);
        }

        private static void RunExerciseThree()
        {
            /*
             *Ask the user to enter his date of birth. Calculate his age and display it on console. */
            Console.WriteLine("Input your birthday day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input number of your birthday month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your birthday year");
            int yearB = Convert.ToInt32(Console.ReadLine());
            DateTime dateBirthDay = new DateTime(yearB, month, day);
            DateTime dateNow = DateTime.Now;
            int year = dateNow.Year - dateBirthDay.Year;
            if (dateNow.Month < dateBirthDay.Month || (dateNow.Month == dateBirthDay.Month && dateNow.Day < dateBirthDay.Day)) year--;
            Console.WriteLine("Your age is {0} years", year);
            Console.ReadLine();
        }

        private static void RunExerciseFour()
        {
            /*
             * Display todays date in different date formats. 
             * Also display tomorrows date and yesterdays date using short date format. */
            DateTime date1 = DateTime.Now;
            Console.WriteLine("Todays data: ");
            Console.WriteLine("Data and time of pc: {0}", DateTime.Now);
            Console.WriteLine("Data and time Grinvich: {0}", DateTime.UtcNow);
            Console.WriteLine("Data today: {0}", DateTime.Today);
            Console.WriteLine("Format 1: {0}", date1.ToLocalTime());
            Console.WriteLine("Format 2: {0}", date1.ToUniversalTime());
            Console.WriteLine("Format 3: {0}", date1.ToLongDateString());
            Console.WriteLine("Format 4: {0}", date1.ToShortDateString());
            Console.WriteLine("Format 5: {0}", date1.ToLongTimeString());
            Console.WriteLine("Format 6: {0}", date1.ToShortTimeString());
            Console.WriteLine("Tomorrow date {0}", date1.AddDays(1));
            Console.WriteLine("Yesterday date {0}", DateTime.Now.AddDays(-1));
            Console.ReadLine();
        }

        private static void RunExerciseFive()
        {
            /*A)Add any two integer numbers and store the sum result in a variable of type double.
             * B)Add any two decimal numbers (use variables of type double) 
             * and store the sum result in a variable of type integer. 
             * If you get any error try to resolve it.
             * C)Store an even number and an odd number in two different integer variables. 
             * Divide odd number by even number and display an accurate result. */

            //   A

            Console.WriteLine();
            Console.WriteLine();
            int a = 345;
            int b = 567;
            double sum = a + b;
            Console.WriteLine("int {0} + int {1} = double {2}", a, b, sum);
            Console.WriteLine();
            Console.WriteLine();
            //    B
            double num1 = 756765433507707680;
            double num2 = 1234566780507707680;
            // double sum1 = num1 + num2;
            int sumB = (int)(num1 + num2);
            Console.WriteLine("double {0} + double {1} = int {2} ", num1, num2, sumB);
            Console.WriteLine();
            Console.WriteLine();
            //   C
            int even = 64;
            int odd = 246785467;
            double accurate = (double)odd / (double)even;
            Console.WriteLine("int {0} / int {1} = accurate result {2:f4}", odd, even, accurate);
            Console.ReadLine();


        }
        private static void RunExerciseSix()
        {
            /*
             *A)Change string “The quick fox Jumped Over the DOG” to the string 
             * “The brown fox jumped over the lazy dog” using required string manipulation functions.
             * B)Enter  any two words from console and check whether they are same words or not
             * C)Input word Donkey and display it as the word Monkey on the console. 
             * D)Replace ‘I’ with ‘We’ and ‘am’ with ‘are’ in given   text below.  
             * “I am going to visit Kolmården zoo tomorrow. 
             * I am a big fan of the dolphin show. 
             * I may watch all dolphin shows during the day. 
             * I would like to take a gondola safari as well. 
             * I wish to visit Bamse and his team there.”
             * E)Actual string is "She is the popular singer." 
             * and the expected string is "She is the most popular singer." */
            //  A

            string aaa = "The quick fox Jumped Over the DOG.";
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            Console.WriteLine(aaa);
            Console.ResetColor();


            Console.ReadKey();
            string bbb = aaa.ToLower();
            // bbb = bbb.ToUpper();
            bbb = bbb.Replace("quick", "brown");
            // COLOR and stor bokstav first letter



            StringBuilder str2 = new StringBuilder(bbb);

            int x = bbb[0];//ASCI
            int X = x - 32;//Difference 32 simb
            str2.Replace((char)x, (char)X, 0, 1);
            bbb = str2.ToString();

            Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
            Console.WriteLine(bbb);
            Console.ResetColor();

            Console.ReadKey();


            // B
            Console.WriteLine("Input any word please: ");
            string first = Console.ReadLine();
            Console.WriteLine("Input any new word please: ");
            string second = Console.ReadLine();
            if (String.Compare(first, second) == 0)
            {
                Console.WriteLine("Words are same.");
            }
            else
            {
                Console.WriteLine("Words are different.");
            }
            Console.ReadKey();

            // C
            Console.WriteLine("Input word Donkey, please: ");
            string donkey = Console.ReadLine();
            donkey = "Donkey";
            string monkey = (donkey.Replace("D", "M"));
            Console.WriteLine(monkey);
            Console.ReadKey();

            // D
            string phrase = "I am going to visit Kolmården zoo tomorrow. I am a big fan of the dolphin show. I may watch all dolphin shows during the day. I would like to take a gondola safari as well. I wish to visit Bamse and his team there.";
            Console.WriteLine(phrase);
            string phrasenew = (phrase.Replace("I", "We"));
            phrasenew = (phrasenew.Replace("am", "are"));
            Console.WriteLine(phrasenew);
            Console.ReadLine();
            // E
            string she = "She is the popular singer.";
            Console.WriteLine(she);
            string singer = (she.Replace("the", "the most"));
            Console.WriteLine(singer);
            Console.ReadLine();

            // F
            string friend = "A friend is the asset of your life.";
            Console.WriteLine(friend);
            string subString = "true ";
            string subString1 = "greatest ";
            string friend1 = friend.Insert(16, subString1);
            friend1 = friend1.Insert(2, subString);
            Console.WriteLine(friend1);
            Console.ReadLine();

            // G
            string name = "My name is Nalini Phopase.";
            Console.WriteLine(name);
            string name1 = name.Substring(11);
            Console.WriteLine(name1);
            Console.ReadLine();

            // H
            string sentense = "Arrays are very common in programming, they look something like: [1, 2, 3, 4, 5]";
            Console.WriteLine(sentense);
            string sentense1 = sentense.Replace("2, 3, 4, 5", "4, 5, 6, 7, 8");

            Console.WriteLine(sentense1);

            int indexOfChar = sentense1.IndexOf('[');
            string sentense2 = sentense1.Substring(indexOfChar);
            Console.WriteLine(sentense2);
            Console.ReadLine();
        }
        private static void RunExerciseSeven()
        {
            int x = 40;
            int y = 20;
            int z = 25;
            int m = 15;
            int e = (x + y) * z / m;
            int f = x + y * (z / m);
            int g = x + y * z / m;
            Console.WriteLine("e = {0} f= {1}  g= {2}", e, f, g);         
        }
        private static void RunExerciseEight()
        {
            Console.WriteLine("input please any positive integer and press Enter: ");
            int positiv = Convert.ToInt32(Console.ReadLine());
            if (positiv/2*2 == positiv) {
                Console.WriteLine("number is even");
            } else {
                Console.WriteLine("number is odd");
            }
            Console.ReadLine();
        }
        private static void RunExerciseNine()
        {
            /*Generate and store 20 random integer numbers in a list 
             * and separate those numbers in to two new lists. 
             * One with even numbers and one with odd numbers. */
            int na = 0;
            Random x = new Random();
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            Console.WriteLine("Start numbers:  ");
            for (int i = 1; i <= 20; i++)
            {
                na = x.Next(-10000, 10000);
                Console.Write("  " + na);


                if (na == na / 2 * 2)
                {
                    even.Add(na);
                }
                else
                {

                    odd.Add(na);
                }


            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("even :");
            for (int i = 0; i < even.Count; i++)
            {
                Console.Write(" " + even[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("odd :");
            for (int i = 0; i < odd.Count; i++)
            {
                Console.Write(" " + odd[i]);
            }
            Console.ReadKey();
        }
        private static void RunExerciseTen()
        {
            /* Ask user to enter a value of a radius. 
             * Calculate the area of a circle 
             * and a sphere and display the result on the console*/
            Console.WriteLine("input please a value of a radius and press Enter: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.Pow(radius, 2) * Math.PI;
            double sphere = 4 * area;
            Console.WriteLine("Area of circle is {0}, area of sphere is {1}", area, sphere);
        }
        private static void RunExerciseEleven()
        {
            /*
             *Ask the user to enter any 10 numbers and store them in an array. 
             * Print only the negative numbers on the console */
            Console.WriteLine("input please any ten numbers. ");
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Input number {0} and press Enter ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Output negative numbers: ");
            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] < 0)
                {
                    Console.Write("  " + numbers[i]);
                }

            }
            Console.ReadLine();
        }
        private static void RunExerciseTwelve()
        {
            /*
             * Ask user to enter his body temperature in degree Celsius. 
             * Display him a message if he has a fever or not.*/
            Console.WriteLine("What is your body temperature in degree Celsius?");
            float temperature = float.Parse(Console.ReadLine());
            if (temperature == 36.6)
            {
                Console.WriteLine("Your temperature is normal. Enjoy your life!!!");
            }
            else if (temperature < 36.6)
            {
                Console.WriteLine("Your temperature is low. Go to rest a bit.");
            }
            else
            {
                Console.WriteLine("You have fever");

            }
            Console.ReadKey();
        }
        private static void RunExerciseThirteen()
        {
            /*
             * Ask the user to enter his name and save it into a Name variable.  
             *  Greet the user by his name, and ask for his/her birth date. 
             *  Call Calculate Age method from exercise to calculate the age of the user.
             *  If the user is 18 or above 18
             *  Ask if the user wants to order a beer 
             *  •If   yes   Display a message that the order has been done! •
             *  If NoAsk if he/she want to order a coke  oIf yes Display a message that 
             *  the coke has been served  o
             *  If No: Display a message that no order options are available 
             *  If the user is below 18Ask if the user want to order a coke 
             *  •If   Yes: Display a message that the coke has been served  
             *  •If   No:Display a message that no order options are available Below (Figure 3)
             *   is a Flow chart diagram that shows the application flow. */
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello, {0}! What is your birthday day?", Name);
            Console.WriteLine("Input your birthday day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input number of your birthday month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your birthday year");
            int yearB = Convert.ToInt32(Console.ReadLine());
            DateTime dateBirthDay = new DateTime(yearB, month, day);
            DateTime dateNow = DateTime.Now;
            int year = dateNow.Year - dateBirthDay.Year;
            if (dateNow.Month < dateBirthDay.Month || (dateNow.Month == dateBirthDay.Month && dateNow.Day < dateBirthDay.Day)) year--;
            Console.WriteLine("Your age is {0} years", year);
            if (year >= 18)
            {
                Console.WriteLine("Do you want order a beer? Input 1, if yes or 2, if not");
                string order = Console.ReadLine();
                if (order == "1")
                {
                    Console.WriteLine("Your order has been done!");
                }
                else
                {
                    Console.WriteLine("Do you want order a coke? Input 1, if yes or 2, if not");
                    string order1 = Console.ReadLine();
                    if (order1 == "1")
                    {
                        Console.WriteLine("Coke was been served!");
                    }
                    else
                    {
                        Console.WriteLine("No order options are avialable!");
                    }
                }

            }
            else
            {
                Console.WriteLine("Do you want to order coke? Input 1, if yes or 2, if not");
                string order1 = Console.ReadLine();
                if (order1 == "1")
                {
                    Console.WriteLine("Coke was been served!");
                }
                else
                {
                    Console.WriteLine("No order options are avialable!");
                }
            }
            Console.ReadLine();
        }
        private static void RunExerciseFourteen()
        {
            /*
             *Write a program that asks user an arithmetic operator ('+','-','*' or '/') and two operands. 
             * Perform the corresponding 
             * calculation on the operands and display the result (use switch case) */
            Console.WriteLine("Input operand #1");
            float operand1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Input operand #2");
            float operand2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Input an arithmetic operator");
            string operat = Console.ReadLine();
            float resultat;
            switch (operat)
            {
                case "+":
                    resultat = operand1 + operand2;
                    Console.WriteLine("Resultat:{0}", resultat);
                    break;
                case "-":
                    resultat = operand1 - operand2;
                    Console.WriteLine("Resultat:{0}", resultat);
                    break;
                case "*":
                    resultat = operand1 * operand2;
                    Console.WriteLine("Resultat:{0}", resultat);
                    break;
                case "/":
                    resultat = operand1 / operand2;
                    Console.WriteLine("Resultat:{0}", resultat);
                    break;
            }

            Console.ReadLine();
        }
        private static void RunExerciseFifteen()
        {
            /*
             * Ask user to enter his grade of exam (A, B, C, D, E)
             *  and print a relevant message for him as per the grade he has.*/
            Console.WriteLine("Input your grade of exam (A,B,C,D,E)");
            string grade = Console.ReadLine();
            switch (grade)
            {
                case "A":
                    Console.WriteLine("You are best from the best! Your grade is {0}", grade);
                    break;
                case "B":
                    Console.WriteLine("You are very good student! Your grade is {0}", grade);
                    break;
                case "C":
                    Console.WriteLine("You are good student! Your grade is {0}", grade);
                    break;
                case "D":
                    Console.WriteLine("You can study better! Your grade is {0}", grade);
                    break;
                case "E":
                    Console.WriteLine("You need study more! Your grade is {0}", grade);
                    break;
            }

            Console.ReadLine();
        }
        private static void RunExerciseSixteen()
        {
            /*
             * Ask user to enter any number smaller than 100. 
             * Print all values from 1 to the entered number in ascending and descending order.
             * Write the same program using for, while and do-while loop */
            Console.WriteLine("Input any number smaller than 100 please");
            int ccc = Convert.ToInt32(Console.ReadLine());
            // for
            for (int i = 1; i < (ccc + 1); i++)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine();
            for (int i = ccc; i > 0; i--)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine();
            // while
            int i1 = 1;
            while (i1 <= ccc)
            {
                Console.Write(" {0} ", i1);
                i1++;
            }
            Console.WriteLine();
            i1 = ccc;
            while (i1 >= 1)
            {
                Console.Write(" {0} ", i1);
                i1--;
            }
            Console.WriteLine();
            // Do
            i1 = 1;
            do
            {
                Console.Write(" {0} ", i1);
                i1++;
            } while (i1 <= ccc);
            Console.WriteLine();
            i1 = ccc;
            do
            {
                Console.Write(" {0} ", i1);
                i1--;
            } while (i1 >= 1);

            Console.WriteLine();
            Console.ReadLine();
        }
        private static void RunExerciseSeventeen()
        {
            /*Print a math table from 1 to 10 using for loop */
            int resu = 0;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    resu = i * j;
                    Console.Write("{0, -4}", resu);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        private static void RunExerciseEighteen()
        {
            /*
             *Print leap years between 1990 to current year using while loop */
            int year = 1992;

            while (year <= 2016)
            {
                Console.WriteLine(year);
                year = year + 4;
            }
            Console.ReadLine();
        }
        private static void RunExerciseNineteen()
        {
            /*
             *Generate a random number and save it to a variable, SecretNumber.If he/she miss the first guess ask the user if he/she wants to guess the number again.  
             * Repeat the guessing until user answers yes or guess the correct number. */
            Random r = new Random();
            int SecretNumber = r.Next(100);
            int guess = 0;
            int b = 1;
            Console.WriteLine("I have SECRET Number from 1 to 100");
            do
            {
                Console.WriteLine("Try to guess this number");
                Console.WriteLine("Input number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == SecretNumber)
                {
                    Console.WriteLine("Congratulation! You win!");
                    b = 0;
                }
                else if (guess < SecretNumber)
                {

                    Console.WriteLine("Your number is too small!!!");
                    Console.WriteLine("Press 1 if you want continue or 0 if you want stop");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Your number is too big!!!");
                    Console.WriteLine("Press 1 if you want continue or 0 if you want stop");
                    b = Convert.ToInt32(Console.ReadLine());
                }

            } while (b == 1);
            Console.WriteLine("See you!!!");
            Console.ReadLine();


        }
        private static void RunExerciseTwenty()
        {
            /*
             * Print the following * pattern on console using loop
             * * * * * *  * * * *   *   * *    * *      *  */
            /*Print the following * pattern on console using loop* * * * *  * * * *   *   * *    * *      */

            string pic2 = "          ";
            string pic1 = pic2;
            Console.WriteLine(pic1);
            for (int i = 6; i > 1; i--)
            {
                pic2 = pic2 + " ";
                pic1 = pic2;
                for (int j = 1; j < i; j++)
                {
                    pic1 = pic1 + "*" + " ";

                }
                Console.WriteLine(" {0}", pic1);
                Console.WriteLine();
                pic1 = "          ";

            }
            Console.ReadLine();
        }
        private static void RunExerciseTwentyone()
        {
            /*
             * Write a program that keeps asking the user to enter   numbers, until he enters -1. 
             * Then displays a sum and average of all numbersentered before -1*/
            Console.WriteLine("Input please any integer number.");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int i = 0;
            double average = 0;

            while (num != -1)
            {
                sum = sum + num;
                i++;
                Console.WriteLine("Input please any integer number.");
                num = Convert.ToInt32(Console.ReadLine());

            }
            if (i != -1)
            {
                average = sum * 0.1 / 0.1 / (i);

            }            
            Console.WriteLine("Sum= {0}", sum);
            Console.WriteLine("Average= {0}", average);
            Console.ReadLine();
        }
        private static void RunExerciseTwentytwo()
        {
            /*
             * Write a program to  print the Fibonacci series */
            int first = 1;
            Console.Write("{0} ", first);
            int second = 1;
            Console.Write("{0} ", second);
            int sum = 0;
            Console.WriteLine("What are last members number of Fibonacci series?");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Series Fibonacci is :");

            if (number == 0)
            {
                Console.Write("0");
            }
            else if (number == 1)
            {
                Console.Write("0, 1");
            }
            else
            {
                int i = 4;
                Console.Write("0, 1, 1");
                while (number >= i)
                {
                    sum = first + second;

                    Console.Write(", {0}", sum);

                    first = second;
                    second = sum;
                    i++;
                }

                Console.ReadLine();
            }
        }
        private static void RunExerciseTwentythree()
        {
            /*
             *Write a program to calculate  the area of triangle
             *  where the user has to pass height and width as a parameter */
            Console.WriteLine("Input height of triangle");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Input width of triangle");
            float width = float.Parse(Console.ReadLine());
            float area = height * width / 2;
            Console.WriteLine("Area of triangle is :{0}", area);
            Console.ReadLine();
        }
        private static void RunExerciseTwentyfour()
        {
            /*
             *Write a program to add 2, 3 and 4 float values using AddNumbers method (all three methods using the same name),  
             * pass these float values as a parameter, Print result inside the method */

            AddNumbers(1, 2);
            AddNumbers(1, 7, 8);
            AddNumbers(1, 89, 98, 0);
            Console.ReadLine();
        }              
        private static void AddNumbers(double num1, double num2)
        {
            Console.WriteLine(" {0}, {1}", num1, num2);
        }
        private static void AddNumbers(double num1, double num2, double num3)
        {
            Console.WriteLine(" {0}, {1}, {2}", num1, num2, num3);
        }
        private static void AddNumbers(double num1, double num2, double num3, double num4)
        {
            Console.WriteLine(" {0}, {1}, {2}, {3}", num1, num2, num3, num4);
        }
        private static void RunExerciseTwentyfive()
        {
            /*
             *Write a program to find the greatest number in an array. 
             * Pass an array of 5 numbers as a parameter 
             * to a method and return a greatest number from the method and then print it. */

            Console.WriteLine("Input 5 integer elements of array");
            int[] arr1 = new int[5];
            int i;
            for (i = 0; i <= 4; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int a = arr1[0];
            for (i = 1; i <= 4; i++)
            {
                if (a < arr1[i])
                {
                    a = arr1[i];
                }
            }
            Console.WriteLine("Greatest number in the array is {0}", a);
            Console.ReadLine();
        }
        private static void RunExerciseTwentysex()
        {
            /*
             * Write a swap function for swapping two numbers. Pass values as a parameter. 
             * Print the swapped values inside function as well 
             * at the next line where you called this function.*/
            Console.WriteLine("We will swap two numbers. Please, input number one:   ");
            double num11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, input number two:   ");
            double num21 = Convert.ToDouble(Console.ReadLine());
            Swap(num11, num21);

        }
        static void Swap(double num1, double num2)
        {
            double swap = num1;
            num1 = num2;
            num2 = swap;
            Console.WriteLine("New numbers:  {0},  {1}", num1, num2);
            Console.ReadLine();
        }

        private static void RunExerciseTwentyseven()
        {
            /*
             *Write a swap function for swapping two numbers. 
             * Pass values as a parameter using ref type.
             * Print swapped values inside function as well 
             * at next line where you called this function. */
            double [] numbers = new double[2];
            Console.WriteLine("We will swap two numbers. Please, input number one:   ");
            numbers[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, input number two:   ");
            numbers[1] = Convert.ToDouble(Console.ReadLine());
            Swap(ref numbers);


        }

        static void Swap( ref double[] number)
        {
            double swap = number[0];
            number[0] = number[1];
            number[1] = swap;                 
            Console.WriteLine("New numbers:  {0},  {1}", number[0], number[1]);
            Console.ReadLine();

        }
        private static void RunExerciseTwentyeight()
        {
            /*
             *Let the user input any string, then check if the string is a palindrome sentence or not */

            Console.WriteLine("This program check, is this string palindrom or no.");
            Console.WriteLine("Input please any string value:");
            string str = Console.ReadLine();
            //
            bool answer = false;
            for (var i = 0; i < str.Length / 2; i++)
            {
                if (char.ToLower(str[i]) != char.ToLower(str[str.Length - i - 1]))
                {
                    answer = false;
                }
                else
                {
                    answer = true;
                }
            }

            Console.WriteLine("It is {0} that this string is palindrom. ", answer);
            Console.ReadLine();
        }
        private static void RunExerciseTwentynine()
        {
            /*
             *Ask user to enter any twelve positive integer numbers. 
             * Store these numbers to an array. 
             * Display all numbers and then separate the numbers into an odd number 
             * array and even number array. */
            Console.WriteLine("Input 12 integer elements of array");
            int[] arr1 = new int[12];
            int[] odd = new int[12];
            int[] even = new int[12];
            int i;
            int j = 0; int k = 0;
            for (i = 0; i <= 11; i++)
            {
                Console.WriteLine("Input please number {0} ", (i + 1));
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < 12; i++)
            {
                if (arr1[i] == (arr1[i] / 2 * 2))
                {
                    odd[j] = arr1[i];
                    j++;


                }
                else
                {
                    even[k] = arr1[i];
                    k++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Odd array:");
            for (i = 0; i < j; i++)
            {
                Console.Write(" {0, -4}", odd[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Even array:");
            for (i = 0; i < k; i++)
            {
                Console.Write(" {0, -4}", even[i]);
            }



            Console.ReadLine();
        }
        private static void RunExerciseThirty()
        {
            /*
             * Create two arrays with arbitrary size and fill one with random numbers. 
             * Then copy over the numbers from the array with random numbers to the another array 
             * so that the even numbers are added (placed)to the rear side of the array 
             * and the odd numbers to the front side.*/
            Random r = new Random();
            int size1;
            do
            {
                size1 = r.Next(25);
            } while (size1 == 0);
            int size2;
            do
            {
                size2 = r.Next(size1);
            } while (size2 == 0);
            int[] mas1 = new int[size1];
            int[] mas2 = new int[size2];
            int[] mas3 = new int[size2];
            Console.WriteLine("size of array #1 is  " + size1);
            Console.WriteLine("size of array #2 is  " + size2);
            Console.WriteLine();
            Console.Write("start array #1 is      ");
            int key = 0; int k = 0; int l = 0;
            for (int i = 0; i < size1; i++)
            {
                mas1[i] = r.Next(-100, 101);
                Console.Write(mas1[i] + " ");
            }
            Console.WriteLine();
            Console.Write("result array #2 is      ");
            for (int i = 0; i < size2; i++)
            {
                key = r.Next(0, size1);
                mas2[i] = mas1[key];
                Console.Write(mas2[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < size2; i++)
            {
                if (mas2[i] == (mas2[i] / 2 * 2)) // even
                {
                    //even
                    mas3[(size2 - 1 - k)] = mas2[i];                    
                    k++;
                }
                else
                {
                    //odd
                    mas3[l] = mas2[i];                    
                    l++;

                }
            }
            Console.WriteLine();
            Console.Write("sorted array is     ");
            for (int i = 0; i < size2; i++)
            {
                Console.Write(" " + mas3[i]);
            }
            Console.Read();
        }
        private static void RunExerciseThirtyone()
        {
            /*
             * Create an array. Set the size of an array as a random number between 5 and 15. 
             *  Sort this array without using sort method.*/
            Random r = new Random();
            int size = r.Next(5, 15);
            int[] mas = new int[size];
            Console.WriteLine("size of array is  " + size);
            Console.Write("start array is      ");
            for (int i = 0; i < size; i++)
            {
                mas[i] = r.Next(-100, 101);
                Console.Write(mas[i] + " ");
            }
            int j = 0; int key;
            for (int i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    if (mas[i] < mas[j])
                    {
                        key = mas[i];
                        mas[i] = mas[j];
                        mas[j] = key;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("sorted array is     ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.Read();
        }
        private static void RunExerciseThirtytwo()
        {
            /*
             * Create an array. Set the size of an array as a random number smaller than 16.   
             * Fill in the array with random numbers (positive, smaller than 100, not repeated). 
             * Create another array of the same size and ask the user if he/she wants to  fill 
             * in the array with either square or cube result of the values from previous array.*/
            Random r = new Random();
            int size1;
            do
            {
                size1 = r.Next(16);
            } while (size1 == 0);
            int[] mas1 = new int[size1];
            int[] mas2 = new int[size1];
            int i;
            Console.WriteLine("size of array #1 is  " + size1);
            Console.WriteLine();
            for (i = 0; i < size1; i++)
            {
                mas1[i] = r.Next(0, 101);
                Console.Write(mas1[i] + " ");
                for (int j = 0; j < i; j++)
                {
                    if (mas1[i] == mas1[j])
                    {
                        i--;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("If you want fill array with square please press 2, if you want fill cube of the values, press 3. ");
            Console.WriteLine("If you want do nothing, please, press any key.");
            string key = Console.ReadLine();
            
            switch (key)
            {
                case "2":
                    Console.WriteLine("your result:  ");
                    for (i = 0; i < size1; i++)
                    {
                        mas2[i] = mas1[i] * mas1[i];
                        Console.Write(" " + mas2[i]);
                    }
                    break;
                case "3":
                    Console.WriteLine("your result:  ");
                    for (i = 0; i < size1; i++)
                    {
                        mas2[i] = mas1[i] * mas1[i] * mas1[i];
                        Console.Write(" " + mas2[i]);
                    }
                    break;
                default:
                    Console.Write("Thanks for your attention! Welcome next time ");
                    break;
            }
            Console.Read();

        }
        private static void RunExerciseThirtythree()
        {
            /*
             *Let the user input a string with numbers comma separated like “1,2,34,83,19,45”. 
             * Convert the number string to an array and find the min, the max and the average value.  
             * (Use strings split function if required) */
            Console.WriteLine("Input a string with numbers comma separated like [1,2,34,745,65]");
            string comma = Console.ReadLine();
            string[] words = new string[1000];
            int size = 1; int i = 0;
            foreach (char s in comma)
            {
                if (s == ',')
                {
                    size++;
                }
            }
            i = 0;

            foreach (char s in comma)
            {
                if (s != ',')
                {
                    words[i] = words[i] + s;
                }
                else
                {
                    i++;
                }
            }

            /* string[] words = comma.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries); */
            // size = words.Length;
            int[] arr1 = new int[size];
            int sum = 0;
            for (i = 0; i < size; i++)
            {
                arr1[i] = Convert.ToInt32(words[i]);
                sum = sum + arr1[i];
            }
            Array.Sort(arr1);
            Console.WriteLine("Minimum = {0}", arr1[0]);
            Array.Reverse(arr1);
            Console.WriteLine("Maximum = {0}", arr1[0]);
            double average = 0.1 * sum / size / 0.1;
            Console.WriteLine("Average = {0:f2}", average);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {

            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number between 1 and 33 or -1 to exit: ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            RunExerciseSeven(); 
                            break;
                        case 8:
                            RunExerciseEight();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case 10:
                            RunExerciseTen();
                            break;
                        case 11:
                            RunExerciseEleven();
                            break;
                        case 12:
                            RunExerciseTwelve();
                            break;
                        case 13:
                            RunExerciseThirteen();
                            break;
                        case 14:
                            RunExerciseFourteen();
                            break;
                        case 15:
                            RunExerciseFifteen();
                            break;
                        case 16:
                            RunExerciseSixteen();
                            break;
                        case 17:
                            RunExerciseSeventeen();
                            break;
                        case 18:
                            RunExerciseEighteen();
                            break;
                        case 19:
                            RunExerciseNineteen();
                            break;
                        case 20:
                            RunExerciseTwenty();
                            break;
                        case 21:
                            RunExerciseTwentyone();
                            break;
                        case 22:
                            RunExerciseTwentytwo();
                            break;
                        case 23:
                            RunExerciseTwentythree();
                            break;
                        case 24:
                            RunExerciseTwentyfour();
                            break;
                        case 25:
                            RunExerciseTwentyfive();
                            break;
                        case 26:
                            RunExerciseTwentysex();
                            break;
                        case 27:
                            RunExerciseTwentyseven();
                            break;
                        case 28:
                            RunExerciseTwentyeight();
                            break;
                        case 29:
                            RunExerciseTwentynine();
                            break;
                        case 30:
                            RunExerciseThirty();
                            break;
                        case 31:
                            RunExerciseThirtyone();
                            break;
                        case 32:
                            RunExerciseThirtytwo();
                            break;
                        case 33:
                            RunExerciseThirtythree();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue..");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
            }

        }

    }
}
