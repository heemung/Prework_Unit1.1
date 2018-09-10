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
            //setting bools to start while loop
           bool numberCheck = true, isNumber = true;

            // initializing strings value because when initializing in while loop 
            //bool answer = PlaceSumTotal(userNumber1, userNumber2); wont complie 
            //unk reason.
            string userNumber1 = "0", userNumber2 = "0";

            //while loop gets first number input, checks to see if the number input is greater
            //than 1 digit and checks to see if its a int number. if both are true the loop
            //exits if one is not true the loop repeats.
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

            //while loop gets second number input, checks to see if the number input digit length 
            // is equal to the first input number and checks to see if its a int number. if both are true 
            //the loop exits if one is not true the loop repeats.
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

           //passing user inputs after checks into methood
           bool answer = PlaceSumTotal(userNumber1, userNumber2);

            //takes the answer bool from the return of the method and writes 
            //the answer for the user.
            Console.WriteLine("The comparison is: " + answer + "\n---Press Enter to exit---");
            Console.ReadLine();     
        }
        //this method takes the user input and trys to parse, this will return a true or false.
        //true is the input string can be type int and false if input string contains a non int.
      public static bool IsNumberMethod(string x)
        {
           bool isNumberTemp = long.TryParse(x, out long n);
            //test parse output by uncommenting below.
           //Console.WriteLine("'{0}' --> {1}", x, n);
            return isNumberTemp;
        }
        // takes user inputs after loop checks and runs main argument. returns true or false
        public static bool PlaceSumTotal (string numberOne, string numberTwo)
         {
            //initializing for the next two loops.
            char temp1, temp2;
            int a1 =0, a2 =0, b1 =0, b2 =0;
            int digitCount = numberOne.Length;
            string[] numberGroupOne = new string[digitCount];
            string[] numberGroupTwo = new string[digitCount];

            //taking the number length and comparing it to i.
            //this takes the string in position i and assigns it to a char temp for both sets of 
            //numbers. Then assigns that to each string array at position i, while converting the
            //char back to string. This will run as many times as there is string length with
            //setting the array size to that length
            for (int i = 0; i < numberOne.Length; i++)
            {
                    temp1 = numberOne[i];
                    temp2 = numberTwo[i];
                    numberGroupOne[i] = Convert.ToString(temp1);
                    numberGroupTwo[i] = Convert.ToString(temp2);
            }
            
            //Similar to the loop above. starting at 1 and then i-1 for the first digits, this prevents
            //adding a null when grabbing two numbers.
            //This also takes each number i position in array and assigns them to a temp int while
            //converting the string to a int16 to reduce memory 
                for (int i = 1; i < numberOne.Length; i++)
                {
                  
                    a1 = Convert.ToInt16(numberGroupOne[i - 1]);
                    b1 = Convert.ToInt16(numberGroupTwo[i - 1]);
                    a2 = Convert.ToInt16(numberGroupOne[i]);
                    b2 = Convert.ToInt16(numberGroupTwo[i]);

                //testing numberGroupOne and Two, array convert inputs
                    /*Console.WriteLine(a1);
                    Console.WriteLine(b1);
                    Console.WriteLine(a2);
                    Console.WriteLine(b2);*/

                    //takes temp int position from array from each array and adds them together.
                    //then asks if position temp 1 is equal to 2. If it does not equal it will return true 
                    //in the if statment which will return and exit false out of the method.
                    //Otherwise it will continue the loop with i++ incements everything until end of the
                    //number length ends resulting a loop exit of result true. 
                    if ((a1 + b1) != (a2 + b2))
                    {
                    //test this will write out the last numbers is comparison does not equal
                    //Console.WriteLine("digit 1 nummber, " + i + " cycle, Equals " + (a1 + b1));
                    //Console.WriteLine("digit 2 nummber, " + i + " cycle, Equals " + (a2 + b2));

                    //test loop exit answer
                    //Console.WriteLine("false");
                            return false;
                    }
                //test this will write out each loop comparison when the sums equal each other
                //Console.WriteLine("digit 1 nummber, " +i + " cycle, Equals " + (a1 + b1));
                //Console.WriteLine("digit 2 nummber, " +i + " cycle, Equals " + (a2 + b2));
            }
            //test loop exit answer
            //Console.WriteLine("true");
        return true;
           

          }
                                       

         
}

}
