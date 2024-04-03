using Xunit;
using ConnectFour;

namespace ConnectFour.Tests
{
    public class GameStateTests
    {
        [Fact]
        public void CheckForWin_NoWinner_EmptyBoard()
        {
            // Arrange
            var gameState = new GameState();

            // Act
            var result = gameState.CheckForWin();

            // Assert
            Assert.Equal(GameState.WinState.No_Winner, result);
        }

        [Fact]
        public void CheckForWin_TieGame()
        {
            // Arrange
            var gameState = new GameState();
            var board = new List<int>
            {
                1, 2, 1, 2, 1, 2, 1,
                2, 1, 2, 1, 2, 1, 2,
                1, 2, 1, 2, 1, 2, 1,
                2, 1, 2, 1, 2, 1, 2,
                1, 2, 1, 2, 1, 2, 1,
                2, 1, 2, 1, 2, 1, 2,
                1, 2, 1, 2, 1, 2, 1
             };
            gameState.Board = board;

            // Act
            var result = gameState.CheckForWin();

            // Assert
            Assert.Equal(GameState.WinState.Tie, result);
        }
    }
}
