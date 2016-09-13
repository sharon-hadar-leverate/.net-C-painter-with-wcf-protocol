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
    public int x_coor { get; private set; }

    [DataMember]
    public int y_coor { get; private set; }

    [DataMember]
    public Item item { get; private set; }

    [DataMember]
    public string color { get; private set; }

    public DrawAction()
    {
      
    }
    public DrawAction(Action action, int x, int y, Item item, Color paintcolor)
    {
      Action = action;
      this.item = item;
      x_coor = x;
      y_coor = y;
      color = paintcolor.Name;
    }

    public override string ToString()
    {
      string ActionString;
      ActionString = Action.ToString() + " " + item.ToString() + " " + color.ToString() + " " +
                     x_coor.ToString() + " " +
                     y_coor.ToString();
      return ActionString;
    }

  }
}