using System;
using System.Collections.Generic;
using System.Data;
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
using Dapper;

namespace ProductService
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFPaint" in both code and config file together.
  public class WCFPaint : IWCFPaint
  {


    public void DoWork()
    {
      Console.WriteLine("you in the server MTHF");
    }

    public void Save(List<DrawAction> obj, string filename)
    {
      using (var conn = new SqlConnection("Server=.;Integrated Security=true; MultipleActiveResultSets = True"))
      {
        conn.Open();
        string sqlQuery = "INSERT INTO PainterDB.dbo.Paints (filename) VALUES (@filename); " +
                          "SELECT SCOPE_IDENTITY();";
        Console.WriteLine(sqlQuery);
        var transaction = conn.BeginTransaction();


        //var cmd = new SqlCommand(sqlQuery, conn, transaction);
        //cmd.Parameters.Add("filename", SqlDbType.VarChar, 50).Value = filename;

        try
        {
          //var parameters = new
          //{
          //  filename = filename,
          //  foo1 = 1,
          //  date  = DateTime.Now,
          //};

          var firstID = conn.ExecuteScalar<int>(sqlQuery, new {filename = filename}, transaction);
          //var firstID = cmd.ExecuteScalar();
          Console.WriteLine(firstID);

          sqlQuery =
            "INSERT INTO PainterDB.dbo.Actions (action,item,color,x_coor,y_coor,P_ID) VALUES (@Action,@AItem,@APaintcolor,@Xcoor,@Ycoor," +
            firstID + ");";

          //conn.Execute(sqlQuery,new { = obj})


          //cmd = new SqlCommand(sqlQuery, conn, transaction);
          //cmd.Parameters.Add("AAction", SqlDbType.VarChar, 50);
          //cmd.Parameters.Add("AAItem", SqlDbType.VarChar, 50);
          //cmd.Parameters.Add("AAPaintcolor", SqlDbType.VarChar, 50);
          //cmd.Parameters.Add("AXcoor", SqlDbType.Int, 8);
          //cmd.Parameters.Add("AYcoor", SqlDbType.Int, 8);


          //List<object> insertActionsParameters = obj.Select(action => (object)new {}).ToList();


          //foreach (var A in obj)
          //{
          //  insertActionsParameters.Add(
          //    new DrawAction() { Action = A.Action, AItem = A.AItem, APaintcolor = A.APaintcolor.Name, Xcoor = A.Xcoor, Ycoor = A.Ycoor }
          //  );
          //cmd.Parameters["AAction"].Value = A.Action;
          //cmd.Parameters["AAItem"].Value = A.AItem;
          //cmd.Parameters["AAPaintcolor"].Value = A.APaintcolor.Name;
          //cmd.Parameters["AXcoor"].Value = A.Xcoor;
          //cmd.Parameters["AYcoor"].Value = A.Ycoor;
          //Console.WriteLine(cmd.CommandText);

          //cmd.ExecuteNonQuery();

          //}
          conn.Execute(sqlQuery, obj, transaction);


          transaction.Commit();
          Console.WriteLine("comitted");

        }
        catch (Exception ex)
        {
          transaction.Rollback();
          Console.WriteLine("rollback");
        }
        finally
        {
          conn.Close();
        }
      }
    }





    public void Open(string filename)
    {

    }


    public IEnumerable<string> Getfiles()
    {
      using (var conn = new SqlConnection("Server=.;Integrated Security=true; MultipleActiveResultSets = True"))
      {
        conn.Open();
        string sqlQuery = "Select filename From PainterDB.dbo.Paints; ";
        Console.WriteLine(sqlQuery);
        try
        {
          var files = conn.Query<string>(sqlQuery);
          return files;
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
          throw;
        }

      }
    }
  }
}

