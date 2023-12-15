using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public static class Tools
    {
        public static double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * (maximum - minimum) + minimum);
        }

        public static string GenderConverter(bool Gender)
        {
            if (Gender)
                return "Male";
            else
                return "Female";
        }

        public static ConsoleColor Color(double Number)
        {
            ConsoleColor FontColor = ConsoleColor.White;
            switch (Number)
            {
                case 1:
                    FontColor = ConsoleColor.Red;
                    break;
                case 0.75:
                    FontColor = ConsoleColor.Magenta;
                    break;
                case 0.5:
                    FontColor = ConsoleColor.Yellow;
                    break;
                case 0.25:
                    FontColor = ConsoleColor.Blue;
                    break;
                case 0:
                    FontColor = ConsoleColor.Green;
                    break;
            }
            return FontColor;
        }
    }
}
