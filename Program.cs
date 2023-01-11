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
            Console.Write(bs.Hello(15));
            Fizz_Buzz_Class.Fizz_Buzz fs = new Fizz_Buzz_Class.Fizz_Buzz();
            //await fs.Exersise2(11);
            //Console.WriteLine("{0}", fs.Exersise2(3));
            //await Hello(10);
            //var task = new Bootstrapper();
            //await task.Hello(11);
        }

        public class Bootstrapper
        {

            public async Task GetList()
            {
                Console.WriteLine("fuck!");
                int n = 0;
            }


            public string  Hello(int num)
            {
                int reminder3 = num % 3;
                int reminder5 = num % 5;
                //string result = "";

                if (reminder3 == 0 && reminder5 != 0)
                {
                    //Console.WriteLine("Fizz");
                    return "Fizz";
                }
                if (reminder5 == 0 && reminder3 != 0)
                {
                    //Console.WriteLine("Buzz");
                    return "Buzz";
                }
                if (reminder3 == 0 && reminder5 == 0)
                {
                    //Console.WriteLine("FizzBuzz");
                    return "FizzBuzz";
                }
                else
                {
                    //Console.Write(num);
                    return $"{num}";
                }
                //System.Console.WriteLine(result);
                //}
                //System.Console.ReadLine();
            }
        }
        

    }
}