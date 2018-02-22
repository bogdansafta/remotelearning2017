using System;

namespace VendingMachine
{
    public class Position
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public int Size { get; set; }
        
        public int ID { get; set; }
        
        public Position(int row, int column, int size, int id)
        {
            this.Row = row;
            this.Column = column;
            this.Size = size;
            this.ID=id;
        }

        public override string ToString() => $"Row: {this.Row} / Column: {this.Column} / Size: {this.Size} / ID: {this.ID}";
    }
}