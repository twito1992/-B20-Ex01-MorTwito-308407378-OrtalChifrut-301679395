using System;
using System.Text;

namespace B20_Ex01_01
{
    public class B20_Ex01_01
    {
        public static void Main()
        {
            //binarySeries();
            Console.WriteLine("Please press 'ENTER' to exit...");
            Console.ReadLine();
            
        }

        private static string getInputFromUser()
        {
            string binaryNumber = Console.ReadLine();
            while (!(inputBinaryChack(binaryNumber) || !(chackIfNumBase2(binaryNumber))))
            {
                Console.WriteLine("Error! wrong input {0}Please try again:",Environment.NewLine);
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
                if ((i_userInput[i] != '0') || (i_userInput[i] != '1'))
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
                decNum = decNum + int.Parse(i_binaryNum[i_binaryNum.Length - (++i)].ToString()) * int.Parse(Math.Pow(2, i).ToString()); ;
            }
            return decNum;
        }

        private static void countOfDigits(string i_binaryinput,ref int io_countDigZero, ref int io_countDigOne,)
        {
            for (int i = 0; i < i_binaryinput.Length; i++)
            {
                if(i_binaryinput[i] == '0')
                {
                    io_countDigZero++;
                }
                if (i_binaryinput[i] == '1')
                {
                    io_countDigOne++;
                }
            }
        }
        

    }
}


