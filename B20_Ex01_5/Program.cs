using System;

namespace B20_Ex01_05
{
    public class B20_Ex01_05
    {
        public static void Main ()
        {
            NumberStatistics();
            Console.WriteLine("Please press 'ENTER' to exit...");
            Console.ReadLine();
        }

        private static int GetTheBigestDig(int i_UserNumber)
        {
            int bigDig = 0;

            while (i_UserNumber > 0)
            {
                if (bigDig < i_UserNumber % 10)
                {
                    bigDig = i_UserNumber % 10;
                }
                i_UserNumber = i_UserNumber / 10;
            }
            return bigDig;
        }

        private static int GetThelowestDig(int i_UserNumber)
        {
            int smallestDig = 10;

            while (i_UserNumber > 0)
            {
                if (smallestDig > i_UserNumber % 10)
                {
                    smallestDig = i_UserNumber % 10;
                }
                i_UserNumber = i_UserNumber / 10;
            }
            return smallestDig;
        }

        private static int GetTheCountOfDigDivBy3(int i_UserNumber)
        {
            int countDivBy3 = 0;

            while (i_UserNumber > 0)
            {
                if (i_UserNumber % 10 % 3 == 0)
                {
                    countDivBy3++;
                }
                i_UserNumber = i_UserNumber / 10;
            }
            return countDivBy3;
        }
        private static int GetTheCountOfDigitUpperThenUnityDigit(int i_UserNumber)
        {
            int countOfDigitUpperThenUnityDigit = 0;
            int unityDigit = i_UserNumber % 10;

            i_UserNumber = i_UserNumber / 10;
            while (i_UserNumber > 0)
            {
                if (unityDigit < i_UserNumber % 10)
                {
                    countOfDigitUpperThenUnityDigit++;
                }
                i_UserNumber = i_UserNumber / 10;
            }
            return countOfDigitUpperThenUnityDigit;
        }
        private static bool CheckIfValidInputFromUser(string i_UserInput)
        {
            bool checkIfItsANumber = false;

            if (i_UserInput.Length != 9)
            {
                return checkIfItsANumber;
            }

            int userNumber = 0;
            bool answer = true;

            checkIfItsANumber = int.TryParse(i_UserInput, out userNumber);
            if ((checkIfItsANumber == false) || (userNumber < 0))
            {
                answer = false;
            }
            return answer;
          }
        private static string GetInputFromUser()
        {
            bool fleg = true;

            Console.WriteLine("Plase enter 9-digits positiv number:");

            string userInput= Console.ReadLine();

            while (CheckIfValidInputFromUser(userInput) == !fleg)
            {
                Console.WriteLine("Error!\nInvalid input (Can be only positive numbers and the size must be 9)\n----------------------------------\nPlease try again:");
                userInput = Console.ReadLine();
            }
            return userInput;
        }
        private static void NumberStatistics()
        {
            string userInput = GetInputFromUser();
            int userNumber = int.Parse(userInput);
            string msg = string.Format(
@"------------------Number Statistics--------------
The number Is : {0}
The bigest digit is : {1}
The smallest digit is : {2}
The number of digit divided by 3 is : {3}
The number of digit bigger then unit digit is : {4} ",
            userNumber,
            GetTheBigestDig(userNumber),
            GetThelowestDig(userNumber),
            GetTheCountOfDigDivBy3(userNumber),
            GetTheCountOfDigitUpperThenUnityDigit(userNumber));

            Console.WriteLine(msg);
        }

    }
}


