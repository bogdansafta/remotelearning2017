
class Frog : Animal
{


    
     public override string Name{get;set;}="Frog";
   

    public override string MakeSound() => "Woak";
    public override string toString() => $"This {this.Name} makes {MakeSound()}"; 
}