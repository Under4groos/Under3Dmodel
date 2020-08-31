using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace lib3Dmodel
{
    public class Draw3D
    {
        private static List<Point> ModelPoints = new List<Point>();
        public  void add( Point P )
        {
            ModelPoints.Add(P);
        }
        public int GetCount
        {
            get
            {
                return ModelPoints.Count();
            }
        }





    }
}
