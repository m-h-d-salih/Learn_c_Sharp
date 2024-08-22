using System.Security.Cryptography.X509Certificates;

namespace enumeg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Days.monday);
            
        }
    }
    public enum Days:short
    {
        sunday=12,
        monday

    }
}
