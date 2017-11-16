
class Dog : Animal
{
    public Dog()
    {
        Name="Dog";
    }
    private string _Name;
    public override string Name { 
        get{return _Name;}
        set {_Name=value;}
    }
    public override string MakeSound() => "Ham";
    public override string toString() => "This " + this._Name + " makes " + MakeSound(); 
    
        
    
}