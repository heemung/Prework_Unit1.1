using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//using only system for .net2.0 compat.
namespace Unit1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will add each digit of two numbers and " +
                "compare each sum of two digits to see if they equal each other. \n");
            
           bool numberCheck = true, isNumber = true;
           string userNumber1 = "0", userNumber2 = "0";

            while (isNumber)
            {
                Console.WriteLine("Please input a 1+ digit number: ");
                userNumber1 = (Console.ReadLine());

                if ((IsNumberMethod(userNumber1) == true) && (userNumber1.Length > 1))
                {
                    isNumber = false;
                }
                else
                {
                    Console.WriteLine("The input must be + 1 digits in length and " +
                        "the input must contain only digits. example 0123456789. \n");
                }
            }

            while (numberCheck)
            {
                Console.WriteLine("Please input a second number matching the digit length" +
                    " of the first number: ");
                 userNumber2 = (Console.ReadLine());

                    if ((userNumber2.Length == userNumber1.Length) 
                    && (IsNumberMethod(userNumber2) == true))
                        {
                            numberCheck = false;
                        }
                        else
                        {
                            Console.WriteLine("The second number must be only contain digits and" +
                            " length must match the first " +
                            "number length of " + userNumber1.Length + " digits \n");
                        }
            }

           bool answer = PlaceSumTotal(userNumber1, userNumber2);

            Console.WriteLine("The comparison is: " + answer + "\n---Press Enter to exit---");
            Console.ReadLine();     
        }
        //this method takes the user input and trys to parse, this will return a true or false.
        //true is the input string can be type int and false if input string contains a non int.
      public static bool IsNumberMethod(string x)
        {
           bool isNumberTemp = long.TryParse(x, out long n);
           return isNumberTemp;
        }

        public static bool PlaceSumTotal (string numberOne, string numberTwo)
         {

            char temp1, temp2;
            int a1 =0, a2 =0, b1 =0, b2 =0;
            int digitCount = numberOne.Length;
            string[] numberGroupOne = new string[digitCount];
            string[] numberGroupTwo = new string[digitCount];

            for (int i = 0; i < numberOne.Length; i++)
            {
                    temp1 = numberOne[i];
                    temp2 = numberTwo[i];
                    numberGroupOne[i] = Convert.ToString(temp1);
                    numberGroupTwo[i] = Convert.ToString(temp2);
            }

                for (int i = 1; i < numberOne.Length; i++)
                {
                  
                    a1 = Convert.ToInt16(numberGroupOne[i - 1]);
                    b1 = Convert.ToInt16(numberGroupTwo[i - 1]);
                    a2 = Convert.ToInt16(numberGroupOne[i]);
                    b2 = Convert.ToInt16(numberGroupTwo[i]);

                    if ((a1 + b1) != (a2 + b2))
                    {
                            return false;
                    }

            }

        return true;
          }
                                       

         
}

}
