using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductInterfaces;

namespace painter
{
  public partial class Open : Form
  {
          
    private readonly IWCFPaint m_proxy;


    public Open()
    {
      InitializeComponent();
      ChannelFactory<IWCFPaint> channelFactory = new ChannelFactory<IWCFPaint>("PainterEndpoint");
      m_proxy = channelFactory.CreateChannel();
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

      IEnumerable<string> dt = m_proxy.Getfiles();
      foreach (var V in dt)
      {
        listView1.Items.Add(V);
      }




    }

  }
}
