using System;
using System.Drawing; //need for Color

namespace MoodColorDemo
{
    class MoodColor
    {
        AColor red, green, blue;
        public MoodColor(int rStart, int rInc, int gStart, int gInc, int bStart, int bInc)
        {
            red = new AColor(rStart, rInc);
            green = new AColor(gStart, gInc);
            blue = new AColor(bStart, bInc);
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
            int value, increment;
            public AColor(int value, int increment)
            {
                this.value = value;this.increment = increment;
            }
            public int Value
            {
                get
                {
                    if (value + increment > 255 || value + increment < 0)
                        increment *= -1;
                    value += increment;
                    return value;
                }
            }
        }
    }
}
