namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("salu");
            list.Add("mueen");
            display(list);
            list.Remove("mueen");
            display(list);
        }
        static void display(List<string> list)
        {

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
