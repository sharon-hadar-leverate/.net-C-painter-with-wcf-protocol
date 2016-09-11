using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace ProductInterfaces
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFPaint" in both code and config file together.
  [ServiceContract]
  public interface IWCFPaint
  {
    [OperationContract]
    //void Save(string filename, ImageFormat format);
    void Save(List<DrawAction> obj, string filename);
    //void Open(string filename);
    void DoWork();
  }
}
