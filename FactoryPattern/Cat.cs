
using System;

namespace FactoryPattern
{
    public class Cat : IAnimal
    {
        public void Speak() {
            Console.WriteLine("I am a cat");
        }
    }
}
