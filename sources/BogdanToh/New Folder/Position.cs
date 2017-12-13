using System;

namespace New_Folder
{
    public class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int size { get; set; }
        public Position() { }

        public Position(int row,int column,int size)
        {
            this.Row = row;
            this.Column = column;
            this.size = size;
        }

        public override string ToString()
        {
          return $"Row:{this.Row}|Column:{this.Column}|Size:{this.size}";
        }


    }
}
