namespace hashsetAndListandEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> ha = new HashSet<int>();
            ha.Add(1);
            ha.Add(2);
            ha.Add(3);
            int[] a = new int[3] { 1, 2, 3 };
            //a[-1] = 4;
            //Console.WriteLine(a[-1]);
            foreach (var item in ha)
            {
                Console.WriteLine(item);
            }
            ha.Remove(1);
            foreach (var item in ha)
            {
                Console.WriteLine(item);
            }
        }
    }
}
