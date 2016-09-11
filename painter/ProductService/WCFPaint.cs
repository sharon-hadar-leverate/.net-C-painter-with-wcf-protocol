using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProductInterfaces;
using System.Xml.Serialization;
using painter;

namespace ProductService
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFPaint" in both code and config file together.
  public class WCFPaint : IWCFPaint
  {


    public  void DoWork()
    {
      Console.WriteLine("you in the server MTHF");
    }

    public void Save(List<DrawAction> obj, string filename)
    {
      ;
      Console.WriteLine(Environment.NewLine+"the drawing file:'" +filename+"' was saved and contains:");
      foreach (var V1 in obj)
      {
        Console.WriteLine(V1.ToString());
      }
      Console.WriteLine("===========**********===========");
    }







    //  public void Open(string filename)
    //  {
    //    try
    //    {
    //      using (PainterDBEntities database = new PainterDBEntities())
    //      {
    //        var img 

    //        if (File.Exists(filename))
    //        {
    //          XmlSerializer xs = new XmlSerializer(typeof(Form1));
    //          FileStream read = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
    //          Form1 form = (Form1) xs.Deserialize(read);

    //        }
    //      }
    //    }
    //    finally
    //    {
    //    }
    //  }





    //  public void Save(object obj, string filename)
    //  {
    //    try
    //    {
    //      XmlSerializer sr = new XmlSerializer(obj.GetType());
    //      TextWriter writer = new StreamWriter(filename);
    //      sr.Serialize(writer,obj);
    //      writer.Close();




    //      using (PainterDBEntities database = new PainterDBEntities())
    //      {

    //      }
    //    }
    //    finally
    //    {
    //    }
    //  }

    //  public void DoWork()
    //  {
    //  }
  }
}
