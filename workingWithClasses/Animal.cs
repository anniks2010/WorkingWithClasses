using System;

namespace workingWithClasses
{
    internal class Animal
    {
        public string name;
        public int age;
        public double levelOfHappiness; ///need on omadused

        public void PrintAnimalBaseInfo()////see on meetod
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Level of happiness: {levelOfHappiness}"); 
        }
        public void ShowLevelOfHappiness()
        {
            Console.WriteLine($"Level of happiness: {levelOfHappiness}");
        }
    }
}
