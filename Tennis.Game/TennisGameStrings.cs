namespace Tennis.Game
{
    public static class TennisGameStrings
    {
        public static Dictionary<int, string> EqualScoreEnum
        {
            get
            {
                var dict = new Dictionary<int, string>();
                dict.Add(0, "Love-All");
                dict.Add(1, "Fifteen-All");
                dict.Add(2, "Thirty-All");
                dict.Add(3, "Deuce");
                dict.Add(4, "Deuce");
                return dict;
            }
        }
        public static Dictionary<int, string> ScoreWinEnum
        {
            get
            {
                var dict = new Dictionary<int, string>();
                dict.Add(-1, "Advantage player2");
                dict.Add(1, "Advantage player1");
                dict.Add(2, "Win for player1");
                dict.Add(-2, "Win for player2");
                dict.Add(3, "Win for player1");
                dict.Add(-3, "Win for player2");
                dict.Add(4, "Win for player1");
                dict.Add(-4, "Win for player2");
                return dict;
            }
        }

        public static Dictionary<string, string> ScoreEnum
        {
            get
            {
                var dict = new Dictionary<string, string>();
                dict.Add("00", "Love");
                dict.Add("01", "Love-Fifteen");
                dict.Add("02", "Love-Thirty");
                dict.Add("03", "Love-Forty");
                dict.Add("10", "Fifteen-Love");
                dict.Add("12", "Fifteen-Thirty");
                dict.Add("13", "Fifteen-Forty");
                dict.Add("20", "Thirty-Love");
                dict.Add("21", "Thirty-Fifteen");
                dict.Add("23", "Thirty-Forty");
                dict.Add("30", "Forty-Love");
                dict.Add("31", "Forty-Fifteen");
                dict.Add("32", "Forty-Thirty");
                return dict;
            }
        }

    }
}


