using System;
using System.Text;

namespace B20_Ex01_02
{
    public class B20_Ex01_02
    {
        public class Program
        {
            private const char Asterisk = '*';    //?אם זה מתשנה קבוע, צריך לכתוב את זה לפני המשתנה?
            private const char Space = ' ';

            public static void Main()
            {
                ManageExercise2();
            }

            public static void ManageExercise2()
            {
                const int HeightOfHourglass = 5;

                StringBuilder hourglassBuilder = new StringBuilder();
                CreateSandClock(hourglassBuilder, HeightOfHourglass);
                Console.WriteLine("Hourglass of 5 height:");
                Console.Write(hourglassBuilder);
            }

            public static void CreateSandClock(StringBuilder i_ClockBuilder, int i_HeightOfHourglass, int i_SpaceOfLine = 0)
            {
                string lineOfHourglass = NumberToSpaces(i_SpaceOfLine++) + NumberToAestrics(i_HeightOfHourglass);
                i_ClockBuilder.AppendLine(lineOfHourglass);

                if (i_HeightOfHourglass == 1)
                {
                    return;
                }

                CreateSandClock(i_ClockBuilder, i_HeightOfHourglass - 2, i_SpaceOfLine);
                i_ClockBuilder.AppendLine(lineOfHourglass);
            }

            public static string NumberToSpaces(int i_SpaceOfLine)
            {
                return new string(Space, i_SpaceOfLine);
            }

            public static string NumberToAestrics(int i_HeightOfHourglass)
            {
                return new string(Asterisk, i_HeightOfHourglass);
            }
        }
    }
}


