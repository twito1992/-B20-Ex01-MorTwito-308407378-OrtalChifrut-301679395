﻿using System;
using System.Text;


namespace B20_Ex01_02
{
    public class B20_Ex01_02
    {
        public class Program
        {
            private const char k_Asterisk = '*';    //?אם זה מתשנה קבוע, צריך לכתוב את זה לפני המשתנה?
            private const char k_Space = ' ';

            public static void Main()
            {
                ManageExercise2();
                Console.WriteLine("Please press 'ENTER' to exit...");
                Console.ReadLine();
            }

            public static void ManageExercise2()
            {
                const int HeightOfHourglass = 5;

                StringBuilder hourglassBuilder = new StringBuilder();
                CreateHourglass(hourglassBuilder, HeightOfHourglass);
                Console.WriteLine("Hourglass of 5 height:");
                Console.Write(hourglassBuilder);
            }

            public static void CreateHourglass(StringBuilder i_HourglassBuilder, int i_HeightOfHourglass, int i_SpaceOfLine = 0)
            {
                string lineOfHourglass = NumberToSpaces(i_SpaceOfLine++) + NumberToAestrics(i_HeightOfHourglass);
                i_HourglassBuilder.AppendLine(lineOfHourglass);

                if (i_HeightOfHourglass == 1)
                {
                    return;
                }

                CreateHourglass(i_HourglassBuilder, i_HeightOfHourglass - 2, i_SpaceOfLine);
                i_HourglassBuilder.AppendLine(lineOfHourglass);
            }

            public static string NumberToSpaces(int i_SpaceOfLine)
            {
                return new string(k_Space, i_SpaceOfLine);
            }

            public static string NumberToAestrics(int i_HeightOfHourglass)
            {
                return new string(k_Asterisk, i_HeightOfHourglass);
            }
        }
    }
}
