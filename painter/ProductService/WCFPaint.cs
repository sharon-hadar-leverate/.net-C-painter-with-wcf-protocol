using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using ProductInterfaces;
using System.Xml.Serialization;
using painter;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ProductService
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFPaint" in both code and config file together.
  public class WCFPaint : IWCFPaint
  {


    public  void DoWork()
    {
      Console.WriteLine("you in the server MTHF");
    }

    //public void Save(List<DrawAction> obj, string filename)
    //{
    //  
    //  Console.WriteLine(Environment.NewLine+"the drawing file:'" +filename+"' was saved and contains:");
    //  foreach (var V1 in obj)
    //  {
    //    Console.WriteLine(V1.ToString());
    //  }
    //  Console.WriteLine("===========**********===========");
    //}

    /// <summary>
    /// /////////////////////////////////////////////////////////////
    /// </summary>



    public void Save(List<DrawAction> obj, string filename)
    {
      var conn = new SqlConnection("Server=.;Integrated Security=true; MultipleActiveResultSets = True");
      conn.Open();
      string sqlQuery = "INSERT INTO PainterDB.dbo.Paints (filename) VALUES ('" + filename + "');";
      Console.WriteLine(sqlQuery);

      var cmd = new SqlCommand(sqlQuery, conn);
      cmd.ExecuteReader();

      sqlQuery = "SELECT IDENT_CURRENT('PainterDB.dbo.Paints')as num;";
      var cmd2 = new SqlCommand(sqlQuery, conn);
      var firstID = cmd2.ExecuteReader();
      firstID.Read();
      decimal P_ID = firstID.GetDecimal(0);
      Console.WriteLine(P_ID);
      foreach (var A in obj)
      {
        sqlQuery = "INSERT INTO PainterDB.dbo.Actions (action,item,color,x_coor,y_coor,P_ID) VALUES" +
                   " ('" + A.Action + "','" + A.AItem + "','" + A.APaintcolor + "','" +  A.Xcoor + "','" + A.Ycoor+"','" + Decimal.ToInt32(P_ID) + "');";
        cmd = new SqlCommand(sqlQuery, conn);
        Console.WriteLine(sqlQuery);
        cmd.ExecuteReader();

      }
      Console.WriteLine("read");
      conn.Close();

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
