
class Cat : Animal
{
    public Cat()
    {
        Name="Cat";
    }

    private string _Name;
    public override string Name 
    {   get{return _Name;} 
    
        set{_Name=value;}
    
    }

    public override string MakeSound() => "Miau";
    public override string toString() => "This " + this._Name + " makes " + MakeSound(); 
}