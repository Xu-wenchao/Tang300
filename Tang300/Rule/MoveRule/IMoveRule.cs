using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang300.Rule
{
    interface IMoveRule
    {
        Status getStatus();
        Point getCPoint();
        void init();
    }

    enum Status
    {
        INIT,
        EFFECT,
        FINISH
    }
}
