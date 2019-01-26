using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang300.Rule
{
    public class SingleColor : IColorRule
    {
        public Color color;
        public SingleColor()
        {
            init();
        }
        public SingleColor(Color color)
        {
            this.color = color;
        }
        public void init()
        {
            Random ro = new Random(10);
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            int R = ran.Next(255);
            int G = ran.Next(255);
            int B = ran.Next(255);
            B = (R + G > 400) ? R + G - 400 : B;//0 : 380 - R - G;
            B = (B > 255) ? 255 : B;
            color = Color.FromArgb(R, G, B);
        }
        public Color getColor()
        {
            return color;
        }
    }
}
