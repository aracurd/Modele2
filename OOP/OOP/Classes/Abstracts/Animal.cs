namespace OOP.Classes.Abstracts
{
    //Животные, Общий класс
    public abstract class Animal : IAnimal
    {
        public virtual void See() => Move();
        
        public abstract void Eats();

        public abstract void Move();

        public virtual void ToFeed() =>Eats();

        public abstract void Bark();
    }
}
