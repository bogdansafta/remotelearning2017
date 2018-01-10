using System;
namespace VendingMachine
{
    public class Position : IEquatable<Position>
    {
    public int Row { get; set; }
    public int Column { get; set; }
    public int Size { get; set; }
    public int ID { get; set; }
  
    public Position()
    {
        
    }
    public Position(int row , int column , int size, int id)
    {
        Row=row;
        Column=column;
        Size=size;
        ID=id;
    }
    public bool Equals( Position other)
    {
        if (Row!=other.Row ||Column!=other.Column||Size!=other.Size || ID!=other.ID)
        return false;
        return true;
    }

    }

}