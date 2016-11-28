namespace TennisBabySteps
{
    public class Game
    {
        private string currentScore;

        private int playerOneScore = 0;

        private int playerTwoScore = 0;

        private readonly string[] scores = new string[] {
            "Love",
            "Fifteen",
            "Thirty",
            "Forty",
            "Deuce",
            "Advantage"
        };
        
        public void NewGame()
        {
            currentScore = "Love - Love";
        }

        public string GetScore()
        {
            currentScore = scores[playerOneScore] + " - " + scores[playerTwoScore];
            return currentScore;
        }

        public void PlayerOneScores()
        {
            playerOneScore++;
        }

        public void PlayerTwoScores()
        {
            playerTwoScore++;
        }
    }
}
