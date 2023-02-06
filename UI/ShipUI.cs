using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;
using Ocean_Navigation.DL;

namespace Ocean_Navigation.UI
{
    class ShipUI
    {
        public static SHIP addShip()
        {
            Console.WriteLine();
            Console.WriteLine("Main Menu > Add Ship");
            Console.WriteLine("--------------------");
            string sNumber;
            while (true)
            {
                Console.Write("Enter Ship Serial Number : ");
                sNumber = Console.ReadLine();
                if (ShipCrud.isShipExist(sNumber))
                {
                    Console.WriteLine("This name is already taken.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Enter Ship Latitude");
            ANGLE sLongitude = AngleUI.takeInputForAngle();
            Console.WriteLine("Enter Ship Longitude");
            ANGLE sLatitude = AngleUI.takeInputForAngle();
            SHIP ship = new SHIP(sNumber, sLatitude, sLongitude);
            return ship;
        }
        public static void shipPosition()
        {
            Console.WriteLine();
            Console.WriteLine("Main Menu > View Ship Position");
            Console.WriteLine("------------------------------");
            string sNum;
            Console.Write("Enter Serial Number : ");
            sNum = Console.ReadLine();
            foreach (SHIP i in ShipCrud.ship)
            {
                if (i.isShipExist(sNum))
                {
                    Console.WriteLine("Ship is at " + i.getsLatitude().getsDegree() + "\u00b0" + i.getsLatitude().getsMinutes() + "'" + i.getsLatitude().getsDirection() + " and " + i.getsLongtitude().getsDegree() + "\u00b0" + i.getsLongtitude().getsMinutes() + "'" + i.getsLongtitude().getsDirection());
                }
            }
        }
        public static void shipSerialNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Main Menu > View Ship Serial Number");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Enter Ship Latitude");
            ANGLE sLatitude = AngleUI.takeInputForAngle();
            Console.WriteLine("Enter Ship Longitude");
            ANGLE sLongitude = AngleUI.takeInputForAngle();
            foreach (SHIP i in ShipCrud.ship)
            {
                if (i.coordinateChecker(sLatitude, sLongitude))
                {
                    Console.WriteLine("Ship Serial Number is " + i.getsNumber());
                }
            }
        }
        public static void changeShipPosition()
        {
            Console.WriteLine();
            Console.WriteLine("Main Menu > Change Ship Position");
            Console.WriteLine("--------------------------------");
            string sNum;
            Console.Write("Enter Ship Serial Number : ");
            sNum = Console.ReadLine();
            foreach (SHIP i in ShipCrud.ship)
            {
                if (i.isShipExist(sNum))
                {
                    Console.WriteLine("Enter Ship Latitude");
                    Console.Write("Enter Latitude's Degree : ");
                    i.getsLatitude().setsDegree(int.Parse(Console.ReadLine()));
                    Console.Write("Enter Latitude's Minutes : ");
                    i.getsLatitude().setsMinutes(float.Parse(Console.ReadLine()));
                    Console.Write("Enter Latitude's Direction : ");
                    i.getsLatitude().setsDirection(char.Parse(Console.ReadLine()));
                    Console.WriteLine("Enter Ship Longitude");
                    Console.Write("Enter Longitude's Degree : ");
                    i.getsLongtitude().setsDegree(int.Parse(Console.ReadLine()));
                    Console.Write("Enter Longitude's Minutes : ");
                    i.getsLongtitude().setsMinutes(float.Parse(Console.ReadLine()));
                    Console.Write("Enter Longitude's Direction : ");
                    i.getsLongtitude().setsDirection(char.Parse(Console.ReadLine()));
                }
            }
        }
    }
}
