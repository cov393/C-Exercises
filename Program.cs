// Create a method which will accept a positive integer input and return a value according to the following rules:

// For multiples of 3 return “Fizz”
// For multiples of 5 return “Buzz”
// For multiples of both 3 and 5, return “FizzBuzz”
// For any other input (valid or otherwise) return a string representation of the input


using System;
using System.Collections.Generic;
using System.IO;

namespace Next_exersise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var prog = new Exsersise();
            string btchid = PrintFizzBuzz;

        }

        internal static string PrintFizzBuzz(int input)
        {
            Console.WriteLine("Its woking!");
            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                                else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
                string NewInput = input.ToString();
                return NewInput;
                // Your code goes here
            }
        }
    }
}
//    private class Exsersise
//        {
//            class PrintFizzBuzz (15)
//            { 
//                Console.WriteLine("Its woking!");
//                for (int i = 1; i <= input; i++)
//                {
//                    if (i % 3 == 0 && i % 5 == 0)
//                    {
//                        Console.WriteLine("FizzBuzz");
//                    else if (i % 3 == 0)
//                    {
//                        Console.WriteLine("Fizz");
//                    }
//                    else if (i % 5 == 0)
//                    {
//                        Console.WriteLine("Buzz");
//                    }
//                    else
//                    {
//                        Console.WriteLine(i);
//                    }
//                }
//                string NewInput = input.ToString();
//                return NewInput;
//                // Your code goes here
//            }
//        }
//    }
//}
