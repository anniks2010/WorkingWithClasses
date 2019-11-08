using System;

namespace workingWithClasses
{
    internal class Hamster: Animal
    {
        public double weigh;

        public void eatingCarrots()
        {
            Console.WriteLine("Eating carrots");
            weigh += 0.5;
        
        }

        public void SumOfWeigh()
        {
            Console.WriteLine($"Hamster sum of weigh is {weigh}");
        }
    }
}
