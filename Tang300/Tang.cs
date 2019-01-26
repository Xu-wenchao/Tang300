using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tang300.Rule;
using Tang300.Utils;

namespace Tang300
{
    class Tang
    {
        public static void loadFile(string path){
            FileUtils.readFileTo(path, GlobalVariable.tangList);
        }
        private string content;
        public IMoveRule lm
        {
            get;
            set;
        }
        public IColorRule mc
        {
            get;
            set;
        }

        public int emSize = GlobalVariable.EMSIZE;

        public Tang(IMoveRule lm, IColorRule mc, string content)
        {
            this.lm = lm;
            this.mc = mc;
            this.content = content;
        }

        public void paint(Graphics g){
            g.DrawString(content, new Font("行书", emSize), new SolidBrush(mc.getColor()), lm.getCPoint());
        }
    }
}
