
using System;

namespace lib3Dmodel
{
    public class Angle
    {
        public double pitch
        {
            set; get;
        }
        public double yaw
        {
            set; get;
        }
        public double roll
        {
            set; get;
        }

        public Angle(double p, double y, double r)
        {
            pitch = p;
            yaw = y;
            roll = r;
        }
        public Angle()
        {
            pitch = 0.0;
            yaw = 0.0;
            roll = 0.0;
        }
        /// <summary>
        /// "Pitch: " + this.pitch.ToString() + "Yaw: " + this.yaw.ToString() + "Roll: " + this.roll.ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
            => "Pitch: " + this.pitch.ToString() + "Yaw: " + this.yaw.ToString() + "Roll: " + this.roll.ToString();

        public double AngleToRadians(int Ang)
        {
            double rad = (Ang * Math.PI) / 180;
            return rad;
        }
        public double RadiansToAngle(double rad)
        {
            double Ang = rad * 90 / (2 * Math.PI);
            return Ang;
        }

    }
}
