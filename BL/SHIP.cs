using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation.BL
{
    class SHIP
    {
        private string sNumber;
        private ANGLE sLatitude;
        private ANGLE sLongitude;
        public SHIP(string sNumber, ANGLE sLatitude, ANGLE sLongitude)
        {
            this.sNumber = sNumber;
            this.sLatitude = sLatitude;
            this.sLongitude = sLongitude;
        }
        public string getsNumber()
        {
            return this.sNumber;
        }
        public ANGLE getsLatitude()
        {
            return this.sLatitude;
        }
        public ANGLE getsLongtitude()
        {
            return this.sLongitude;
        }
        public void setsNumber(string sNumber)
        {
            this.sNumber = sNumber;
        }
        public void setsLatitude(ANGLE sLatitude)
        {
            this.sLatitude = sLatitude;
        }
        public void setsLongitude(ANGLE sLongitude)
        {
            this.sLongitude = sLongitude;
        }
        public bool isShipExist(string sNumber)
        {
            if (this.sNumber == sNumber)
            {
                return true;
            }
            return false;
        }
        public bool coordinateChecker(ANGLE sLatitude, ANGLE sLongitude)
        {
            if (this.sLatitude.getsDegree() == sLatitude.getsDegree())
            {
                if (this.sLatitude.getsMinutes() == sLatitude.getsMinutes())
                {
                    if (this.sLatitude.getsDirection() == sLatitude.getsDirection())
                    {
                        if (this.sLongitude.getsDegree() == sLongitude.getsDegree())
                        {
                            if (this.sLongitude.getsMinutes() == sLongitude.getsMinutes())
                            {
                                if (this.sLongitude.getsDirection() == sLongitude.getsDirection())
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
