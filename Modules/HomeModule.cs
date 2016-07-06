using System.Collections.Generic;
using Nancy;
using  System;
using RPSGame.Objects;

namespace RPSGame
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/player1"] =_=> View["player1.cshtml"];
      Post["/p1Rock"] =_=> {
        string p1choice = "rock";
        return View["player2.cshtml", p1choice];
      };
      Post["/p1Paper"] =_=> {
        string p1choice = "paper";
        return View["player2.cshtml", p1choice];
      };
      Post["/p1Scissors"] =_=> {
        string p1choice = "scissors";
        return View["player2.cshtml", p1choice];
      };
      Post["/p2Rock"] =_=> {
        string p1choice = Request.Form["p1choice"];
        string p2choice = "rock";
        Game game = new Game(p1choice, p2choice);
        return View["result.cshtml", game.Play()];
      };
      Post["/p2Paper"] =_=> {
        string p1choice = Request.Form["p1choice"];
        string p2choice = "paper";
        Game game = new Game(p1choice, p2choice);
        return View["result.cshtml", game.Play()];
      };
      Post["/p2Scissors"] =_=> {
        string p1choice = Request.Form["p1choice"];
        string p2choice = "scissors";
        Game game = new Game(p1choice, p2choice);
        return View["result.cshtml", game.Play()];
      };
    }
  }
}
