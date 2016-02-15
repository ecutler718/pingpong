using Nancy;
using System.Collections.Generic;
using PingPongList;

namespace PingPong
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]= _ =>{
        return View["index.cshtml"];
      };
      Post["/result"]= _ => {
        PingPongGenerator.ClearAll();
        PingPongGenerator game = new PingPongGenerator(int.Parse(Request.Form["userInput"]));
        List<string> userList = PingPongGenerator.GetAll();
        return View ["game_result.cshtml", userList];
      };
    }
  }
}
