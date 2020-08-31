using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib3Dmodel
{
    public class Vector
    {
        public float X
        {
            set; get;
        }
        public float Y
        {
            set; get;
        }
        public float Z
        {
            set; get;
        }

        public Vector()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
  
        public Vector(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return this.X.ToString() + " " + this.Y.ToString() + " " + this.Z.ToString();
        }
        public double Distance(Vector v, Vector v2)
        {
            return Math.Sqrt(Math.Pow((v.X - v2.X), 2) +Math.Pow((v.Y - v2.Y), 2)+Math.Pow((v.Z - v2.Z), 2));
        }

        public int Size
        {
            get; set;
        }

        public Point point3D(Vector Position3D, Point Position2D , Angle angle )
        {
            int PosX = (int)Position3D.X * Size;
            int PosY = (int)Position3D.Y * Size;
            int PosZ = (int)Position3D.Z * Size;

            double res_x = -PosZ * System.Math.Sin(angle.pitch) + PosX * System.Math.Cos(angle.pitch) + Position2D.X;
            double res_y = -(PosZ * System.Math.Cos(angle.pitch) + PosX * System.Math.Sin(angle.pitch)) * System.Math.Sin(angle.yaw) + PosY * System.Math.Cos(angle.pitch) + Position2D.Y;
            return new Point((int)(res_x), (int)(res_y));
        }
    }
}
