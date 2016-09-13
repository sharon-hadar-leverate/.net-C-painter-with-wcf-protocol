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

    public string openfile { get; private set; }
    public Open()
    {
      InitializeComponent();
      ChannelFactory<IWCFPaint> channelFactory = new ChannelFactory<IWCFPaint>("PainterEndpoint");
      m_proxy = channelFactory.CreateChannel();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (listView1.Items.Count == 0)
      {
        IEnumerable<string> dt = m_proxy.Getfiles();
        foreach (var V in dt)
        {
          listView1.Items.Add(V);
        }
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
     openfile = listView1.SelectedItems[0].SubItems[0].Text;
      MessageBox.Show(openfile);

      if (openfile!= "")
      {
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }
  }
}
