using System;
using System.Text;

namespace B20_Ex01_4
{
    class Program
    {
        public static void Main()
        {
            StringAnalysis();
            Console.WriteLine("Please press 'ENTER' to exit...");
            Console.ReadLine();
        }

        private static bool IsPalindrome(string i_Str)
        {
            bool is_Palindrome = false;

            if (i_Str.Length <= 1)
            {
                return !is_Palindrome;
            }
            else
            {
                if (i_Str[0] != i_Str[i_Str.Length - 1])
                {
                    return is_Palindrome;
                }
                else
                {
                    return IsPalindrome(i_Str.Substring(1,i_Str.Length - 2));
                }
            }
        }
        private static bool IsNumDivBy5(string i_UserNumber)
        {
            int userNumber = 0;
            bool isNumber = int.TryParse(i_UserNumber,out userNumber);
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
        private static int CuntOfUpperCase(string i_UserStr)
        {
            int countOfUpper = 0;

            for (int i = 0; i < i_UserStr.Length; i++)
            {
                if (char.IsUpper(i_UserStr[i]))
                {
                    countOfUpper++;
                }
            }
            return countOfUpper;
        }
        private static bool CheckIfValidInput(string i_Str)
        {
            bool answer = true;

            if (i_Str.Length != 8)
            {
                answer = false;
            }
       

            else
            {
                bool isNumber = true;
                bool isChar = true;

                for (int i = 0; i < i_Str.Length - 1; i++)
                {
                    if (char.IsDigit(i_Str[i]) == isNumber)
                    {
                        if (char.IsDigit(i_Str[i + 1]) != isNumber)
                        {
                            answer = false;

                        }
                    }
                    else 
                        if (char.IsLetter(i_Str[i]) == isChar)
                        {
                            if (char.IsLetter(i_Str[i + 1]) != isChar)
                            {
                                answer = false;

                            }
                        }
                    else
                    {
                        answer = false;
                        break;
                    } 
                }

            //    for (int i = 0; i < i_Str.Length; i++)
            //    {
            //        if (char.IsLetter(i_Str[i]))
            //        {
            //            isChar = true;
            //        }
            //        else
            //            if (char.IsDigit(i_Str[i]))
            //        {
            //            isNumber = true;
            //        }
            //        else
            //            isSign = true;
            //    }
            //    if (((isChar == true) && (isNumber == true)) || (isSign == true))
            //    {
            //        return false;
            //    }
            }
            return answer;
        }
        private static string GetStringFromUser()
        {
            bool answer = true;

            Console.WriteLine("Please enter a string with 8 characters or digits:\n(note: not together)");
            string userStr = Console.ReadLine();
            while (CheckIfValidInput(userStr) == !answer)
            {
                Console.WriteLine("Error: Invalid string (Can be only characters or numbers not together and the size must be 8)");
                Console.WriteLine("Please try again:");
                userStr = Console.ReadLine();
            }
            return userStr;
        }
        private static void StringAnalysis()
        {
            string userStr = GetStringFromUser();
            StringBuilder msg = new StringBuilder();

            msg.AppendLine(
               "=====================String Analysis=====================");
            msg.AppendLine(
                string.Format("Is the string a Palindrome: {0}", IsPalindrome(userStr)));
            /* Because the string contains only characters or numbers,
            don't need to check the whole string but only the first character */
            if (char.IsDigit(userStr[0]) == true)
            {
                msg.AppendLine(
                    string.Format("Is it divisible by 5: {0}", IsNumDivBy5(userStr)));
            }
            else
            {
                msg.AppendLine(
                    string.Format("Number of Uppercases: {0}", CuntOfUpperCase(userStr)));
            }

            Console.WriteLine(msg);

        }
    }
}
