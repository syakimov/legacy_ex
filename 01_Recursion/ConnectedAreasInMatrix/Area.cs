using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedAreasInMatrix
{
    public class Area : IComparable<Area>
    {
        public Area(Cell startcell)
        {
            StartCell = startcell;
            Size = 0;
        }
        public Cell StartCell { get; set; }
        public int Size { get; set; }

        public int CompareTo(Area other)
        {
            int result = other.Size.CompareTo(Size);
            if (result == 0)
            {
                result = StartCell.Row.CompareTo(other.StartCell.Row);
            }
            if (result == 0)
            {
                result = StartCell.Col.CompareTo(other.StartCell.Col);
            }
            return result;
        }
    }
}
