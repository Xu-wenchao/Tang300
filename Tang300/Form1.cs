using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tang300.Rule;
using Tang300.Utils;

namespace Tang300
{
    public partial class Form1 : Form
    {
        private int width;
        private int height;
        private Tang tr;
        private Random r;
        private List<IMoveRule> mls = new List<IMoveRule>()
        {
            {new LineMove()}, 
            {new LineMove()}, 
            {new HalfCycleMove()}, 
            {new ReHalfCycleMove()}, 
            {new MyMoveRule01()},
            {new ReMyMoveRule01()}
        };
        private List<IColorRule> cs = new List<IColorRule>(){
            {new SingleColor()},{new SingleColor()},{new SingleColor()},{new SingleColor()}, {new MultipleColor()}
        };
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            new Thread(() =>
            {
                try
                {
                    Tang.loadFile(GlobalVariable.CURRENT_PATH + "/tang.txt");
                }
                catch { }
            }).Start();
            this.TopMost = true;
            width = System.Windows.Forms.Screen.GetBounds(this).Width;
            height = System.Windows.Forms.Screen.GetBounds(this).Height;
            r = new Random();
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            timer1.Interval = 50;
            while (true)
            {
                if (GlobalVariable.tangList.Count > 0)
                {
                    tr = new Tang(mls[r.Next(0, mls.Count)], cs[r.Next(0, cs.Count)],
                            GlobalVariable.tangList[r.Next(0, GlobalVariable.tangList.Count)]);
                    timer1.Start();
                    break;
                }
            }
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            tr.paint(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tr.lm.getStatus() == Status.FINISH)
            {
                IMoveRule v = mls[r.Next(0, mls.Count)];
                v.init();
                IColorRule c = cs[r.Next(0, cs.Count)];
                c.init();
                tr = new Tang(v, c, GlobalVariable.tangList[r.Next(0, GlobalVariable.tangList.Count)]);
            }
            this.Invalidate();
        }
    }
}
