using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number: ");
                var userNumber1 =(Console.ReadLine());
            Console.WriteLine("Please Enter a 2nd number matching the digit lenght of the 1st:");
                var userNumber2 = (Console.ReadLine());

           bool answer = PlaceSumTotal(userNumber1, userNumber2);
            
            Console.WriteLine("The answer is " + answer);
            Console.ReadLine();
            //if (NumberCheck(userNumber1) == true && )
            
        }

        public static bool NumberCheck(string x)
        {
            var testLenght = x.Length;
            if (testLenght > 0 && testLenght < 4)
                return true;
            else
            {
                return false;
            }
        }

       /* public static bool IntagerCheck()
        {
            return;
        }
        */
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

                    Console.WriteLine(a1);
                    Console.WriteLine(b1);
                    Console.WriteLine(a2);
                    Console.WriteLine(b2);

                    if ((a1 + b1) != (a2 + b2))
                    {
                        Console.WriteLine(a1 + b1);
                        Console.WriteLine(a2 + b2);
                        Console.WriteLine("false");
                        return false;
                    }

                }
            Console.WriteLine("true");
        return true;
           

        }
                                       

         
}

}
