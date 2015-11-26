using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarDrawMethod
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

            Pen pen = new Pen(Color.Black, 1);
            drawStar(pen,0,0,0);
        }
        public void drawStar(Pen pen, float x, float y, float size)
        {
            Graphics g = this.CreateGraphics();
            //create a multiplier to modify all points position and overall star dimensions (considers original star size, 105)
            float sizemult = size / 105;

            g.DrawLine(pen, 101 * sizemult + x, 0 * sizemult + y, 77 * sizemult + x, 74 * sizemult + y);
            g.DrawLine(pen, 77 * sizemult + x, 74 * sizemult + y, 0 * sizemult + x, 74 * sizemult + y);
            g.DrawLine(pen, 0 * sizemult + x, 74 * sizemult + y, 63 * sizemult + x, 119 * sizemult + y);
            g.DrawLine(pen, 63 * sizemult + x, 119 * sizemult + y, 39 * sizemult + x, 192 * sizemult + y);
            g.DrawLine(pen, 39 * sizemult + x, 192 * sizemult + y, 101 * sizemult + x, 148 * sizemult + y);
            g.DrawLine(pen, 101 * sizemult + x, 148 * sizemult + y, 163 * sizemult + x, 193 * sizemult + y);
            g.DrawLine(pen, 163 * sizemult + x, 193 * sizemult + y, 140 * sizemult + x, 121 * sizemult + y);
            g.DrawLine(pen, 140 * sizemult + x, 121 * sizemult + y, 202 * sizemult + x, 74 * sizemult + y);
            g.DrawLine(pen, 202 * sizemult + x, 74 * sizemult + y, 125 * sizemult + x, 74 * sizemult + y);
            g.DrawLine(pen, 125 * sizemult + x, 74 * sizemult + y, 101 * sizemult + x, 0 * sizemult + y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1, y1, size1;
            x1 = Convert.ToInt16(textBox1.Text);
            y1 = Convert.ToInt16(textBox2.Text);
            size1 = Convert.ToInt16(textBox3.Text);

            Pen pen = new Pen(Color.Black, 1);

            drawStar(pen, x1,y1,size1);
        }
    }
}
