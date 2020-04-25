using System;
using System.Text;
using B20_Ex01_02;


namespace B20_Ex01_03
{
    public class B20_Ex01_03
    {

        public class Program
        {
            public static void Main()
            {
                ManageExercise3();
            }

            public static void ManageExercise3()
            {
                int heightOfHourglassInt = CheckInput();
                CheckAndFixEvenNumber(ref heightOfHourglassInt);
                PrintSandClock(heightOfHourglassInt);
            }

            public static int CheckInput()
            {
                Console.Write("Please enter the height of the Hourglass: ");
                string heightOfHourglassStr = Console.ReadLine();

                int heightOfHourglassInt;
                while ((int.TryParse(heightOfHourglassStr, out heightOfHourglassInt) != true) || (heightOfHourglassInt < 0))
                {
                    Console.Write("Invalid input, please enter the height of the Hourglass: ");
                    heightOfHourglassStr = Console.ReadLine();
                }

                return heightOfHourglassInt;
            }

            public static void CheckAndFixEvenNumber(ref int i_HeightOfHourglassInt)
            {
                if (i_HeightOfHourglassInt % 2 == 0)
                {
                    Console.WriteLine("Even number input, let me fix it for you...");
                    i_HeightOfHourglassInt++;
                }
            }

            public static void PrintSandClock(int i_HeightOfHourglassInt)
            {
                string outputString = string.Format("Sand Clock of {0} height:", i_HeightOfHourglassInt);
                Console.WriteLine(outputString);
                StringBuilder clockBuilder = new StringBuilder();
                //B20_Ex01_02.Program.CreateHourglass(clockBuilder, i_HeightOfHourglassInt); ///////// ?למה זה לא עובד? 
                Console.Write(clockBuilder);
            }
        }



    }
   
}