using TennisBabySteps;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisBabyStepsTest
{
    [TestClass]
    public class TennisBabyStepsTests
    {
        [TestMethod]
        public void New_Game_Score_Should_Be_Love_Love()
        {
            var game = new Game();
            game.NewGame();
            Assert.AreEqual(game.GetScore(), "Love - Love");
        }

        [TestMethod]
        public void Player_One_Scores_First_Then_Game_Score_Should_Be_Fifteen_Love()
        {
            var game = new Game();
            game.NewGame();
            game.PlayerOneScores();
            Assert.AreEqual(game.GetScore(), "Fifteen - Love");
        }

        [TestMethod]
        public void Player_Two_Scores_First_Then_Game_Score_Should_Be_Love_Fifteen()
        {
            var game = new Game();
            game.NewGame();
            game.PlayerTwoScores();
            Assert.AreEqual(game.GetScore(), "Love - Fifteen");
        }

        [TestMethod]
        public void Player_One_Scores_First_Then_Player_Two_Scores_Then_Game_Score_Should_Be_Fifteen_All()
        {
            var game = new Game();
            game.NewGame();
            game.PlayerOneScores();
            game.PlayerTwoScores();
            Assert.AreEqual(game.GetScore(), "Fifteen All");
        }

        [TestMethod]
        public void Player_Two_Scores_First_Then_Player_One_Scores_Then_Game_Score_Should_Be_Fifteen_All()
        {
            var game = new Game();
            game.NewGame();
            game.PlayerTwoScores();
            game.PlayerOneScores();
            Assert.AreEqual(game.GetScore(), "Fifteen All");
        }
    }
}
