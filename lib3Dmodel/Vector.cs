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
        public double X
        {
            set; get;
        }
        public double Y
        {
            set; get;
        }
        public double Z
        {
            set; get;
        }

        public Vector()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
  
        public Vector(double x, double y, double z)
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
            => Math.Sqrt(Math.Pow((v.X - v2.X), 2) + Math.Pow((v.Y - v2.Y), 2) + Math.Pow((v.Z - v2.Z), 2));

        
        public int Size
        {
            get;set;        
        }

        public  Point ToScreen( Vector Position3D, Point Position2D , Angle angle )
        {
            double PosX = (double)Position3D.X * 100;
            double PosY = (double)Position3D.Y * 100;
            double PosZ = (double)Position3D.Z * 100;

         
          

            double res_x = -PosZ * Math.Sin(angle.pitch) + PosX * Math.Cos(angle.pitch) + Position2D.X;


            double res_y = -(PosZ * Math.Cos(angle.pitch) + PosX * Math.Sin(angle.pitch)) * Math.Sin(angle.yaw) + PosY * Math.Cos(angle.yaw) + Position2D.Y;
            return new Point((int)(res_x) , (int)(res_y) ) ;
        }

       

    }
}
