using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace painter
{
    public partial class Form1 : Form
    {
        Color paintcolor;
        bool choose = false;
        bool paint = false;
       // int x, y, 1x, 1y = 0;

        
        SolidBrush color;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearClick(object sender, EventArgs e)
        {
            Graphics g1 = panel1.CreateGraphics();
            g1.Clear(panel1.BackColor);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                color = new SolidBrush(Color.Black);
                Graphics g = panel1.CreateGraphics();
                g.FillEllipse(color, e.X, e.Y, 10, 10);
                g.Dispose();



            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
