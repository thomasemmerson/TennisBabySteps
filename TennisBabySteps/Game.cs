namespace TennisBabySteps
{
    public class Game
    {
        private string currentScore;

        private int playerOneScore = 0;

        private int playerTwoScore = 0;

        private string[] scores = new string[] {
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
            if (scores[playerOneScore] == scores[playerTwoScore])
            {
                currentScore = scores[playerOneScore] + " All";
            }
            else
            {
                currentScore = scores[playerOneScore] + " - " + scores[playerTwoScore];
            }
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
