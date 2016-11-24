using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisBabyStepsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NewGameScoreShouldBeLove_Love()
        {
            var game = new Game();
            Assert.AreEqual(game.GetScore(), "Love - Love");
        }
    }
}
