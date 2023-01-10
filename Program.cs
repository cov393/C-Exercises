// Create a method which will accept a positive integer input and return a value according to the following rules:

// For multiples of 3 return “Fizz”
// For multiples of 5 return “Buzz”
// For multiples of both 3 and 5, return “FizzBuzz”
// For any other input (valid or otherwise) return a string representation of the input


using Next_exersise.Exercises;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Next_exersise
{
    class Program
    {
        //public  Fizz_Buzz_Class _fizz_buzz;
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bootstrapper bs = new Bootstrapper();
            await bs.GetList();
            Fizz_Buzz_Class.Fizz_Buzz fs = new Fizz_Buzz_Class.Fizz_Buzz();
            await fs.Exersise1();
            
        }

        public class Bootstrapper
        {

            public async Task GetList()
            {
                Console.WriteLine("fuck!");
            }
        }
        private async Task Hello()
        {
            Console.WriteLine("Hello");
        }

    }
}