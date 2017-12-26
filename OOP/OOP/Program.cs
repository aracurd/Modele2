using System;
using OOP.Classes;
using static System.Console;

namespace OOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteLine("Какое животное хотите посмотреть?");
            WriteLine("Представлены :\n Тигр - 1, Верблюд - 2, Волк - 3, Жаворонок - 4");
            var value = int.Parse(ReadLine());
            var animal = Exemplar(value);
            animal.ToFeed();
            ReadKey();
            animal.See();
            ReadKey();
        }

        public static IAnimal Exemplar (int val){
            switch(val){
                case 1: return new Predators();
                case 2: return new Primates();
                case 3: return new Predators();
                case 4: return new FloatingBirds();
                default: return new Predators();
            }
        }


    }
}
