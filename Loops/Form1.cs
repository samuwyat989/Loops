using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Loops
{
    public partial class backLoop : Form
    {
        public backLoop()
        {
            InitializeComponent();
        }

        private void begin_Click(object sender, EventArgs e)
        {
            Graphics loopLine = this.CreateGraphics();
            Pen loopPen1 = new Pen(Color.Black, 5);
            Pen loopPen0 = new Pen(Color.White, 5);

            int loopNumberSide = 180;
            int loopNumberUp = 95;
            int x1 = 50;
            int x2 = 50;
            int x3 = 230;
            int x4 = 147;
            int x5 = 52;
            
            for (int x = 0; x < loopNumberSide; x++)
            {
                loopLine.DrawLine(loopPen1, x1, 50, x1, 150);
                Thread.Sleep(1);
                x1++;
            }

            Thread.Sleep(1000);

            for (int x = 0; x < loopNumberSide; x++)
            {
                loopLine.DrawLine(loopPen0, x2, 50, x2, 150);
                Thread.Sleep(1);
                x2++;
            }

            Thread.Sleep(1000);

            for (int x = 0; x < loopNumberSide; x++)
            {
                loopLine.DrawLine(loopPen1, x1, 50, x1, 150);
                Thread.Sleep(1);
                x1--;
            }

            Thread.Sleep(1000);

            for (int x = 0; x < loopNumberSide; x++)
            {
                loopLine.DrawLine(loopPen0, x2, 50, x2, 150);
                Thread.Sleep(1);
                x2--;
            }

            Thread.Sleep(1000);

            for (int x = 0; x < loopNumberSide; x++)
            {
                loopLine.DrawLine(loopPen1, x1, 50, x1, 55);
                Thread.Sleep(1);
                x1++;
            }

            Thread.Sleep(1);

            for (int x = 0; x < loopNumberUp; x++)
            {
                loopLine.DrawLine(loopPen1, 228, x5, 233, x5);
                Thread.Sleep(1);
                x5++;
            }

            Thread.Sleep(1);

            for (int x = 0; x < loopNumberSide; x++)
            {
                loopLine.DrawLine(loopPen1, x3, 145, x3, 150);
                Thread.Sleep(1);
                x3--;
            }
            
            Thread.Sleep(1);

            for (int x = 0; x < loopNumberUp; x++)
            {
                loopLine.DrawLine(loopPen1, 48, x4, 53, x4);
                Thread.Sleep(1);
                x4--;
            }
                        
        }
    }
}

