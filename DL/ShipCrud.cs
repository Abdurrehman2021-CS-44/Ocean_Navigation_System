using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;
using System.IO;

namespace Ocean_Navigation.DL
{
    class ShipCrud
    {
        public static List<SHIP> ship = new List<SHIP>();
        public static void addIntoList(SHIP s)
        {
            ship.Add(s);
        }
        public static bool isShipExist(string sName)
        {
            foreach (SHIP i in ship)
            {
                if (i.getsNumber() == sName)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool loadIntoList(string path)
        {
            StreamReader file = new StreamReader(path);
            string record = "";
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedString = record.Split(',');
                    string name = splittedString[0];
                    int latDegree = int.Parse(splittedString[1]);
                    float latMinutes = float.Parse(splittedString[2]);
                    char latDirection = char.Parse(splittedString[3]);
                    int lonDegree = int.Parse(splittedString[4]);
                    float lonMinutes = float.Parse(splittedString[5]);
                    char lonDirection = char.Parse(splittedString[6]);
                    ANGLE sLatitude = new ANGLE(latDegree, latMinutes, latDirection);
                    ANGLE sLongitude = new ANGLE(lonDegree, lonMinutes, lonDirection);
                    SHIP s = new SHIP(name, sLatitude, sLongitude);
                    addIntoList(s);
                }
                file.Close();
                return true;
            }
            return false;
        }
        public static void storeDataIntoFile(string path, SHIP s)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(s.getsNumber() + "," + s.getsLatitude().getsDegree() + "," + s.getsLatitude().getsMinutes() + "," + s.getsLatitude().getsDirection() + "," + s.getsLongtitude().getsDegree() + "," + s.getsLongtitude().getsMinutes() + "," + s.getsLongtitude().getsDirection());
            file.Flush();
            file.Close();
        }
    }
}
