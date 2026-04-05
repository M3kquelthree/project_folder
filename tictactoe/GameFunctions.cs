namespace Privatemod
{
    public class GameFunctions
    {
        public bool checkWin(char[,] board, char player)
        {
            // Check rows
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == player && board[row, 1] == player && board[row, 2] == player)
                    return true;
            }

            // Check columns
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == player && board[1, col] == player && board[2, col] == player)
                    return true;
            }

            // Check diagonals
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
                return true;
            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
                return true;

            return false;
        }

        public char [,] displayBoard(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    if (col < 2) Console.Write(" | "); // column separator
                }
                Console.WriteLine();
                if (row < 2) Console.WriteLine("---------"); // row separator
            }
            return board;
        }

    }

}