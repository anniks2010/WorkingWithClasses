using System;

namespace katse2
{
    public class Person////parem klõps klassi nimele, siis Quick actions and refactoring ning siis viimane valik ning klassid liiguvad paremale eraldi aknasse
    {
        public string FirstName; ////need on omaduste nimed ning kirjutatakse suure algustähega (fields in eng)
        public string LastName;

        public void Indroduce()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName}.");
        }
    }
}
