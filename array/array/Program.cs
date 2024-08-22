namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            string s = "hii";
            Console.WriteLine(s);
            String[] cars = {"bugatti","pagani","bmw"};
            Console.WriteLine(cars);
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(sum(10, 667));
            Console.WriteLine(sum(10, 667,98));
            int[,] table = {
               { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
               };
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(0); j++)
                {
                    Console.WriteLine(table[i, j]);
                }
            }

        }
        static int sum(int a,int b)
        {
            return a + b;
        }
        static int sum(int a, int b, int c) { 
            return a + b + c;
        }
        static void display(int[] arr)
        {
            foreach(int item in arr) Console.WriteLine(item);
        }
    }
}
