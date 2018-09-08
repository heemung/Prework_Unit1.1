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
            Console.WriteLine("Please Enter a three digit number: ");
            var userNumber1 =(Console.ReadLine());

            if (NumberCheck(userNumber1) == true && )
                Console.WriteLine("Please Enter a 2nd three digit number");
                var userNumber2 = (Console.ReadLine());



            PlaceSumTotal(userNumber1, userNumber2);


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
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

        public static bool IntagerCheck()
        {
            return;
        }

        public static string PlaceSumTotal (string numberOne, string numberTwo)
            {
            char[] groupOne = numberOne.ToCharArray();
            char[] groupTwo = numberOne.ToCharArray();

            foreach (char c in groupOne)

                groupOne[] +
                


            return;

            }
                                       

         
}

}
