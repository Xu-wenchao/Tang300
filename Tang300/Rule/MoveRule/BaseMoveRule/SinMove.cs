using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang300.Rule
{
    class SinMove : BaseMoveRule
    {
        public SinMove()
        {
            init();
        }
        public override void init()
        {
            speedX = 5;
            currentX = initX = 0;
            currentY = initY = GlobalVariable.SCREEN_HEIGHT / 2;
        }
        public SinMove(int paintRangeX, int paintRangeY, int initX, int initY, int speedX, int speedY)
        {
            this.paintRangeX = paintRangeX;
            this.paintRangeY = paintRangeY;
            this.currentX = this.initX = initX;
            this.currentY = this.initY = initY;
            this.speedX = speedX;
            this.speedY = speedY;
        }
        public override Point getCPoint()
        {
            currentX += speedX;
            currentY = initY + (int)(Math.Sin(currentX) * 100);
            return new Point((currentX += speedX), currentY += speedY);
        }
    }
}
