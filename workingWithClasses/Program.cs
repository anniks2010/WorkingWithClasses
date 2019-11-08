using System;

namespace workingWithClasses
{

    class Program
    {
        static void Main(string[] args)
        {
            Animal nurr = new Animal(); ///see on käsk objekti Animal() loomiseks
            nurr.name = "Nurr";
            nurr.age = 15;
            nurr.levelOfHappiness = 0.1;

            Dog koer = new Dog(); ////koer on objekti nimi. Koer on muutuja nimi
            koer.name = "Luna";
            koer.age = 1;
            koer.levelOfHappiness = 0.2;
            koer.spotCount = 0;
            

            nurr.PrintAnimalBaseInfo();
            koer.PrintAnimalBaseInfo();
            koer.Bark();
            koer.ShowLevelOfHappiness();

            Cat kass = new Cat();
            kass.name = "Minni";
            kass.age = 5;
            kass.levelOfHappiness = 0.6;
            kass.levelOfNunnu = 0.3;

            for (int i = 0; i < 5; i++)
            {
                kass.kurrNao();

            }

            kass.ShowLevelOfNunnu();
            /////kass = null; andmed kustutatakse selles klassis.

            ////Dog barks
            for (int i = 0; i < 20; i++)
            {
                koer.Bark();

            }
            kass.HearBarks(koer.numbersOfBarks);
            
            if(kass.levelOfHappiness <= 0)
            {
                Console.WriteLine($"{kass.name} died of stress.");
                kass = null;
            }


            koer.ShowLevelOfHappiness();
            koer.ShowNumberOfDogSpots();

           
            ///hamster, kes oskab süüa ja on olemas kaal. Ning kui hamstri kaal on suurem ... Hamster ei ela kauem, kui 10 päeva (while). Nende päevade jooksul võib süüa, kaalu juurde võtta ning jookseb. Siis anda kokkuvõte, kui palju ta sõi, jooksis, kaalus 10 päeva jooksul.
            Hamster hamstriPoeg = new Hamster();
            hamstriPoeg.name = "Kollane";
            hamstriPoeg.weigh = 0.9;

            for (int i = 0; i < 10; i++)
            {
                hamstriPoeg.eatingCarrots(); 
            }

            hamstriPoeg.SumOfWeigh();

            Console.ReadLine();

        }
    }
}
