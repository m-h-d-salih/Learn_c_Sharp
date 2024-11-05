namespace leetcode_qst_2914
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinChanges("1001"));
        }

            public static int MinChanges(string s)
            {
                int count = 0;
                for (int i = 1; i < s.Length; i += 2)
                {
                    if (s[i] != s[i - 1])
                    {
                        count++;
                    }
                }
                return count;
            }
        
    }
}
