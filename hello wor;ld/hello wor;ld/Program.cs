namespace hello_wor_ld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int month = rnd.Next(1, 13);  // creates a number between 1 and 12
            int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
            int card = rnd.Next(52);     // creates a number between 0 and 51
            Console.WriteLine(value: card);
        }
    }
}
