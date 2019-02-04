using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KheperaIV
{
    class Azimuth
    {
        private double angle;
        private uint length;

        public Azimuth(uint length, double angle)
        {
            this.angle = angle;
            this.length = length;
        }

        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        public uint Length
        {
            get { return length; }
            set { length = value; }
        }
    }
}
