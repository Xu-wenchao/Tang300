using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang300.Rule
{
    class ReMyMoveRule01 : BaseMoveRule
    {
        public ReMyMoveRule01()
        {
            init();
        }
        public override void init()
        {
            currentX = initX = paintRangeX;
            currentY = initY = paintRangeX / 2 - GlobalVariable.EMSIZE;
            speedX = -speedX;
            speedY = -speedY;
        }

        public override Point getCPoint()
        {
            currentX += speedX;
            if (currentX > GlobalVariable.SCREEN_WIDTH / 3 && currentX < GlobalVariable.SCREEN_WIDTH / 3 * 2)
            {
                currentY += speedY;
            }
            return new Point(currentX, currentY);
        }
    }
}
