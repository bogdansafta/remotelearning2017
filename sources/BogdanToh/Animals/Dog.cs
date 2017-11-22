
class Dog : Animal
{
   

    public override string Name{get;set;} = "Dog";

    public override string MakeSound() => "Ham";
    public override string toString() => $"This {this.Name} makes {MakeSound()}"; 
    
        
    
}