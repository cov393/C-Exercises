////Create a method which will accept a positive integer input and return a value according to the following rules:

////For multiples of 3 return “Fizz”
////For multiples of 5 return “Buzz”
////For multiples of both 3 and 5, return “FizzBuzz”
using System;
using System.Collections.Generic;
using System.IO;

namespace Next_exersise.Exersises
{
    public class Solution
    {
        public string PrintFizzBuzz(int input)
        {
            if (input >= 0)
            {
                int reminder3 = input % 3;
                int reminder5 = input % 5;
                //string result = "";

                if (reminder3 == 0 && reminder5 != 0)
                {
                    return "Fizz";
                }
                if (reminder5 == 0 && reminder3 != 0)
                {
                    return "Buzz";
                }
                if (reminder3 == 0 && reminder5 == 0)
                {
                    return "FizzBuzz";
                }
                else
                {
                    return $"{input}";
                }
            }
            return $"{input}";
        }
    }
}