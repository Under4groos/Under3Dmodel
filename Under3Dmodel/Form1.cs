
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using lib3Dmodel;
namespace Under3Dmodel
{
    public partial class Form1 : Form
    {
        Draw draw = new Draw();
        lib3Dmodel.Color[] C;
        public Form1(){InitializeComponent();}

        private void main(object sender, System.EventArgs e)
        {

            images img = new images();

             C = img.ImagesListColors(@"C:\Users\UnderKo\Downloads\unnamed.jpg");
            for (int x = 0; x < img.X; x++)
            {
                for (int y = 0; y < img.Y; y++)
                {

                    draw.AddVector( new Vector(0.0, (double)x , (double)y ) );
                }
            }

            
          



            double A = new Angle().AngleToRadians(trackBar1.Value);
            double B = new Angle().AngleToRadians(trackBar2.Value);

            draw.Ang = new Angle(A, B, 0);
            draw.DrawPanel = this;
            draw.Draw3D(C);
        }

       
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double A = new Angle().AngleToRadians(trackBar1.Value);
            double B = new Angle().AngleToRadians(trackBar2.Value);
            draw.Ang = new Angle(A, B, 0);
            draw.Draw3D(C);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            double A = new Angle().AngleToRadians(trackBar1.Value);
            double B = new Angle().AngleToRadians(trackBar2.Value);


            draw.Ang = new Angle(A, B, 0);
            draw.Draw3D(C);

        }
    }
}
