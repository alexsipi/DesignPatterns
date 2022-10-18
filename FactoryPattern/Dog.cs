
using System;

namespace FactoryPattern
{
    public class Dog : IAnimal
    {
        public void Speak() {
            Console.WriteLine("I am a dog");
        }
    }
}
