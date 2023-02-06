using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation.BL
{
    class ANGLE
    {
        private int sDegree;
        private float sMinutes;
        private char sDirection;
        public ANGLE(int sDegree, float sMinutes, char sDirection)
        {
            this.sDegree = sDegree;
            this.sMinutes = sMinutes;
            this.sDirection = sDirection;
        }
        public int getsDegree()
        {
            return this.sDegree;
        }
        public float getsMinutes()
        {
            return this.sMinutes;
        }
        public char getsDirection()
        {
            return this.sDirection;
        }
        public void setsDegree(int sDegree)
        {
            this.sDegree = sDegree;
        }
        public bool setsMinutes(float sMinutes)
        {
            if (sMinutes > 0 && sMinutes < 60)
            {
                this.sMinutes = sMinutes;
                return true;
            }
            return false;
        }
        public void setsDirection(char sDirection)
        {
            this.sDirection = sDirection;
        }

    }
}
