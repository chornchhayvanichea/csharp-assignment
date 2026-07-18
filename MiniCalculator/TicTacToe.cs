namespace Assignment.MiniCalculator
{
    public class TicTacToe
    {
        public static void Start()
        {
            char[,] board =
            {
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' },
            };
            char player = 'X';
            bool isGameOver = false;
            while (!isGameOver)
            {
                PrintBoard(board);
                Console.WriteLine($"player {player}, enter row and col (e.g: 1 2)");
                string[] input = (Console.ReadLine() ?? "").Split(' ');

                int row = int.Parse(input[0]) - 1;
                int col = int.Parse(input[1]) - 1;

                board[row, col] = player;

                if (CheckWin(board, player))
                {
                    PrintBoard(board);
                    Console.WriteLine($"Player {player} wins!");
                    isGameOver = true;
                }
                else if (IsBoardFull(board))
                {
                    PrintBoard(board);
                    Console.WriteLine("Draw!");
                    isGameOver = true;
                }
                else
                {
                    if (player == 'X')
                    {
                        player = 'O';
                    }
                    else
                    {
                        player = 'X';
                    }
                }
            }
        }

        private static void PrintBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + "|");
                }
                Console.WriteLine();
            }
        }

        private static bool IsBoardFull(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == ' ')
                        return false;
                }
            }
            return true;
        }

        private static bool CheckWin(char[,] board, char player)
        {
            return (board[0, 0] == player && board[0, 1] == player && board[0, 2] == player)
                || (board[1, 0] == player && board[1, 1] == player && board[1, 2] == player)
                || (board[2, 0] == player && board[2, 1] == player && board[2, 2] == player)
                //
                || (board[0, 0] == player && board[1, 0] == player && board[2, 0] == player)
                || (board[0, 1] == player && board[1, 1] == player && board[2, 1] == player)
                || (board[0, 2] == player && board[1, 2] == player && board[2, 2] == player)
                //
                || (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
                || (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player);
        }
    }
}
