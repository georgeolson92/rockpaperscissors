using Xunit;

namespace RPSGame.Objects
{
  public class GameTests
  {
    [Fact]
    public void RPSGame_userInputRockScissors_ReturnPlayer1()
    {
      //Arrange
      string expectedResult = "Player 1";

      //Act
      Game game = new Game("rock", "scissors");
      string result = game.Play();

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void RPSGame_userInputRockPaper_returnPlayer2()
    {
      //Arrange
      string expectedResult = "Player 2";

      //Act
      Game game = new Game("rock","paper");
      string result = game.Play();

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void RPSGame_userInputScissorsPaper_returnPlayer1()
    {
      //Arrange
      string expectedResult = "Player 1";

      //Act
      Game game = new Game("scissors","paper");
      string result = game.Play();

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void RPSGame_userInputScissorsScissors_returnDraw()
    {
      //Arrange
      string expectedResult = "Draw";

      //Act
      Game game = new Game("scissors","scissors");
      string result = game.Play();

      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
