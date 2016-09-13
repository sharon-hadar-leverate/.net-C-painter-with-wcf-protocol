using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace ProductInterfaces
{

  [DataContract]
  public class DrawAction
  {
    [DataMember]
    public Action Action { get; private set; }

    [DataMember]
    public int Xcoor { get; private set; }

    [DataMember]
    public int Ycoor { get; private set; }

    [DataMember]
    public Item AItem { get; private set; }

    [DataMember]
    public string APaintcolor { get; private set; }

    public DrawAction()
    {
      
    }
    public DrawAction(Action action, int x, int y, Item item, Color paintcolor)
    {
      Action = action;
      AItem = item;
      Xcoor = x;
      Ycoor = y;
      APaintcolor = paintcolor.Name;
    }

    public override string ToString()
    {
      string ActionString;
      ActionString = Action.ToString() + " " + AItem.ToString() + " " + APaintcolor.ToString() + " " +
                     Xcoor.ToString() + " " +
                     Ycoor.ToString();
      return ActionString;
    }

  }
}