using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.ComIntegration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductInterfaces;

namespace Savefile
{
  public partial class SaveGraphics : Form
  {
    private IWCFPaint m_proxy;

    public SaveGraphics()
    {
      InitializeComponent();
      ChannelFactory<IWCFPaint> channelFactory = new ChannelFactory<IWCFPaint>("PainterEndpoint");
      m_proxy = channelFactory.CreateChannel();
    }


    private void button1_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text != "")
      {
        MessageBox.Show("'"+this.textBox1.Text+"'" + " was saved");
        m_proxy.DoWork();
        this.Close();
      }
      else
      {
        MessageBox.Show("invailed name");
      }
    }
  }
}
