
class Cat : Animal
{
   

    
    public override string Name {get; set;}="Cat";
    

    public override string MakeSound() => "Miau";
    public override string toString() => $"This {this.Name} makes {MakeSound()}";
}