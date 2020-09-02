using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib3Dmodel
{
    public class Color
    {
        public int r
        {
            get;set;
        }
        public int g
        {
            get; set;
        }
        public int b
        {
            get; set;
        }

        public Color(int R, int G, int B)
        {
            r = R; g = G; b = B;
        }
        public Color()
        {
            r = 0;
            g = 0;
            b = 0;
        }

    }
}
