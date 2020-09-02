
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
        
        public Form1(){InitializeComponent();}

        private void main(object sender, System.EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                draw.AddVector(new Vector( Math.Sin(i) * 2, Math.Cos(i) * 2, Math.Tan(i) * 2));
            }
            
            

            double A = new Angle().AngleToRadians(trackBar1.Value);
            double B = new Angle().AngleToRadians(trackBar2.Value);

            draw.Ang = new Angle(A, B, 0);
            draw.DrawPanel = this;
            draw.Draw3D();
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
            draw.Draw3D();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            double A = new Angle().AngleToRadians(trackBar1.Value);
            double B = new Angle().AngleToRadians(trackBar2.Value);


            draw.Ang = new Angle(A, B, 0);
            draw.Draw3D();

        }
    }
}
