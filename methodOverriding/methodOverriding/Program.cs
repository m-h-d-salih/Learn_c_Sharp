namespace methodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dog dog = new Dog();
            Cat cat = new Cat();
            dog.speak();
            cat.speak();
            Console.WriteLine(dog.ToString());
        }
    }
    public class Animal
    {
        public virtual void speak()
        {
            Console.WriteLine("brrr");
        }
    }
    public class Dog:Animal
    {
        public override void speak()
        {
            Console.WriteLine("bow bow");
        }
        public override string ToString()
        {
            return "dog kurachu  bow bow bow";
        }

    }
    public class Cat : Animal
    {
        public override void speak()
        {
            Console.WriteLine("meow meow");
        }
    }
}
