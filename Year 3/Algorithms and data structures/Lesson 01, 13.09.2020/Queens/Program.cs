using System;

namespace Queens {
    class MainClass {
        public static void PutQueen(int[,] board, int row = 0) {
            if (row == board.GetLength(0)) {
                PrintBoard(board);
            }
            else {
                for (int col = 0; col < board.GetLength(0); col++) {
                    if (board[row, col] == 0) {
                        AddMark(1, row, col, board);
                        PutQueen(board, row + 1);
                        AddMark(-1, row, col, board);
                    }
                }
            }
        }

        private static void AddMark(int mark, int row, int col, int[,] board) {
            for (int offset = 0; offset < board.GetLength(0); offset++) {
                board[row, offset] += mark; // add to row
                board[offset, col] += mark; // add to column

                int rowAbove = row - offset, rowBelow = row + offset;
                int colLeft  = col - offset, colRight = col + offset;

                if (rowBelow < board.GetLength(0) && colRight < board.GetLength(0)) {
                    board[row + offset, col + offset] += mark;
                }
                if (rowAbove >= 0 && colRight < board.GetLength(0)) {
                    board[row - offset, col + offset] += mark;
                }
                if (rowAbove >= 0 && colLeft >= 0) {
                    board[row - offset, col - offset] += mark;
                }
                if (rowBelow < board.GetLength(0) && colLeft >= 0) {
                    board[row + offset, col - offset] += mark; 
                }
            }
            board[row, col] += mark;
        }

        private const char empty = '.';
        private const char queen = 'Q';
        private static int solution;

        private static void PrintBoard(int[,] board) { // Could be improved by generating the solution string and printing it
            Console.WriteLine(++solution);

            for (int row = 0; row < board.GetLength(0); row++) {
                for (int col = 0; col < board.GetLength(0); col++) {
                    Console.Write((board[row, col] < 7) ? empty : queen);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private const int boardSize = 2;

        public static void Main(string[] args) {
            PutQueen(new int[boardSize, boardSize]);
        }
    }
}
