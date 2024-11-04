namespace leetcode2180
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountEven(30));
        }
        public static int CountEven(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                string arr = i.ToString();
                int sum = 0;
                foreach (char item in arr)
                {
                    sum += int.Parse(item.ToString());
                }
                if (sum % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
        
}
