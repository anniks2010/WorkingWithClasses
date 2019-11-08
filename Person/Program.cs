using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public string FirstName; ////need on omaduste nimed ning kirjutatakse suure algustähega (fields in eng)
        public string LastName;

        public void Indroduce()
        {
            Console.WriteLine($"hello, my name is {FirstName} {LastName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person isik = new Person();
            isik.FirstName = "Anu";
            isik.LastName = "Kuusik";
            isik.Indroduce();
        }
    }
}
