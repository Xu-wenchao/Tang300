using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang300
{
    class GlobalVariable
    {
        public static int SCREEN_WIDTH = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        public static int SCREEN_HEIGHT = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        public static string CURRENT_PATH = Environment.CurrentDirectory;
        public static int SPEED_X = 10;
        public static int SPEED_Y = 10;
        public static int INIT_X = 0;
        public static int INIT_Y = 0;
        public static int EMSIZE = 35;

        public static List<string> tangList = new List<string>();
    }
}
