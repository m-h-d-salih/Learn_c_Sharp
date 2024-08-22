namespace delegatesInCSharp
{
    internal class Program
    {
    delegate void Mydelegate(string name);//creating delegate
        
        static void Main(string[] args)
        {
            Mydelegate del = new Mydelegate(Displaymessage);
            //Mydelegate del = Displaymessage;
            del("salih");
            //multicaset delegate 
            del += Displayhello;
            del("salu mon");
        }
        public static void Displaymessage(string name)
        {
            Console.WriteLine($"hii {name}");
        }
        public static void Displayhello(string name)
        {
            Console.WriteLine($"hii {name}");
        }
    }

    
}
