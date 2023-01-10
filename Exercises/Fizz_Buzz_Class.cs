//Create a method which will accept a positive integer input and return a value according to the following rules:

//For multiples of 3 return “Fizz”
//For multiples of 5 return “Buzz”
//For multiples of both 3 and 5, return “FizzBuzz”
//For any other input (valid or otherwise) return a string representation of the input
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_exersise.Exercises
{
    class Fizz_Buzz_Class
    {
        public class Fizz_Buzz
        {
            public async Task<int> Exersise1()
            {
                int num = 10;
                //for (int counter = 1; counter <= 100; counter++)
                //{
                int reminder3 = num % 3;
                int reminder5 = num % 5;
                //string result = "";

                if (reminder3 == 0 && reminder5!=0)
                {
                    Console.WriteLine("Fizz");
                }
                if (reminder5 == 0 && reminder3!=0)
                {
                    Console.WriteLine("Buzz");
                }
                if (reminder3 == 0 && reminder5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    return num;
                }
                    //System.Console.WriteLine(result);
                //}
                System.Console.ReadLine();
            }
        }
    }
}
