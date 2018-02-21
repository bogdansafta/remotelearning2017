using System;

namespace VendingMachine
{
    internal class Position : IEquatable<Position>
    {
        int row;
        int column;
        int size;
        int ID;

        public Position()
        {
            row = 0;
            column = 0;
            size = 0;
            ID=0;
        }
        public Position(int x, int y, int z)
        {
            row = x;
            column = y;
            size = z;
        }

        public int ID1 { get => ID; set => ID = value; }

        public bool Equals(Position other)
        {
            if (column == other.column)
            {
                if (row <= other.row && row + size >= other.row)
                    return true;
                if (row >= other.row && other.row + other.size >= row)
                    return true;
            }
            return false;
        }
        public bool HasSameID(int ID)
        {
            if (this.ID==ID)
            return true;
            else return false;
        }

        public override string ToString()
        {
            return ("Rand:"+row + " Coloana:" + column + " Lungime:" + size + " ID:" + ID);
        }


    }
}