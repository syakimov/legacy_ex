using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedAreasInMatrix
{
    class Program
    {
        public static char[,] matirx =
        {
            {  ' ', '*', ' '},
            {  ' ', '*', ' '},
            {  ' ', '*', ' '},
            {  ' ', '*', ' '}
        };
        public static SortedSet<Area> connectedAreasInMatrix = new SortedSet<Area>();
        private static void Main(string[] args)
        {
            var startCell = FindFreeCell(matirx);
            if (startCell == null)
            {
                return;
            }
            var area = new Area(startCell);
            Queue<Cell> cells = new Queue<Cell>();
            cells.Enqueue(startCell);
            FindConnectedAreas(matirx, area, cells);
            Console.WriteLine($"Connected areas {connectedAreasInMatrix.Count}");
            int counter = 1;
            foreach (var areas in connectedAreasInMatrix)
            {
                Console.WriteLine($"Area #{counter} at {areas.StartCell} with size {areas.Size} ");
                counter++;
            }
        }

        private static void FindConnectedAreas(char[,] matirx, Area area, Queue<Cell> cells)
        {
            while (cells.Any())
            {
                var cell = cells.Dequeue();
                if (!IsInRagne(matirx, cell))
                {
                    continue;
                }
                if (matirx[cell.Row, cell.Col] == ' ')
                {
                    area.Size++;
                    matirx[cell.Row, cell.Col] = '.';
                    cells.Enqueue(new Cell(cell.Row, cell.Col - 1));
                    cells.Enqueue(new Cell(cell.Row, cell.Col + 1));
                    cells.Enqueue(new Cell(cell.Row - 1, cell.Col));
                    cells.Enqueue(new Cell(cell.Row + 1, cell.Col));

                }
            }
            connectedAreasInMatrix.Add(area);
            var newCell = FindFreeCell(matirx);
            if (newCell == null)
            {
                return;
            }
            var newArea = new Area(newCell);
            cells.Enqueue(newCell);
            FindConnectedAreas(matirx, newArea, cells);
            
        }

        private static bool IsInRagne(char[,] matirx, Cell cell)
        {
            if (cell.Row < 0 || cell.Row >= matirx.GetLength(0) || cell.Col < 0 || cell.Col >= matirx.GetLength(1))
            {
                return false;
            }
            return true;
        }

        private static Cell FindFreeCell(char[,] matirx)
        {
            for (int i = 0; i < matirx.GetLength(0); i++)
            {
                for (int j = 0; j < matirx.GetLength(1); j++)
                {
                    if (matirx[i, j] == ' ')
                    {
                        return new Cell(i, j);
                    }
                }
            }
            return null;
        }
    }
}
