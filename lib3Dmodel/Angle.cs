
using System;

namespace lib3Dmodel
{
    public class Angle
    {
        public float pitch
        {
            set; get;
        }
        public float yaw
        {
            set; get;
        }
        public float roll
        {
            set; get;
        }
        public override string ToString()
        {
            return "Pitch: " + this.pitch.ToString() + "Yaw: " + this.yaw.ToString() + "Roll: " + this.roll.ToString();
        }
        public float AngleToRadians(int Ang)
        {
            double rad = (Ang * Math.PI) / 180;
            return (float)rad;
        }
        public float RadiansToAngle(float rad)
        {
            double Ang = rad * 90 / (2 * Math.PI);
            return (float)Ang;
        }

    }
}
