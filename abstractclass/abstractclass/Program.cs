namespace abstractclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.makesound();

        }
    }
    // craeting abstract class
    public abstract class Animal
    {
        public abstract void makesound();
    }
    public class Dog:Animal //inheriting abstract class
    {
        public override void makesound() //implementing abstract method
        {
            Console.WriteLine("bow bow");
        }
    }
}
