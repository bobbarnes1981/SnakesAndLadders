using SnakesAndLadders.Library;

namespace SnakesAndLadders.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Squares = new Square[100];
            for (int i = 0; i < 100; i++)
            {
                board.Squares[i] = new Square();
            }

            // ladders
            board.Squares[3].Link = 13;
            board.Squares[8].Link = 30;
            board.Squares[19].Link = 37;
            board.Squares[27].Link = 83;
            board.Squares[39].Link = 58;
            board.Squares[50].Link = 66;
            board.Squares[62].Link = 80;
            board.Squares[70].Link = 90;

            // snakes
            board.Squares[16].Link = 6;
            board.Squares[53].Link = 33;
            board.Squares[61].Link = 18;
            board.Squares[63].Link = 59;
            board.Squares[86].Link = 23;
            board.Squares[92].Link = 72;
            board.Squares[94].Link = 74;
            board.Squares[98].Link = 77;

            Player[] players = new Player[2];
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player();
            }

            ILogger logger = new ConsoleLogger(new DateTimeProvider());

            Game game = new Game(new Dice6(new Random()), board, players, logger);

            logger.Log("Starting");

            while(game.Move())
            {

            }

            logger.Log("Done");
        }
    }
}
