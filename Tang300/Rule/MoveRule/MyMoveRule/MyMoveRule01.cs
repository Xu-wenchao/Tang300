using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang300.Rule
{
    class MyMoveRule01 : BaseMoveRule
    {
        public MyMoveRule01()
        {
            init();
        }
        public override void init()
        {
            currentX = initX = 0;
            currentY = initY = GlobalVariable.SCREEN_HEIGHT / 2 - GlobalVariable.EMSIZE;
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
