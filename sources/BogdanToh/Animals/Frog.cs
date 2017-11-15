
class Frog : Animal
{
    public Frog()
    {
        Name="Frog";
    }

    private string _Name;
     public override string Name 
    {   get{return _Name;} 
    
        set{_Name=value;}
    
    }

    public override string MakeSound() => "Woak";
    public override string toString() => "This " + this._Name + " makes " + MakeSound(); 
}