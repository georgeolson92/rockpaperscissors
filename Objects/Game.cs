namespace RPSGame.Objects
{
  public class Game
  {
    private string _p1;
    private string _p2;

    public Game(string p1, string p2)
    {
      _p1 = p1;
      _p2 = p2;
    }

    public string Play()
    {
      string result = "";
      if ((_p1=="rock" && _p2=="scissors") || (_p1=="scissors"&&_p2=="paper") || (_p1=="paper"&&_p2=="rock"))
      {
        result = "Player 1";
      }
      else if ((_p2=="rock" && _p1=="scissors") || (_p2=="scissors"&&_p1=="paper") || (_p2=="paper"&&_p1=="rock"))
      {
        result = "Player 2";
      }
      else if ((_p1 == _p2))
      {
        result = "Draw";
      }
      else
      {
        result = "Invalid game!";
      }
      return result;
    }
  }
}
