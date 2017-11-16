using System;

namespace OOPHelloWorld
{
    public abstract class Animal
    {
        public String Name;
        public abstract String MakeSound();
        public Animal(String Name)
        {
            this.Name=Name;
        }
    }
     public class Dog : Animal
    {
        public Dog(String Name) : base(Name) {} 
       
        public override String MakeSound()
        {
            String DogSound="HAMBWWW";
            return DogSound;
        }
    }
    public class Cat:Animal
    {
        public Cat(String Name) : base(Name){}
        public override String MakeSound()
        {
            String CatSound="MIAU";
            return CatSound;
        }
    }
    public class Frog:Animal
    {
        public Frog(String Name) : base(Name){}
        public override String MakeSound()
        {
            String FrogSound="OAC";
            return FrogSound;
        }
    }

    public class Program
    {
       public static void Main(string[] args)
        {
           Animal [] A=new Animal[3];
           for(int i=0;i<A.Length;i++)
           {
               A[0]=new Dog("Dog");
               A[1]=new Cat("Cat");
               A[2]=new Frog("Frog");
               Console.WriteLine("The "+A[i].Name+" makes "+A[i].MakeSound());
           }
        }
    }
}
