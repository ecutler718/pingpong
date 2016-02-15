using System;
using System.Collections.Generic;

namespace PingPongList
{
  public class PingPongGenerator
  {
    private int _userInput;
    private int _id;
    private static List<string> _items = new List<string> {};

    public PingPongGenerator (int userInput)
    {
      _userInput = userInput;
      //put logic here
      for(int i = 1; i<=userInput; i++)
      {
        if (i % 15 == 0)
        {
          _items.Add("ping-pong");
        }
        else if(i % 3 == 0)
        {
          _items.Add("ping");
        }
        else if (i % 5 == 0)
        {
          _items.Add("pong");
        }
        else
        {
         _items.Add(i.ToString());
        }
      }
    }

    public static List<string> GetAll()
    {
      return _items;
    }

    public static void ClearAll()
    {
      _items.Clear();
    }

  }
}
