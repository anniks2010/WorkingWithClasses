using System;

namespace Car
{

    class Program
    {
        static void Main(string[] args)
        {
            Car newAuto = new Car();
            newAuto.Mark = "BMW";
            newAuto.Model = "250TD";
            newAuto.Odomeeter = 20000;
            newAuto.Color = "black";
            newAuto.Year = 2015;
            newAuto.RegNumber = "999AAA";

            for (int i = 0; i < 20; i++)
            {
                newAuto.Drive();
            }

            newAuto.ShowOdo();

            Console.ReadLine();
        }

    }
}
