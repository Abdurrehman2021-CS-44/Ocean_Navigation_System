using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.DL;
using Ocean_Navigation.BL;
using Ocean_Navigation.UI;

namespace Ocean_Navigation
{
    class Program
    {
        static void Main(string[] args)
        {
            string coordPath = "coodinates.txt";
            if (ShipCrud.loadIntoList(coordPath))
            {
                Console.WriteLine("Data load Successfully");
            }
            Console.Read();
            string option;
            option = " ";
            do
            {
                Console.Clear();
                MenuUI.header();
                option = MenuUI.mainMenu();
                if (option == "1")
                {
                    Console.Clear();
                    MenuUI.header();
                    SHIP s = ShipUI.addShip();
                    ShipCrud.addIntoList(s);
                    ShipCrud.storeDataIntoFile(coordPath, s);
                }
                else if (option == "2")
                {
                    Console.Clear();
                    MenuUI.header();
                    ShipUI.shipPosition();
                }
                else if (option == "3")
                {
                    Console.Clear();
                    MenuUI.header();
                    ShipUI.shipSerialNumber();
                }
                else if (option == "4")
                {
                    Console.Clear();
                    MenuUI.header();
                    ShipUI.changeShipPosition();
                }
                else if (option == "5")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("Press any key to continue");
                Console.ReadKey();
            } while (true);
        }
    }
}
