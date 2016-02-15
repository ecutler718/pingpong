using Nancy;
using System.Collections.Generic;

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
        PingPongGenerator.ClearAll()
        PingPongGenerator game = new PingPongGenerator(int.Parse(Request.Form["userInput"]));
        List<string> userList = game.GetAll();
        return View ["game_result.chstml", userList];
      };
    }
  }
}
