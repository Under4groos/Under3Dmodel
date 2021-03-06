﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lib3Dmodel
{
    public class Draw
    {
        List<Vector> ListVectors = new List<Vector>();

        public void AddVector(Vector position) => ListVectors.Add(position);

        public void AddVectors(Vector[] Vectors)
        {
            foreach (var Vector in Vectors)
            {
                ListVectors.Add(Vector);
            }           
        }


        public Control DrawPanel
        {
            get;set;
        }
        public Point Position
        {
            get;set;
        }
        public Angle Ang
        {
            get;set;
        }
        public void Draw3D( lib3Dmodel.Color[] C)
        {
            if (DrawPanel == null)
                return;
            Point P;
            Point P2;
            
            Graphics G = DrawPanel.CreateGraphics();
            G.Clear(System.Drawing.Color.FromArgb(255,255,255));

            for (int i = 0; i < ListVectors.Count; i++)
            {
                P = new Vector().ToScreen(ListVectors[i], new Point(DrawPanel.Width/2  , DrawPanel.Height/2), Ang);

                // G.DrawLine(Pens.Black, P, P2);
                lib3Dmodel.Color Col = C[i];
                G.DrawRectangle(new Pen(System.Drawing.Color.FromArgb(Col.r , Col.g , Col.b )), P.X, P.Y, 1, 5);
            }
            

        }
        
    }
}
