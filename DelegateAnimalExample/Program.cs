using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAnimalExample
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal Sound");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog Sound");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat Sound");
        }
    }
    delegate T AnimalDelegate<out T, in P>(P a);
    class Mainclass
    {
        static Dog M(Animal a)
        {
            a.Speak();
            return (Dog)a;

        }
        static void Main()
        {
            AnimalDelegate<Animal, Dog> d = M;
            Animal a = d(new Dog());
            a.Speak();
        }
    }
      
    
}
