using System;

namespace OOP_Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Animal [] a=new Animal[3];
           a[0]=new Dog("Dog");
           a[1]=new Cat("Cat");
           a[2]=new Frog("Frog");
           for(int i=0;i<a.Length;i++)
           {
               Console.WriteLine("The "+a[i].name+" makes "+a[i].MakeSound());
           }
        }
    }
}
