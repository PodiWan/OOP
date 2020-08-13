using System;

namespace OOP
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.SetNumberOfFeet(4);
            Console.WriteLine(animal.GetNumberOfFeet());
            animal.SetName("Darius");
            animal.Name();

            Animal animal2 = new Animal();
            animal2.SetMammalProperty(true);
            animal2.SetName("David");
            animal2.Name();
        }
    }
}
