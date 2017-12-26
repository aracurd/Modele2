using System;
using OOP.Classes.Abstracts;

namespace OOP.Classes
{
    public class Primates : Mammals
    {
        public override void Bark()
        {
            Console.WriteLine("gav gav");
        }

        public override void Eats()
        {
            Console.WriteLine("Ест зерно");

        }

        public override void Move(){
            Console.WriteLine("In move");
        }


    }
}
