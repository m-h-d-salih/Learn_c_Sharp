namespace jaggedarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jagged array
            int[][] arr =new int[3][];
            arr[0]=new int[] {1,2,3};
            arr[1] = new int[] { 1, 3 };
            arr[2] = new int[] { 1, 2, 3, 40 };
            //Console.WriteLine(arr.Length);
            arr[1][1] = 7;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
            }
            //jagges array with multidiamensional
            int[][,] arr2 =
            {
                new int[][,]{{1,2,30},{1,2,3}}
            }
        }
    }
}
