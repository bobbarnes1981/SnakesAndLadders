namespace SnakesAndLadders.Library
{
    public class Game
    {
        // generates random dice throw
        private IDice m_dice;

        // indicates which player is taking turn
        private int m_player;

        // indicates the total number of turns
        private int m_turn;

        // represents the play board
        private Board m_board;

        // represents the players taking part
        private Player[] m_players;

        // logs output
        private ILogger m_logger;

        public Game(IDice dice, Board board, Player[] players, ILogger logger)
        {
            m_dice = dice;
            m_player = 0;
            m_turn = 0;
            m_board = board;
            m_players = players;
            m_logger = logger;
        }

        // move a player one turn, return false if game is over
        public bool Move()
        {
            m_logger.Log(string.Format("Turn {0}", m_turn));

            int roll = m_dice.Roll();

            m_logger.Log(string.Format("Player {0} rolled a {1}", m_player, roll));

            Player currentPlayer = m_players[m_player];

            currentPlayer.Location += roll;

            m_logger.Log(string.Format("Player {0} moved to {1}", m_player, currentPlayer.Location));

            if (currentPlayer.Location >= m_board.Squares.Length)
            {
                m_logger.Log(string.Format("Player {0} has won", m_player));

                return false;
            }

            int? link = m_board.Squares[currentPlayer.Location].Link;

            if (link.HasValue)
            {
                string linkType = currentPlayer.Location > link.Value ? "SNAKE" : "LADDER";

                m_logger.Log(string.Format("Square {0} links to {1} ({2})", currentPlayer.Location, link.Value, linkType));

                currentPlayer.Location = link.Value;

                m_logger.Log(string.Format("Player {0} moved to {1}", m_player, currentPlayer.Location));
            }

            m_player++;
            if (m_player >= m_players.Length)
            {
                m_player = 0;
            }

            m_turn++;

            return true;
        }
    }
}
