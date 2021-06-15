using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace MoodColorDemo
{
    class MoodColor
    {
        AColor red, green, blue;

        public MoodColor(int rStart, int rInc, int gStart, int gInc, int bStart, int bInc)
        {
            red = new AColor(rStart, rInc);
            blue = new AColor(gStart, gInc);
            green = new AColor(bStart, bInc);
        }

        public Color Color
        {
            get
            {
                return Color.FromArgb(red.Value, green.Value, blue.Value);
            }
        }



        class AColor
        {
            int value, increament;
            public AColor(int value, int increament)
            {
                this.value = value;
                this.increament = increament;
            }
            public int Value
            {
                get
                {
                    if (value + increament > 255 || value + increament < 0)
                        increament *= -1;
                    value += increament;
                    return value;
                }
            }
        }
    }


}
