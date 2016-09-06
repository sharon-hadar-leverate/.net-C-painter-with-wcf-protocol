using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;



namespace painter
{
  public partial class Form1 : Form
  {
    SolidBrush color;
    Color paintcolor = Color.Black;
    bool choose = false;
    bool paint = false;
    int x, y, x2,y2,x1, y1 = 0;
    Item currItem;


    public enum Item
    {
      Rectangle, Ellipse, Line, Brush, Pencil, Colorpicker
    }

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
      x1 = e.X;
      y1 = e.Y;
      switch (currItem) 
      { 
        case Item.Ellipse:
          {
          Pen myPen = new Pen(paintcolor);
          Graphics g = panel1.CreateGraphics();
          g.DrawEllipse(myPen, x, y, x1-x, y1-y);
          break;
        }
        case Item.Rectangle:
          {
          var myPen = new Pen(paintcolor);
          Graphics g = panel1.CreateGraphics();
          g.DrawRectangle(myPen, Math.Min(x, x1),Math.Min( y, y1), Math.Abs(x1 - x), Math.Abs(y1 - y));
          break;
        }
        case Item.Line:
          {
          Pen myPen = new Pen(paintcolor);
          Graphics g = panel1.CreateGraphics();
          g.DrawLine(myPen, x, y, x1, y1);
          break;
        } }
    }
  


    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      paint = true;
      x = e.X;
      y = e.Y;
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (paint)
      {
        switch (currItem)
        {
          case Item.Brush:
            {
              color = new SolidBrush(paintcolor);
              Graphics g = panel1.CreateGraphics();
              g.FillEllipse(color, e.X, e.Y, 20, 20);
              g.Dispose();
              break;
            }
          case Item.Pencil:
            {

              color = new SolidBrush(paintcolor);
              using (Graphics g = panel1.CreateGraphics())
              {
                g.FillEllipse(color, e.X, e.Y, 5, 5);
              }
              break;
            }
            //  case Item.Ellipse:
            //    {
            //      Pen myPen = new Pen(paintcolor);
            //      Graphics g = panel1.CreateGraphics();
            //      g.DrawEllipse(myPen, x, y, 10, 10);
            //      break;
            //    }
            //  case Item.Rectangle:
            //    {
            //      Pen myPen = new Pen(paintcolor);
            //      Graphics g = panel1.CreateGraphics();
            //      g.DrawRectangle(myPen, x, y, 10, 10);
            //      break;
            //    }
            //  case Item.Line:
            //    {
            //      Pen myPen = new Pen(paintcolor);
            //      Graphics g = panel1.CreateGraphics();
            //      g.DrawLine(myPen, x, y, x1, y1);
            //      break;
            //    }
            //}

            /// color = new SolidBrush(paintcolor);
            /// Graphics g = panel1.CreateGraphics();
            /// g.FillEllipse(color, e.X, e.Y, 20, 20);
            /// g.Dispose();
            /// // color = new SolidBrush(Color.Black);
            // Graphics g = panel1.CreateGraphics();
            // g.FillEllipse(color, e.X, e.Y, 20, 20);
            // g.Dispose();



        }
      }
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
      choose = false;
    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
      paintcolor = bmp.GetPixel(e.X, e.Y);
      //  red.Value = paintcolor.R;
      //  green.Value = paintcolor.G;
      //  blue.Value = paintcolor.B;
      //  alphaval.Value = paintcolor.A;
      //  redval.Text = paintcolor.R.ToString();
      //  greenval.Text = paintcolor.G.ToString();
      //  blueval.Text = paintcolor.B.ToString();
      //  alphaval.Text = paintcolor.A.ToString();
      pictureBox3.BackColor = paintcolor;
      choose = true;
    }

    private void ellipseClick_MouseClick(object sender, MouseEventArgs e)
    {
      currItem = Item.Ellipse;
    }

    private void BrushClick_MouseClick(object sender, MouseEventArgs e)
    {
      currItem = Item.Brush;
    }

    private void recClick_MouseClick(object sender, MouseEventArgs e)
    {
      currItem = Item.Rectangle;
    }

    private void lineClick_MouseClick(object sender, MouseEventArgs e)
    {
      currItem = Item.Line;
    }

    private void penClick_MouseClick(object sender, MouseEventArgs e)
    {
      currItem = Item.Pencil;
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      if (choose)
      {
        Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
        paintcolor = bmp.GetPixel(e.X, e.Y);
        //   red.Value = paintcolor.R;
        //   red.Value = paintcolor.G;
        //   red.Value = paintcolor.B;
        //   red.Value = paintcolor.A;
        //   redval.Text = paintcolor.R.ToString();
        //   greenval.Text = paintcolor.G.ToString();
        //   blueval.Text = paintcolor.B.ToString();
        //   alphaval.Text = paintcolor.A.ToString();
        pictureBox2.BackColor = paintcolor;

      }
    }

    private void PickonClick_Click(object sender, EventArgs e)
    {
      if (m_colorDialog.ShowDialog() == DialogResult.OK)
      {
        pictureBox3.BackColor = m_colorDialog.Color;
        pictureBox2.BackColor = m_colorDialog.Color;
        paintcolor = m_colorDialog.Color;
      }
    }

    private void pictureBox1_MouseHover(object sender, EventArgs e)
    {

    }
  }
}
