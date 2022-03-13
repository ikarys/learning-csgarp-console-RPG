using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTutoRPG
{

    public static class ConsoleHelpers
    {
        public static void Display(string msg, int color = 15)
        {
            /*
             *  Black 	0
                Blue 	9
                Cyan 	11
                DarkBlue 	1
                DarkCyan 	3
                DarkGray 	8
                DarkGreen 	2
                DarkMagenta 	5
                DarkRed 	4
                DarkYellow 	6
                Gray 	7
                Green 	10
                Magenta 	13
                Red 	12
                White 	15
                Yellow 	14
             */
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.ForegroundColor = colors[color];
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}