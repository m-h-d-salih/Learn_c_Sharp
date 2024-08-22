namespace interfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Egofinterface i = new Egofinterface();
            Egofinterface1 i1 = new Egofinterface1();
            i.message();
            i1.message();
            i1.message1();
        }

         
        
    }
    //interface 
    interface IExample
    {
        void message();
    }
    interface IExample1
    {
        void message1();
    }
    // implement interface
    public class Egofinterface : IExample
    {
        public void message()
        {
            Console.WriteLine("hii salu mon");
        }
    }
    //mulltiiple inheritance via  interface 
    public class Egofinterface1 : IExample, IExample1
    {
        public void message()
        {
            Console.WriteLine("mulltiiple inheritance via  interface ");
        }
        public void message1()
        {
            Console.WriteLine("mulltiiple inheritance via  interface  ");
        }


    }
}