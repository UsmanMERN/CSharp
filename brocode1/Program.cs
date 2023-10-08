using System;
using System.Text;
namespace brocode1
{
    class Program
    {
        static void Main(string[] args)
        {

            // bell on conlose
            //Console.WriteLine("\ahello world");
            // Console.Beep();
            // \b del word 
            //Console.WriteLine("ya\bwo ");

            // \n for new line
            // \t horizontal tab 
            // \v vertical tab

            // Console.WriteLine("my \tguru \vsaim \ntell \'me to \"learn seaShark \\from \rhere?");

            //              Varibales   in C#               //

            /*
            int x; //declaration

            x = 9;  //initalization

            int y = 5; // declaration and initalization

            int z = x + y;

            int age = 20;  // integer only stores whoel integer

            double height = 5.8; // double can store decimal

            bool alive = true;

            char symbol = '#';


            String channelName = "BroCode";

            Console.WriteLine("my age is "+age);

            Console.WriteLine("my height is "+height + " feet");

            Console.WriteLine("is am alive ? " + alive

            Console.WriteLine("i am learning C"+symbol + " from " + channelName);

            */

            //              constants in C#             //

            // immutable values that are known at compile time and not change during the program life
            /*
             * 
            const int number = 2342;
            Console.WriteLine(number);
             */

            //          type casting    in C#                   ///

            /*
            // converting a value to different data type
            // useful when we accept user input (string)
            // different data types can do different things

            Type casting in C# is the process of converting one data type to another.
            There are two types of type casting: implicit and explicit.

            Implicit type casting is performed automatically by the compiler.
            It is only possible when the target data type is larger than the source data type. 
            For example, you can implicitly cast an int to a long, but you cannot implicitly cast a long to an int.

            Explicit type casting is performed by the programmer using the () operator.
            It is possible to explicitly cast any data type to any other data type, regardless of size.
            However, it is important to note that explicit type casting can lead to data loss 
            if the target data type is smaller than the source data type.


             
            // Implicit type casting
            //  int myInt = 10;
            //  double myDouble = myInt; // This will implicitly cast the int variable to a double variable.

            // Explicit type casting
            
            // double myDouble = 10.5;
            
            // int myInt = (int)myDouble; // This will explicitly cast the double variable to an int variable, resulting in data loss.
           
            //int myInt=Convert.ToInt32(myDouble);

            // Casting to a reference type
            object myObject = new string("Hello, world!"); // This will cast the string object to an object reference.

            //  string myString = (string)myObject; // This will explicitly cast the object reference back to a string variable

            //string myString = Convert.ToString(myObject);

            // Console.WriteLine(myInt + "type  ---> " + myInt.GetType());
            
            Console.WriteLine(myObject +" type  ---> "+ myObject.GetType());

            */

            //                      Inputs in C#                    //


            /*
             *one word input
             *
             Console.WriteLine("Enter your height ......");

             String height=Console.ReadLine();

            Console.WriteLine("your height is .. " + height);
            
            *** one line input ***
            
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            
            string line = reader.ReadLine();
            
            Console.WriteLine("You entered: " + line);


            *** Enter a number  ***
            int number;

            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            // Convert the string to a number.
            number = int.Parse(input);
           // number = Convert.ToInt32(input);
            // Print the number.
            Console.WriteLine("The number you entered is: " + number + "--> type --->" + number.GetType());
            
             *** check if we enter the number or not 
                int number;

            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            // Try to convert the string to a number.
            if (int.TryParse(input, out number))
            {
                // The conversion was successful.
                Console.WriteLine("The number you entered is: " + number);
            }
            else
            {
                // The conversion was not successful.
                Console.WriteLine("Invalid input.");
            }

            */


            //                      Atrithematic in C#              //


            /*
            // Addition
            int resultAddition = 5 + 3;
            Console.WriteLine("Addition result: " + resultAddition);

            // Subtraction
            int resultSubtraction = 10 - 4;
            Console.WriteLine("Subtraction result: " + resultSubtraction);

            // Multiplication
            int resultMultiplication = 3 * 7;
            Console.WriteLine("Multiplication result: " + resultMultiplication);

            // Division
            int resultDivision = 10 / 2;
            Console.WriteLine("Division result: " + resultDivision);

            // Modulus
            int resultModulus = 10 % 3;
            Console.WriteLine("Modulus result: " + resultModulus);

            // Increment and Decrement
            int x = 5;
            x++; // Increment
            Console.WriteLine("Incremented x: " + x);
            x--; // Decrement
            Console.WriteLine("Decremented x: " + x);

            // Compound Assignment Operators
            int y = 5;
            y += 3; // Equivalent to y = y + 3;
            Console.WriteLine("y += 3: " + y);
            y -= 2; // Equivalent to y = y - 2;
            Console.WriteLine("y -= 2: " + y);

            // Operator Precedence
            int precedenceResult = (5 + 3) * 2;
            Console.WriteLine("Operator Precedence result: " + precedenceResult);

            */

            //                      mathematical operations using the Math class            //


            /*
            // Absolute Value
            double absValue = Math.Abs(-5.5);
            Console.WriteLine("Absolute Value: " + absValue);

            // Square Root
            double sqrtValue = Math.Sqrt(25);
            Console.WriteLine("Square Root: " + sqrtValue);

            // Exponentiation
            double powValue = Math.Pow(2, 3);
            Console.WriteLine("Exponentiation: " + powValue);

            // Trigonometric Functions (sine, cosine, tangent)
            double angle = Math.PI / 4;
            double sineValue = Math.Sin(angle);
            double cosineValue = Math.Cos(angle);
            double tangentValue = Math.Tan(angle);
            Console.WriteLine("Sine: " + sineValue);
            Console.WriteLine("Cosine: " + cosineValue);
            Console.WriteLine("Tangent: " + tangentValue);

            // Rounding
            double roundedValue = Math.Round(3.4567, 2);
            Console.WriteLine("Rounded Value: " + roundedValue);

            // Ceiling
            double ceilingValue = Math.Ceiling(3.2);
            Console.WriteLine("Ceiling Value: " + ceilingValue);

            // Floor
            double floorValue = Math.Floor(3.8);
            Console.WriteLine("Floor Value: " + floorValue);

            // Minimum and Maximum
            double minValue = Math.Min(5, 3);
            double maxValue = Math.Max(5, 3);
            Console.WriteLine("Minimum Value: " + minValue);
            Console.WriteLine("Maximum Value: " + maxValue);

            // Natural Logarithm
            double logValue = Math.Log(Math.E);
            Console.WriteLine("Natural Logarithm: " + logValue);

            // Logarithm Base 10
            double log10Value = Math.Log10(100);
            Console.WriteLine("Logarithm Base 10: " + log10Value);

            // Constants
            double pi = Math.PI;
            double e = Math.E;
            Console.WriteLine("Value of Pi: " + pi);
            Console.WriteLine("Value of E: " + e);

            */

            //                  generate random number in C#        //

            /*
            
            // Create a Random object
            Random random = new Random();

            // Generate a random integer between a specified range
            int randomNumber = random.Next(1, 101); // Generates a random number between 1 and 100
            Console.WriteLine("Random Number: " + randomNumber);

            // Generate a random double between 0 and 1
            double randomDouble = random.NextDouble();
           double randomYaWo= Math.Round(randomDouble,2);
            Console.WriteLine("Random Double: " + randomYaWo * 100);

            */


            //                  practice programm                   //

            /*
            
            Console.WriteLine("Enter the side A :");
            
            double a=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the side B :");

            double b=Convert.ToDouble(Console.ReadLine());
            
            double c= Math.Sqrt((a*a)+ (b*b));

            Console.WriteLine("The hypotenus is :  "+c);
             */

            //                  String operations in C#             //
            // String Concatenation
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Concatenated String: " + fullName);

            // String Interpolation
            string name = "Alice";
            int age = 30;
            string message = $"My name is {name} and I am {age} years old.";
            Console.WriteLine("Interpolated String: " + message);

            // String Length
            string text = "Hello, World!";
            int length = text.Length;
            Console.WriteLine("String Length: " + length);

            // Substring
            string subString = text.Substring(0, 5);
            Console.WriteLine("Substring: " + subString);

            // String Comparison
            string str1 = "apple";
            string str2 = "banana";
            bool areEqual = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("String Comparison (Equal): " + areEqual);

            int compareResult = string.Compare(str1, str2);
            Console.WriteLine("String Comparison (Compare Result): " + compareResult);

            // String Searching
            int index = text.IndexOf("brown");
            Console.WriteLine("String Searching (Index): " + index);

            // String Replacement
            string replacedText = text.Replace("brown", "red");
            Console.WriteLine("String Replacement: " + replacedText);

            // String Splitting
            string names = "John,Mary,David";
            string[] nameArray = names.Split(',');
            Console.WriteLine("String Splitting: " + string.Join(", ", nameArray));

            // String Trimming
            string trimmedText = "   Hello, World!   ".Trim();
            Console.WriteLine("String Trimming: " + trimmedText);

            // String Case Conversion
            string original = "Hello, World!";
            string upperCase = original.ToUpper();
            string lowerCase = original.ToLower();
            Console.WriteLine("Uppercase: " + upperCase);
            Console.WriteLine("Lowercase: " + lowerCase);

            // String Formatting
            int number = 42;
            string formatted = string.Format("The answer is {0}", number);
            Console.WriteLine("String Formatting: " + formatted);

            // String Building
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                stringBuilder.Append(i);
            }
            string result = stringBuilder.ToString();
            Console.WriteLine("String Building (Length): " + result.Length);
            // Wait for user input before closing the console window
            Console.ReadLine();

            Console.ReadKey();

        }
    }
}