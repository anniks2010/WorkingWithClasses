using System;

namespace workingWithClasses
{
    //Inheritance
    internal class Dog: Animal ///see tähendab, et kõiki Animal klassi omanusi saab kasutada Dog klassi puhul.
    {
        public int spotCount=0;
        public int numbersOfBarks = 0;

        public void Bark()
        {
            Console.WriteLine("Wuf");
            numbersOfBarks++;
            levelOfHappiness += 0.1;
            Random randomGenerator = new Random();
            spotCount += randomGenerator.Next(0,7);
        }

        public void ShowNumberOfDogSpots() /////see on uus meetod
        {
            Console.WriteLine($"{name} has now {spotCount} number of spots");
        }
    }
}
