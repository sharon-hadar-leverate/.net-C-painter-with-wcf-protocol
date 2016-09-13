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
  public partial class SaveGraphicsForm : Form
  {
    public SaveGraphicsForm()
    {
      InitializeComponent();
    }

    public string ImageName { get; private set; }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text != "")
      {
        ImageName = textBox1.Text;
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      else
      {
        MessageBox.Show("invailed name");
      }
    }
  }
}
