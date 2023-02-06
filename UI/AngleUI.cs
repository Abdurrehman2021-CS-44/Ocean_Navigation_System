using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;

namespace Ocean_Navigation.UI
{
    class AngleUI
    {
        public static ANGLE takeInputForAngle()
        {
            int degree;
            float minutes;
            char direction;
            Console.Write("Enter Degree : ");
            degree = int.Parse(Console.ReadLine());
            Console.Write("Enter Minutes : ");
            minutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Direction : ");
            direction = char.Parse(Console.ReadLine());
            ANGLE coord = new ANGLE(degree, minutes, direction);
            return coord;
        }
    }
}
