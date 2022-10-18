using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args) {
            var factory = new AnimalFactory();

            var animal = factory.GetAnimal("Dog");
            animal.Speak();
            animal = factory.GetAnimal("Cat");
            animal.Speak();
        }
    }
}
