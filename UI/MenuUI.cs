using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation.UI
{
    class MenuUI
    {
        public static void header()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("*         Ocean Navigator        *");
            Console.WriteLine("**********************************");
        }
        public static string mainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Main Menu");
            Console.WriteLine("---------");
            Console.WriteLine("1 -> Add Ship");
            Console.WriteLine("2 -> View Ship Position");
            Console.WriteLine("3 -> View Ship Serial Number");
            Console.WriteLine("4 -> Change Ship Position");
            Console.WriteLine("5 -> Exit");
            string option;
            Console.Write("Your Option...");
            option = Console.ReadLine();
            return option;
        } 
    }
}
