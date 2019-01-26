using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang300.Rule
{
    abstract class BaseMoveRule : IMoveRule
    {
        protected int paintRangeX;
        protected int paintRangeY;
        protected int initX;
        protected int initY;
        protected int speedX;
        protected int speedY;
        protected int currentX;
        protected int currentY;

        public BaseMoveRule()
        {
            paintRangeX = GlobalVariable.SCREEN_WIDTH;
            paintRangeY = GlobalVariable.SCREEN_HEIGHT;
            currentX = initX = GlobalVariable.INIT_X;
            currentY = initY = GlobalVariable.INIT_Y;
            speedX = GlobalVariable.SPEED_X;
            speedY = GlobalVariable.SPEED_Y;
        }
        public abstract Point getCPoint();
        public abstract void init();

        public virtual Status getStatus()
        {
            return currentX > paintRangeX || currentY > paintRangeY
                || currentX < -paintRangeX / 2 || currentY < -GlobalVariable.EMSIZE ?
                Status.FINISH : Status.EFFECT;
        }
    }
}
