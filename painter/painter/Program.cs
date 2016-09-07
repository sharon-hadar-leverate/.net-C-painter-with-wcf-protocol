using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductInterfaces;

namespace painter
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>




    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
      //ChannelFactory<IWCFPaint> channelFactory = new
      //  ChannelFactory<IWCFPaint>("PainterEndpoint");
      //IWCFPaint proxy = channelFactory.CreateChannel();
      //proxy.DoWork();




    }
  }
}
