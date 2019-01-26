using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang300.Rule
{
    class HalfCycleMove : BaseMoveRule
    {
        public HalfCycleMove()
        {
            init();
        }
        public override void init()
        {
            initX = paintRangeX / 2;
            initY = paintRangeY / 2;
            currentX = currentY = 0;
        }

        public override Point getCPoint()
        {
            currentX += speedX;
            try
            {
                currentY = (int)(Math.Sqrt(Math.Pow(paintRangeX / 2, 2) - Math.Pow(currentX - initX, 2)));
            }
            catch
            {
            }
            return new Point(currentX, currentY);
        }
    }
}
