//using System;
//using System.Collections.Generic;
//using System.Linq;
//In a social network all message recipients are identified by preceding their username with the '@' symbol.

//Recipients can occur at any point in the message
//Usernames can contain letters, numbers, underscores and hyphens
//Any character which is not a valid username character will separate the recipients from the rest of the message
//Email addresses should not be matched as usernames
//Create a method which can return the username of the nth recipient in the message. n is the (1 based)
//position of the recipient in the message. The method should receive two parameters - the message and the position of the recipient.
//If the recipient isn't found then the method should return an empty string. For example:


//var message = "@User_One @UserABC! Have you seen this from @Userxyz?";
//GetRecipient(message, 1) = "User_One";
//GetRecipient(message, 2) = "UserABC";
//GetRecipient(message, 3) = "Userxyz";
//GetRecipient(message, 4) = "";


using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Next_exersise.Exercises
{
    public class Solution
    {

        public string GetRecipient(string message, int position)
        {
            string[] str = message.Split(" ");

            //   string s1 = str[0];
            //   Console.WriteLine(s1);

            for (int i = 0; i <= str.Length - 1; i++)
            {
                if (str[i] == "@")
                {
                    Console.
                }
            }

            foreach (string s1 in str)
            {

                // string AtResult = i.IndexOf("@");
                // Console.WriteLine(s1);

                string result = s1.IndexOf("@");

                Console.WriteLine(result);

                // if (string i == AtResult){
                //     Console.WriteLine("Found");
                // }
                // else{
                //     Console.WriteLine("not found");
                // }

            }


            // Console.WriteLine(message);
            // string simb = "@";
            // foreach(char words in message){
            //     Console.WriteLine(words);
            // }


            // Console.WriteLine("( message, "+position+" = "+message);

            // Console.WriteLine(position);
            // Console.WriteLine(message + message.IndexOf("@"));
            return "";
            // Your code goes here
        }
    }
}
