using System;

namespace _07.KnightGame
{
    public class KnightGame
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            FillMatrix(n, matrix);

            int hittedHorse = 0;
            int bestRow = 0;
            int bestCol = 0;
            int counter = 0;

            while (true)
            {
                int savedHorse = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        hittedHorse = CheckMatrix(matrix, row, col, n, hittedHorse);

                        if (hittedHorse > savedHorse)
                        {
                            savedHorse = hittedHorse;
                            bestRow = row;
                            bestCol = col;
                        }

                        hittedHorse = 0;
                    }
                }
                if (savedHorse == 0)
                {
                    break;
                }

                matrix[bestRow, bestCol] = '0';
                counter++;
                bestRow = 0;
                bestCol = 0;
            }

            Console.WriteLine(counter);
        }

        private static int CheckMatrix(char[,] matrix, int row, int col, int n, int hittedHorse)
        {
            if (matrix[row, col] == 'K')
            {
                if (row - 2 >= 0 && col + 1 < n && matrix[row - 2, col + 1] == 'K')
                {
                    hittedHorse++;
                }
                if (row - 1 >= 0 && col + 2 < n && matrix[row - 1, col + 2] == 'K')
                {
                    hittedHorse++;
                }
                if (row + 1 < n && col + 2 < n && matrix[row + 1, col + 2] == 'K')
                {
                    hittedHorse++;
                }
                if (row + 2 < n && col + 1 < n && matrix[row + 2, col + 1] == 'K')
                {
                    hittedHorse++;
                }
                if (row + 2 < n && col - 1 >= 0 && matrix[row + 2, col - 1] == 'K')
                {
                    hittedHorse++;
                }
                if (row + 1 < n && col - 2 >= 0 && matrix[row + 1, col - 2] == 'K')
                {
                    hittedHorse++;
                }
                if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1, col - 2] == 'K')
                {
                    hittedHorse++;
                }
                if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2, col - 1] == 'K')
                {
                    hittedHorse++;
                }
            }
            return hittedHorse;
        }

        private static void FillMatrix(int n, char[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }
    }
}
