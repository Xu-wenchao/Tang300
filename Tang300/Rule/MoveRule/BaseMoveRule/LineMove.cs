using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang300.Rule
{
    class LineMove : BaseMoveRule
    {
        private Random r;
        private static List<Point> initPoints = new List<Point>() { 
            {new Point(0, 0)},
            {new Point(GlobalVariable.SCREEN_WIDTH, 0)},
            {new Point(0, GlobalVariable.SCREEN_HEIGHT)},
            {new Point(GlobalVariable.SCREEN_WIDTH, GlobalVariable.SCREEN_HEIGHT)}
        };
        private static int[] xRedirects = { 1, -1, 1, -1 };
        private static int[] yRedirects = { 1, 1, -1, -1 };
        public LineMove()
        {
            init();
        }
        public override void init()
        {
            r = new Random();
            int randomMet = r.Next(0, 4);
            currentX = initX = initPoints[randomMet].X;
            currentY = initY = initPoints[randomMet].Y;
            if (randomMet % 2 != 0)
            {
                speedX = xRedirects[randomMet] * r.Next(9, 11);
                speedY = yRedirects[randomMet] * r.Next(5, 7);
            }
            else
            {
                speedX = xRedirects[randomMet] * r.Next(5, 11);
                speedY = yRedirects[randomMet] * r.Next(5, 11);
            }
        }
        public LineMove(int paintRangeX, int paintRangeY, int initX, int initY, int speedX, int speedY)
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
            return new Point(currentX += speedX, currentY += speedY);
        }
    }
}
