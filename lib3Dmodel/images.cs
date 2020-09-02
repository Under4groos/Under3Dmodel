using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib3Dmodel.lib;
namespace lib3Dmodel
{
    public class images
    {
        public Color[] ImagesListColors(string file)
        {
            List<Color> ColorArray = new List<Color>();
            if (libFile.isValid(file))
            {
                Bitmap NewBitmap = new Bitmap(file);
                for (int x = 0; x < NewBitmap.Width; x++)
                {
                    for (int y = 0; y < NewBitmap.Height; y++)
                    {

                        System.Drawing.Color PixColor = NewBitmap.GetPixel(x, y);

                        ColorArray.Add(
                            new Color(PixColor.R, PixColor.G, PixColor.B)
                            );
                    }
                }
            }
            return ColorArray.ToArray();           
        }
    }
}
