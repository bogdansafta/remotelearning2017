using System;

namespace Vending_machine_V2
{
    public class Position
    {
        public int id { get; set; }
        public int row { get; set; }
        public int column { get; set; }
        public int size { get; set; }
        public Position(int id, int row, int column, int size)
        {
            this.id = id;
            this.row = row;
            this.column = column;
            this.size = size;
        }
    }
}