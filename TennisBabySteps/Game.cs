namespace TennisBabySteps
{
    public class Game
    {
        private string currentScore;

        public void NewGame()
        {
            currentScore = "Love - Love";
        }

        public string GetScore()
        {
            return currentScore;
        }

        public void PlayerOneScores()
        {
            currentScore = "Fifteen - Love";
        }

        public void PlayerTwoScores()
        {
            currentScore = "Love - Fifteen";
        }
    }
}
