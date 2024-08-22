namespace leetcodeSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TruncateSentence("Hello how are you Contestant", 4));
            string text = "applebanancherry";
            //string[] fruits = text.Split(' ');
            //foreach (string fruit in fruits )
            //{
            //    Console.WriteLine( fruit );
            //}
            int result = NumberOfSteps(8);
            Console.WriteLine(result); 
        }

        //leet code qst :1816. Truncate Sentence
        public static string TruncateSentence(string s, int k)
        {
            string result = "";
            string[] str = s.Split(' ');
            for (int i = 0; i < k; i++)
            {
                
                result += str[i]+" ";
            }
            return result.TrimEnd();
        }
        //1342. Number of Steps to Reduce a Number to Zero
        public static int NumberOfSteps(int num)
        {
            int step = 0;
            while (num > 0)
            { 
            if(num % 2 == 0)
                {
                    num /=  2;
                }
                else
                {
                   num-= 1;
                }
                
             step++;
            }

            return step;
        }
    }
}
