using System;

namespace katse2
{

    class Program
    {
        static void Main(string[] args)
        {
            Person isik = new Person();
            isik.FirstName = "Anu";
            isik.LastName = "Kuusik";
            isik.Indroduce();

            Console.ReadLine();
        }
    }
}
