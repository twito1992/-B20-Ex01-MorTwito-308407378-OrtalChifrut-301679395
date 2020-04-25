using System;
using System.Text;



namespace B20_Ex01_01
{
    public class B20_Ex01_01
    {
        public static void Main()
        {

            //string msg = bigAndSmallNumber(468, 466, 472);
            //Console.WriteLine(msg);

            //int counter = 0;
            //countOfNumbersInAscendingOrder("111011000", ref counter);
            //countOfNumbersInAscendingOrder("111010010", ref counter);
            //countOfNumbersInAscendingOrder("111010100", ref counter);
            //Console.WriteLine(counter);

            //int countrPowOfTwo = 0;
            //countPowOfTwo("10",ref countrPowOfTwo);
            //countPowOfTwo("100", ref countrPowOfTwo);
            //Console.WriteLine("The count of number with pow of 2 is: {0}",countrPowOfTwo);
            //int countOfzero = 0;
            //int countOfOne = 0;
            //double n1 = Math.Log(9, 2);
            //int n2 = (int)n1;
            //Console.WriteLine(n2);
            //string num1 = "1001001";//0=4,1=3
            //string num2 = "1001001";//0=4,1=3
            //string num3 = "1001001";//0=4,1=3
            ////0dig=12,1dig=9.avg0=4,avg1=3
            //countOfDigits(num1,ref countOfzero,ref countOfOne);
            //countOfDigits(num2, ref countOfzero,ref countOfOne);
            //countOfDigits(num3, ref countOfzero, ref countOfOne);

            //string msg = avgOfDigits(countOfzero,countOfOne);
            //Console.WriteLine(msg);

            binarySeries();
            Console.WriteLine("Please press 'ENTER' to exit...");
            Console.ReadLine();

        }

        private static string getInputFromUser()
        {
            string binaryNumber = Console.ReadLine();
            bool ifBinary = true;
            while ((inputBinaryChack(binaryNumber) == !ifBinary || (chackIfNumBase2(binaryNumber)==!ifBinary)))
            {
                Console.WriteLine("Error! wrong input {0}Please try again:", Environment.NewLine);
                binaryNumber = Console.ReadLine();
            }
            return binaryNumber;
        }

        private static bool inputBinaryChack(string i_userInput)
        {
            bool answer = true;

            if (i_userInput.Length != 9)
            {
                answer = false;
            }
            return answer;
        }

        private static bool chackIfNumBase2(string i_userInput)
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

        private static int convertBinNumToDecNum(string i_binaryNum)
        {
            int decNum = 0;

            for (int i = 0; i < i_binaryNum.Length; i++)
            {
                decNum = decNum + int.Parse(i_binaryNum[i_binaryNum.Length - (i + 1)].ToString()) * int.Parse(Math.Pow(2, i).ToString()); ;
            }
            return decNum;
        }

        private static void countOfDigits(string i_binaryInput, ref int io_countDigZero, ref int io_countDigOne)
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

        private static string avgOfDigits(int i_countDigZero, int i_countDigOne)
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

        private static int countPowOfTwo(string i_userInput, ref int io_countPowOfTwo)
        {
            int decNum = convertBinNumToDecNum(i_userInput);
            double powOfTow = Math.Log(decNum, 2);

            if (powOfTow == (int)powOfTow)
            {
                io_countPowOfTwo++;
            }
            return io_countPowOfTwo;
        }

        private static void countOfNumbersInAscendingOrder(string i_userInput, ref int io_counterOfNumbers)
        {
            int decNum = convertBinNumToDecNum(i_userInput);

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

        private static string bigAndSmallNumber(int decNumber1, int decNumber2, int decNumber3)
        {
            int big = decNumber1;
            int small;

            if (decNumber1 > decNumber2)
            {
                big = decNumber1;
                small = decNumber2;
            }
            else
            {
                big = decNumber2;
                small = decNumber1;
            }
            if (big < decNumber3)
            {
                big = decNumber3;
            }
            else
            {
                if (small > decNumber3)
                {
                    small = decNumber3;
                }
            }

            string msg = string.Format(
@"------------------The bigest and the smallest Number --------------
The bigest number Is : {0}
The smallest number is : {1} "
            , big, small);
            return msg;
        }

        private static string printDecNumber(ref string io_userInput1, ref string io_userInput2, ref string io_userInput3)
        {
            string msg = string.Format(

@"The {0} in dec Is : {1}
The {2} in dec Is : {3}
The {4} in dec Is : {5}",
            io_userInput1,
            convertBinNumToDecNum(io_userInput1),
            io_userInput2,
            convertBinNumToDecNum(io_userInput2),
            io_userInput3,
            convertBinNumToDecNum(io_userInput3)
            );
            return msg;
        }

        private static void binarySeries()
        {
            Console.WriteLine("Please enter 3 binary numbers with 9 digits each:");
            string userInput1= getInputFromUser(); ;
            string userInput2= getInputFromUser(); ;
            string userInput3= getInputFromUser(); ;
            string msg = string.Format(
            @"------------------Binary Series--------------
{0}",
            printDecNumber(ref userInput1,ref userInput2,ref userInput3)

            );

            Console.WriteLine(msg);
        }
    }


}



