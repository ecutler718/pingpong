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
        _items.Add(i.ToString());
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
