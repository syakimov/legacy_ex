using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathsBetweenCellsInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Path.Exit();
        }
    }
    static class Path
    {
       
        static char[,] lab =
        {
            { 'S',' ',' ',' '},
            { ' ','*','*',' '},
            { ' ','*','*',' '},
            { ' ','*','e',' '},
            { ' ','*','*','*'}
        };
        public static void Exit()
        {
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    if (lab[i,j]=='S')
                    {
                        lab[i, j] = ' ';
                        FindExit(i, j);
                    }
                }
            }
        }
        public static void FindExit(int row, int col)
        {
            if (!InRange(row, col))
            {
                return;
            }
            if (lab[row,col] == 'e')
            {
                PrintPath();
            }
            if (lab[row,col] !=' ')
            {
                return;
            }
            
            //up
            FindExit(row - 1, col);
            lab[row, col] = 'U';
            //right
            FindExit(row, col + 1);
            lab[row, col] = 'R';
            //left
            FindExit(row, col - 1);
            lab[row, col] = 'L';
            //down
            FindExit(row + 1, col);
            lab[row, col] = 'D';

            lab[row, col] = ' ';
        }

        private static void PrintPath()
        {
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    if (lab[i,j]=='L' || lab[i, j] == 'U' || lab[i, j] == 'D' || lab[i, j] == 'R')
                    {
                        Console.Write(lab[i,j]);
                    }
                }
            }
            Console.WriteLine();
        }

        private static bool InRange(int row, int col)
        {
            bool rowInRange = row < lab.GetLength(0) && row >= 0;
            bool colInRange = col < lab.GetLength(1) && col >= 0;
            return rowInRange && colInRange;
        }
    }
}
