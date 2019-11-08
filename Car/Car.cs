using System;

namespace Car
{
    internal class Car
    {
        public string Mark;
        public string Model;
        public double Odomeeter =0;
        public string Color;
        public int Year;
        public string RegNumber;
        public int FuelLevel;

        public void Drive()
        {
            Odomeeter += 100; 
           
        }
        public void ShowOdo()
        {
            Console.WriteLine($"Your car {Mark} {Model} {RegNumber} has been driven {Odomeeter} km");
        }

    }
}
