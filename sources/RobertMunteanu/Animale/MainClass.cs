using System;

namespace Animale
{
    public class MainClass
    {
        public static void Main()
        {
            Animal[] animale = new Animal[4];
            animale[0] = new Dog();
            animale[1] = new Cat();
            animale[2] = new Frog();
            animale[3] = new Fox();
            

            for(int i = 0; i < 4 ; i++)
            {
                System.Console.WriteLine(animale[i].Name() + " \n" + animale[i].MakeSound() + " \n");
            }
        }
    }
}
