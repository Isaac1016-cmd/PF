using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PF
{
    public static class ThemeColor
    {
       public static List<string> ColorList = new List<string>
       {"#8E443C","#3F777A","#7867A0","#9E8574","#487E7F","#BD723B " };


        public static Color CambioBrillo(Color color, double correccion)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correccion < 0)
            {
                correccion = 1 + correccion;
                red *= correccion;
                green *= correccion;
                blue *= correccion;
            }
            else
            {
                red = (255 - red) * correccion + red;
                green = (255 - green) * correccion + green;
                blue = (255 - blue) * correccion + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
