

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name!");
            String? name=Console.ReadLine();
            Console.WriteLine(name);
            for (int i = 0; i < 10; i++) { 
            Console.WriteLine(i);
            }
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Length);

        }
    }
}
