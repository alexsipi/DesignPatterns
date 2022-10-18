
namespace FactoryPattern
{
    public class AnimalFactory
    {
        public IAnimal GetAnimal(string AnimalType) {
            switch (AnimalType)
            {
                case "Dog":
                    return new Dog();
                case "Cat":
                    return new Cat();
                default:
                    return null;
            }
        }
    }
}
