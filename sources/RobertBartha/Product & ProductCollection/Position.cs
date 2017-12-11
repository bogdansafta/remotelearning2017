using System;

namespace Product___ProductCollection
{
    public class Position
    {
        public int row { get; set; }
        public int column { get; set; }
        public int size { get; set; }
        public Position(int row, int column, int size)
        {
            this.row = row;
            this.column = column;
            this.size = size;
        }
    }
}