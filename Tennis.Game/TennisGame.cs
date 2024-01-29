namespace Tennis.Game
{
    public class TennisGame : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                m_score1 += 1;
            else
                m_score2 += 1;
        }

        public string GetScore()
        {
            string score = "";
            if (m_score1 == m_score2)
            {
                score = TennisGameStrings.EqualScoreEnum[m_score1];
            }
            else if (m_score1 >= 4 || m_score2 >= 4)
            {
                score = TennisGameStrings.ScoreWinEnum[m_score1 - m_score2];
            }
            else
            {
                for (var i = 1; i < 3; i++)
                    score = TennisGameStrings.ScoreEnum[string.Format("{0}{1}", m_score1, m_score2)];
            }
            return score;
        }
       
    }
}
