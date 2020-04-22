using System;

namespace B20_Ex01_05
{
    public class B20_Ex01_05
    {
        public static void Main ()
        {
            numberStatistics();
            Console.WriteLine("Please press 'ENTER' to exit...");
            Console.ReadLine();
        }

        private static int getTheBigestDig(int i_userNumber)
        {
            int bigDig = 0;
            while (i_userNumber > 0)
            {
                if (bigDig < i_userNumber % 10)
                {
                    bigDig = i_userNumber % 10;
                }
                i_userNumber = i_userNumber / 10;
            }
            return bigDig;
        }

        private static int getThelowestDig(int i_userNumber)
        {
            int smallestDig = 10;
            while (i_userNumber > 0)
            {
                if (smallestDig > i_userNumber % 10)
                {
                    smallestDig = i_userNumber % 10;
                }
                i_userNumber = i_userNumber / 10;
            }
            return smallestDig;
        }

        private static int getTheCountOfDigDivBy3(int i_userNumber)
        {
            int countDivBy3 = 0;
            while (i_userNumber > 0)
            {
                if (i_userNumber % 10 % 3 == 0)
                {
                    countDivBy3++;
                }
                i_userNumber = i_userNumber / 10;
            }
            return countDivBy3;
        }
        private static int getTheCountOfDigitUpperThenUnityDigit(int i_userNumber)
        {
            int countOfDigitUpperThenUnityDigit = 0;
            int unityDigit = i_userNumber % 10;
            i_userNumber = i_userNumber / 10;
            while (i_userNumber > 0)
            {
                if (unityDigit < i_userNumber % 10)
                {
                    countOfDigitUpperThenUnityDigit++;
                }
                i_userNumber = i_userNumber / 10;
            }
            return countOfDigitUpperThenUnityDigit;
        }
        private static bool checkIfValidInputFromUser(string i_userInput)
        {
            bool checkIfItsANumber = false;
            if (i_userInput.Length != 9)
            {
                return checkIfItsANumber;
            }
            int userNumber = 0;
            checkIfItsANumber = int.TryParse(i_userInput, out userNumber);
            if ((checkIfItsANumber == false) || (userNumber < 0))
            {
                return false;
            }
            return true;
          }
        private static string getInputFromUser()
        {           
            Console.WriteLine("Plase enter 9-digits positiv number:");
            string userInput= Console.ReadLine();

            while (checkIfValidInputFromUser(userInput) == false)
            {
                Console.WriteLine("Error!\nInvalid input (Can be only positive numbers and the size must be 9)\n----------------------------------\nPlease try again:");
                userInput = Console.ReadLine();
            }
            return userInput;
        }
        private static void numberStatistics()
        {
            string userInput = getInputFromUser();
            int userNumber = int.Parse(userInput);
            string msg = string.Format(
@"------------------Number Statistics--------------
The number Is : {0}
The bigest digit is : {1}
The smallest digit is : {2}
The number of digit divided by 3 is : {3}
The number of digit bigger then unit digit is : {4} ",
            userNumber,
            getTheBigestDig(userNumber),
            getThelowestDig(userNumber),
            getTheCountOfDigDivBy3(userNumber),
            getTheCountOfDigitUpperThenUnityDigit(userNumber));

            Console.WriteLine(msg);
        }

    }
}


