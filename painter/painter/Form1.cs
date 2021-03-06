﻿using System;
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
using Savefile;
using Action = ProductInterfaces.Action;


namespace painter
{
  public partial class Form1 : Form
  {
    List<DrawAction> actions = new List<DrawAction>();
    private SolidBrush m_color;
    private Color m_paintcolor = Color.Black;
    private bool m_choose = false;
    private bool m_paint = false;
    private int m_x, m_y,m_x1, m_y1 = 0;
    private Item m_currItem;
    private readonly IWCFPaint m_proxy;
    private Action m_action;


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
      actions.Clear();
      
    }

    private void panel1_MouseUp(object sender, MouseEventArgs e)
    {
      m_action = Action.Up;

      actions.Add(new DrawAction(m_action, e.X, e.Y, m_currItem, m_paintcolor));


      m_paint = false;
      m_x1 = e.X;
      m_y1 = e.Y;
      switch (m_currItem)
      {
        case Item.Ellipse:
        {
          Pen myPen = new Pen(m_paintcolor);
          using (Graphics g = panel1.CreateGraphics())
          {
            g.DrawEllipse(myPen, m_x, m_y, m_x1 - m_x, m_y1 - m_y);
          }
          break;
        }
        case Item.Rectangle:
        {
          var myPen = new Pen(m_paintcolor);
          using (Graphics g = panel1.CreateGraphics())
          {
            g.DrawRectangle(myPen, Math.Min(m_x, m_x1), Math.Min(m_y, m_y1), Math.Abs(m_x1 - m_x), Math.Abs(m_y1 - m_y));
          }
          break;
        }
        case Item.Line:
        {
          Pen myPen = new Pen(m_paintcolor);
          using (Graphics g = panel1.CreateGraphics())
          {
            g.DrawLine(myPen, m_x, m_y, m_x1, m_y1);
          }
          break;
        }
      }
    }



    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      m_action = Action.Down;
      actions.Add(new DrawAction(m_action, e.X, e.Y, m_currItem, m_paintcolor));
      m_paint = true;
      m_x = e.X;
      m_y = e.Y;
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      m_action = Action.Move;


      if (m_paint)
      {
        switch (m_currItem)
        {
          case Item.Brush:
          {
            actions.Add(new DrawAction(m_action, e.X, e.Y, m_currItem, m_paintcolor));
            m_color = new SolidBrush(m_paintcolor);
            using (Graphics g = panel1.CreateGraphics())
            {
              g.FillEllipse(m_color, e.X, e.Y, 20, 20);
            }
            break;
          }
          case Item.Pencil:
          {
            actions.Add(new DrawAction(m_action, e.X, e.Y, m_currItem, m_paintcolor));
            m_color = new SolidBrush(m_paintcolor);
            using (Graphics g = panel1.CreateGraphics())
            {
              g.FillEllipse(m_color, e.X, e.Y, 5, 5);
            }
            break;
          }
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

      var savingbox = new SaveGraphicsForm();
      var dialogResult = savingbox.ShowDialog(this);
      if (dialogResult == DialogResult.OK)
      {
        string imageName = savingbox.ImageName;
        m_proxy.Save(actions,imageName);
      }

 

      //  m_proxy.Save(this);

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

    private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
      
    }

    private void Open_Click(object sender, EventArgs e)
    {
      var openingbox = new Open();
      openingbox.ShowDialog(this);
      var openfile = openingbox.openfile;
      m_proxy.Open(openfile);
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      if (m_choose)
      {
        Bitmap bmp = (Bitmap)pictureBox1.Image.Clone();
        m_paintcolor = bmp.GetPixel(e.X, e.Y);
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
