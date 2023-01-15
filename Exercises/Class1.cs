using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_exersise.Exercises
{
    public class Class1
    {
        public string Recipt(string message, int position)
        {
            Console.WriteLine(message);
            string[] str = message.Split(" ");

            int calc_pos = 1;
            string sign1 = "@";
            string sign2 = "?";

            for (int i = 0; i <= str.Length - 1; i++)
            {
                if (str[i].Contains(sign1))
                {
                    if (str[i].Contains(sign2))
                    {
                        string result1 = str[i].Remove(str[i].Length - 1, 1);
                        //Console.WriteLine($"result 1: {result1}");
                        string result = result1.Remove(0, 1);
                        Console.WriteLine($"GetRecipient(message,{position}): {result}");
                        //calc_pos += 1;
                    }

                    else if(!str[i].Contains(sign2))
                    {
                        string result = str[i].Remove(0, 1);
                        Console.WriteLine($"GetRecipient(message,{position}): {result}");
                        //calc_pos += 1;
                    }                    
                }                
            }
            return "";
        }
    }
}
