using TennisBabySteps;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisBabyStepsTest
{
    [TestClass]
    public class TennisBabyStepsTests
    {
        [TestMethod]
        public void NewGameScoreShouldBeLove_Love()
        {
            var game = new Game();
            Assert.AreEqual(game.GetScore(), "Love - Love");
        }

        [TestMethod]
        public void PlayerOneScoresReturnsFifteenLove()
        {
            var game = new Game();
            game.PlayerOneScores();
            Assert.AreEqual(game.GetScore(), "Fifteen - Love");
        }
    }
}
