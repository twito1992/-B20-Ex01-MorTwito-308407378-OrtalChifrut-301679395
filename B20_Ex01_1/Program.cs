using System;
using System.Text;



namespace B20_Ex01_01
{
    public class B20_Ex01_01
    {
        public static void Main()
        {
            
            BinarySeries();
            Console.WriteLine("Please press 'ENTER' to exit...");
            Console.ReadLine();

        }

        private static string GetInputFromUser()
        {
            string binaryNumber = Console.ReadLine();
            bool ifBinary = true;
            while ((InputBinaryChack(binaryNumber) == !ifBinary || (ChackIfNumBase2(binaryNumber)==!ifBinary)))
            {
                Console.WriteLine("Error! wrong input {0}Please try again:", Environment.NewLine);
                binaryNumber = Console.ReadLine();
            }
            return binaryNumber;
        }

        private static bool InputBinaryChack(string i_userInput)
        {
            bool answer = true;

            if (i_userInput.Length != 9)
            {
                answer = false;
            }
            return answer;
        }

        private static bool ChackIfNumBase2(string i_userInput)
        {
            bool answer = true;

            for (int i = 0; i < i_userInput.Length; i++)
            {
                if ((i_userInput[i] != '0') && (i_userInput[i] != '1'))
                {
                    answer = false;
                }
            }
            return answer;
        }

        private static int ConvertBinNumToDecNum(string i_binaryNum)
        {
            int decNum = 0;

            for (int i = 0; i < i_binaryNum.Length; i++)
            {
                decNum = decNum + int.Parse(i_binaryNum[i_binaryNum.Length - (i + 1)].ToString()) * int.Parse(Math.Pow(2, i).ToString()); ;
            }
            return decNum;
        }

        private static void CountOfDigits(string i_binaryInput, ref int io_countDigZero, ref int io_countDigOne)
        {
            for (int i = 0; i < i_binaryInput.Length; i++)
            {
                if (i_binaryInput[i] == '0')
                {
                    io_countDigZero++;
                }
                if (i_binaryInput[i] == '1')
                {
                    io_countDigOne++;
                }
            }

        }

        private static string AvgOfDigits(int i_countDigZero, int i_countDigOne)
        {
            float avgOf0 = i_countDigZero / 3;
            float avgOf1 = i_countDigOne / 3;

            string msg = string.Format(
@"------------------Binary AVG--------------
Avg of 0 digits is: {0}
Avg of 1 digits is: {1} ",
          avgOf0,
          avgOf1);

            return msg;
        }

        private static void CountPowOfTwo(string i_userInput, ref int io_countPowOfTwo)
        {     
            int decNum = ConvertBinNumToDecNum(i_userInput);
            double powOfTwo = Math.Log(decNum, 2);
            int powOfTwoInt = Convert.ToInt16(powOfTwo);

            if (powOfTwo == powOfTwoInt)
            {
                io_countPowOfTwo++;
            }
            
        }

        private static void CountOfNumbersInAscendingOrder(string i_userInput, ref int io_counterOfNumbers)
        {
            int decNum = ConvertBinNumToDecNum(i_userInput);

            while (decNum > 9)
            {
                if (decNum % 10 <= decNum / 10 % 10)
                {
                    break;
                }
                decNum = decNum / 10;
            }
            if (decNum < 9)
            {
                io_counterOfNumbers++;
            }
        }

        private static string MaxAndMin(string i_userInput1, string i_userInput2, string i_userInput3)
        {
            int decNumber1 = ConvertBinNumToDecNum(i_userInput1); 
            int decNumber2 = ConvertBinNumToDecNum(i_userInput2); 
            int decNumber3 = ConvertBinNumToDecNum(i_userInput3);
            int max = decNumber1;
            int min;

            if (decNumber1 > decNumber2)
            {
                max = decNumber1;
                min = decNumber2;
            }
            else
            {
                max = decNumber2;
                min = decNumber1;
            }
            if (max < decNumber3)
            {
                max = decNumber3;
            }
            else
            {
                if (min > decNumber3)
                {
                    min = decNumber3;
                }
            }

            string msg = string.Format(
@"------------------The bigest and the smallest Number --------------
The bigest number Is : {0}
The smallest number is : {1} "
            , max, min);
            return msg;
        }

        private static string PrintDecNumber(ref string io_userInput1, ref string io_userInput2, ref string io_userInput3)
        {
            string msg = string.Format(

@"The {0} in dec Is : {1}
The {2} in dec Is : {3}
The {4} in dec Is : {5}",
            io_userInput1,
            ConvertBinNumToDecNum(io_userInput1),
            io_userInput2,
            ConvertBinNumToDecNum(io_userInput2),
            io_userInput3,
            ConvertBinNumToDecNum(io_userInput3)
            );
            return msg;
        }

        private static void BinarySeries()
        {
            int countOfzero = 0;
            int countOfOne = 0;

            Console.WriteLine("Please enter 3 binary numbers with 9 digits each:");

            string userInput1= GetInputFromUser(); 
            string userInput2= GetInputFromUser(); 
            string userInput3= GetInputFromUser();
            int countOfTwo = 0;
            int counterOforderNum = 0;

            CountOfDigits(userInput1,ref countOfzero,ref countOfOne);
            CountOfDigits(userInput2, ref countOfzero, ref countOfOne);
            CountOfDigits(userInput3, ref countOfzero, ref countOfOne);

            CountPowOfTwo(userInput1,ref countOfTwo);
            CountPowOfTwo(userInput2, ref countOfTwo);
            CountPowOfTwo(userInput3, ref countOfTwo);

            CountOfNumbersInAscendingOrder(userInput1,ref counterOforderNum);
            CountOfNumbersInAscendingOrder(userInput2, ref counterOforderNum);
            CountOfNumbersInAscendingOrder(userInput3, ref counterOforderNum);

            string msg = string.Format(
            @"------------------Binary Series--------------
{0}
{1}
------------------Pow Of Two-------------
The count of number pow of two is: {2}
------------------Series-------------
The count of Series is: {3}"
,
            PrintDecNumber(ref userInput1, ref userInput2, ref userInput3),
            AvgOfDigits(countOfzero, countOfOne),
            countOfTwo,
            counterOforderNum,
            MaxAndMin(userInput1,userInput2,userInput3)
            );

            Console.WriteLine(msg);
        }
    }


}



