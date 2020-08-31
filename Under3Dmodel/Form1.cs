
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using lib3Dmodel;
namespace Under3Dmodel
{
    public partial class Form1 : Form
    {

        public Form1(){InitializeComponent();}

        Angle NewAng = new Angle();

        private void main(object sender, System.EventArgs e)
        {
           



            // label1.Text = NewAng.AngleToRadians(100).ToString();




        }

        private void trackBar1_Scroll(object sender, System.EventArgs e)
        {
            Draw();
        }

        public  void Draw()
        {
            label1.Text = "Угол:" + trackBar2.Value.ToString();
            label2.Text = "Радиус:" + trackBar1.Value.ToString();
            List<Point> P = new List<Point>();
            Graphics G = this.CreateGraphics();
            G.Clear(Color.FromArgb(255, 255, 255));

            G.DrawEllipse(
                    Pens.Black,
                    (float)(this.Width / 2 ),
                    (float)(this.Height / 2 ),
                    5,
                    5
                );

            for (int i = 0; i < trackBar2.Value + 1; i++)
            {
                
                P.Add( 
                    new Point(
                       (int) (this.Width / 2 + Math.Sin(NewAng.AngleToRadians(i)) * trackBar1.Value),
                       (int) (this.Height / 2 + Math.Cos(NewAng.AngleToRadians(i)) * trackBar1.Value)
                    )
                );
            }
            if (P.Count < 2)
                return;
            G.DrawLines(Pens.Red, P.ToArray());
            
          
           

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Draw();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
