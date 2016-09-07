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
using System.ServiceModel;
using ProductInterfaces;


namespace painter
{
  public partial class Form1 : Form
  {
    private SolidBrush m_color;
    private Color m_paintcolor = Color.Black;
    private bool m_choose = false;
    private bool m_paint = false;
    private int m_x, m_y,m_x1, m_y1 = 0;
    private Item m_currItem;
    private readonly IWCFPaint m_proxy;


    public enum Item
    {
      Rectangle, Ellipse, Line, Brush, Pencil, Colorpicker
    }

    public Form1()
    {
      InitializeComponent();
      ChannelFactory<IWCFPaint> channelFactory = new ChannelFactory<IWCFPaint>("PainterEndpoint");
      m_proxy = channelFactory.CreateChannel();
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
      m_paint = false;
      m_x1 = e.X;
      m_y1 = e.Y;
      switch (m_currItem) 
      { 
        case Item.Ellipse:
          {
          Pen myPen = new Pen(m_paintcolor);
          Graphics g = panel1.CreateGraphics();
          g.DrawEllipse(myPen, m_x, m_y, m_x1-m_x, m_y1-m_y);
          break;
        }
        case Item.Rectangle:
          {
          var myPen = new Pen(m_paintcolor);
          Graphics g = panel1.CreateGraphics();
          g.DrawRectangle(myPen, Math.Min(m_x, m_x1),Math.Min( m_y, m_y1), Math.Abs(m_x1 - m_x), Math.Abs(m_y1 - m_y));
          break;
        }
        case Item.Line:
          {
          Pen myPen = new Pen(m_paintcolor);
          Graphics g = panel1.CreateGraphics();
          g.DrawLine(myPen, m_x, m_y, m_x1, m_y1);
          break;
        } }
    }
  


    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      m_paint = true;
      m_x = e.X;
      m_y = e.Y;
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (m_paint)
      {
        switch (m_currItem)
        {
          case Item.Brush:
            {
              m_color = new SolidBrush(m_paintcolor);
              Graphics g = panel1.CreateGraphics();
              g.FillEllipse(m_color, e.X, e.Y, 20, 20);
              g.Dispose();
              break;
            }
          case Item.Pencil:
            {

              m_color = new SolidBrush(m_paintcolor);
              using (Graphics g = panel1.CreateGraphics())
              {
                g.FillEllipse(m_color, e.X, e.Y, 5, 5);
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

            /// m_color = new SolidBrush(paintcolor);
            /// Graphics g = panel1.CreateGraphics();
            /// g.FillEllipse(m_color, e.X, e.Y, 20, 20);
            /// g.Dispose();
            /// // m_color = new SolidBrush(Color.Black);
            // Graphics g = panel1.CreateGraphics();
            // g.FillEllipse(m_color, e.X, e.Y, 20, 20);
            // g.Dispose();



        }
      }
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
      m_choose = false;
    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
      m_paintcolor = bmp.GetPixel(e.X, e.Y);
      //  red.Value = paintcolor.R;
      //  green.Value = paintcolor.G;
      //  blue.Value = paintcolor.B;
      //  alphaval.Value = paintcolor.A;
      //  redval.Text = paintcolor.R.ToString();
      //  greenval.Text = paintcolor.G.ToString();
      //  blueval.Text = paintcolor.B.ToString();
      //  alphaval.Text = paintcolor.A.ToString();
      pictureBox3.BackColor = m_paintcolor;
      m_choose = true;
    }

    private void ellipseClick_MouseClick(object sender, MouseEventArgs e)
    {
      m_currItem = Item.Ellipse;
    }

    private void BrushClick_MouseClick(object sender, MouseEventArgs e)
    {
      m_currItem = Item.Brush;
    }

    private void recClick_MouseClick(object sender, MouseEventArgs e)
    {
      m_currItem = Item.Rectangle;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      //ChannelFactory<IWCFPaint> channelFactory = new
      //  ChannelFactory<IWCFPaint>("PainterEndpoint");
      //IWCFPaint proxy = channelFactory.CreateChannel();
      m_proxy.DoWork();
      
      m_proxy.Save(this);

      //List<int> l = new List<int> {1, 2, 3, 4, 5};
      //var l2 = l.Where(i => i > 3).Select(i => i * 2).ToList();

      //var l3 = new List<int>();
      //for (int i = 0; i < l.Count; i++)
      //{
      //  if (l[i] > 3)
      //  {
      //    l3.Add(l[i]*2);
      //  }
      //}

    }

    private void lineClick_MouseClick(object sender, MouseEventArgs e)
    {
      m_currItem = Item.Line;
    }

    private void penClick_MouseClick(object sender, MouseEventArgs e)
    {
      m_currItem = Item.Pencil;
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      if (m_choose)
      {
        Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
        m_paintcolor = bmp.GetPixel(e.X, e.Y);
        //   red.Value = paintcolor.R;
        //   red.Value = paintcolor.G;
        //   red.Value = paintcolor.B;
        //   red.Value = paintcolor.A;
        //   redval.Text = paintcolor.R.ToString();
        //   greenval.Text = paintcolor.G.ToString();
        //   blueval.Text = paintcolor.B.ToString();
        //   alphaval.Text = paintcolor.A.ToString();
        pictureBox2.BackColor = m_paintcolor;

      }
    }

    private void PickonClick_Click(object sender, EventArgs e)
    {
      if (m_colorDialog.ShowDialog() == DialogResult.OK)
      {
        pictureBox3.BackColor = m_colorDialog.Color;
        pictureBox2.BackColor = m_colorDialog.Color;
        m_paintcolor = m_colorDialog.Color;
      }
    }

    private void pictureBox1_MouseHover(object sender, EventArgs e)
    {

    }
  }
}
