using System;

namespace workingWithClasses
{
    internal class Cat: Animal
    {
        public double levelOfNunnu;

        public void kurrNao()
        {
            Console.WriteLine("näjuuuu");
            levelOfNunnu -= 0.2;
            levelOfHappiness += 0.1;
        }
        public void ShowLevelOfNunnu()
        {
            Console.WriteLine($"Level of nunnu: {levelOfNunnu}");
        }
        public void HearBarks(int numbersOfBarks)
        {
            levelOfHappiness -= 0.1 * numbersOfBarks;
        }

    }
}
