using System;
using OOP.Classes.Abstracts;

namespace OOP.Classes
{
    public class FloatingBirds : Birds
    {
        public override void Bark()
        {
            Console.WriteLine("Курлык");
        }

        public override void Eats()
        {
            Console.WriteLine("Поглощает пищу :)");
        }

        public override void Move()
        {
            Console.WriteLine("Летает по клетке");
        }
    }
}
