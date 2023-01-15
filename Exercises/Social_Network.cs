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
            
            string s1 = str[0];

            int count_possition = 0;
            string signs = "?";
            string indicator = "@";
            string indicator_name = "";
            string main_result = "";
            
            for (int i = 0; i <= str.Length - 1; i++)
            {
                if (str[i].Contains(indicator))
                {
                    string result1 = str[i].Remove(0, 1);
                    indicator_name += result1;
                    indicator_name += " ";
                    if (indicator_name.Contains(signs))
                    {
                        for (int j=0; j <= indicator_name.Length - 1; j++)
                        {
                            count_possition += 1;
                            if (indicator_name[j] == signs[0])
                            {                                 
                                main_result = indicator_name.Remove(count_possition-1);
                            }                            
                        }
                    } 
                    else if(!indicator_name.Contains(signs))
                    {
                        main_result = indicator_name;
                    }
                }
            }
            string[] main_result_split = main_result.Split(" ");
            return main_result_split[position - 1];

            // Your code goes here
        }
    }
}
