using System;

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

            Console.WriteLine("Enter your height ......");
            String height=Console.ReadLine();

            
            Console.WriteLine("your height is .. " + height);
            Console.ReadKey();
}
}
}