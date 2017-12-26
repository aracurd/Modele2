using System;
using OOP.Classes.Abstracts;

namespace OOP.Classes
{
    public class Predators : Mammals
    {
        public override void Bark()
        {
            Console.WriteLine("Рык");
        }

        public override void Eats() { 
            Console.WriteLine("Ест мясо");
        }

        public override void Move(){
            Console.WriteLine("Ходит по клетке");

        }

    }
}
