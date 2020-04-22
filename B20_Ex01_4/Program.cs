using System;
using System.Text;

namespace B20_Ex01_4
{
    class Program
    {
        public static void Main()
        {
            stringAnalysis();
            Console.WriteLine("Please press 'ENTER' to exit...");
            Console.ReadLine();
        }

        private static bool isPalindrome(string i_str)
        {
            bool is_Palindrome = false;
            if (i_str.Length <= 1)
            {
                return !is_Palindrome;
            }
            else
            {
                if (i_str[0] != i_str[i_str.Length - 1])
                {
                    return is_Palindrome;
                }
                else
                {
                    return isPalindrome(i_str.Substring(1,i_str.Length - 2));
                }
            }
        }
        private static bool isNumDivBy5(string i_userNumber)
        {
            int userNumber = 0;
            bool isNumber = int.TryParse(i_userNumber,out userNumber);
            bool divBy5 = false;
            if (isNumber == true)
            {
                if(userNumber %5 == 0)
                {
                    divBy5 = !divBy5;
                }
            }
            return divBy5;
        }
        private static int cuntOfUpperCase(string i_userStr)
        {
            int countOfUpper = 0;
            for (int i = 0; i < i_userStr.Length; i++)
            {
                if (char.IsUpper(i_userStr[i]))
                {
                    countOfUpper++;
                }
            }
            return countOfUpper;
        }
        private static bool checkIfValidInput(string i_Str)
        {
            if (i_Str.Length != 8)
            {
                return false;
            }
            bool isNumber = false;
            bool isChar = false;
            bool isSign = false;
            for (int i = 0; i < i_Str.Length; i++)
            {
                if (char.IsLetter(i_Str[i]))
                {
                    isChar = true;
                }
                else
                    if (char.IsDigit(i_Str[i]))
                {
                    isNumber = true;
                }
                else
                    isSign = true;
            }
            if (((isChar == true) && (isNumber == true))||(isSign == true))
            {
                return false;
            }
            return true;
        }
        private static string getStringFromUser()
        {
            Console.WriteLine("Please enter a string with 8 characters or digits:\n(note: not together)");
            string userStr = Console.ReadLine();
            while (checkIfValidInput(userStr) == false)
            {
                Console.WriteLine("Error: Invalid string (Can be only characters or numbers not together and the size must be 8)");
                Console.WriteLine("Please try again:");
                userStr = Console.ReadLine();
            }
            return userStr;
        }
        private static void stringAnalysis()
        {
            string userStr = getStringFromUser();
            StringBuilder msg = new StringBuilder();
            msg.AppendLine(
               "=====================String Analysis=====================");
            msg.AppendLine(
                string.Format("Is the string a Palindrome: {0}", isPalindrome(userStr)));
            /* Because the string contains only characters or numbers,
            don't need to check the whole string but only the first character */
            if (char.IsDigit(userStr[0]) == true)
            {
                msg.AppendLine(
                    string.Format("Is it divisible by 5: {0}", isNumDivBy5(userStr)));
            }
            else
            {
                msg.AppendLine(
                    string.Format("Number of Uppercases: {0}", cuntOfUpperCase(userStr)));
            }

            Console.WriteLine(msg);

        }
    }
}
