namespace Privatemod
{
    public class Tictactoe
    {
        static GameFunctions helper = new GameFunctions();
        public static void Main(string[] args)
        
        {
            bool gameOver = false;
            Console.WriteLine("Tic Tac Toe");
            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");
           
              char[,] board = new char[3, 3];

              for (int row = 0; row < 3; row++)
{
    for (int col = 0; col < 3; col++)
    {
        board[row, col] = '-'; // Empty cell
    }
}

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
while (!gameOver)
            {
                Console.WriteLine("Player 1, enter your move (row and column): ");
                string input1 = Console.ReadLine() ?? string.Empty;
                string[] parts1 = input1.Split(' ');
                int row1 = int.Parse(parts1[0]);
                int col1 = int.Parse(parts1[1]);
                if (board[row1, col1] == '-')
                {
                    board[row1, col1] = 'X';
                }
                else
                {
                    Console.WriteLine("Cell already occupied. Try again.");
                    continue;
                }

                helper.displayBoard(board);

                if (helper.checkWin(board, 'X'))
                {
                    Console.WriteLine("Player 1 wins!");
                    gameOver = true;
                    break;
                }

                Console.WriteLine("Player 2, enter your move (row and column): ");
                string input2 = Console.ReadLine() ?? string.Empty;
                string[] parts2 = input2.Split(' ');
                int row2 = int.Parse(parts2[0]);
                int col2 = int.Parse(parts2[1]);
                if (board[row2, col2] == '-')
                {
                    board[row2, col2] = 'O';
                }
                else
                {
                    Console.WriteLine("Cell already occupied. Try again.");
                    continue;
                }

                helper.displayBoard(board);

                if (helper.checkWin(board, 'O'))
                {
                    Console.WriteLine("Player 2 wins!");
                    gameOver = true;
                    break;
                }

            } 
    }
    }
}