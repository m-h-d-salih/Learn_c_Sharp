namespace threadinCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread=Thread.CurrentThread;
            //Thread thread1 = new Thread(countup);
            Thread thread2 = new Thread(countup);
            Thread thread1 = new Thread(()=>countdown("counter down"));//suppose we need to pass parameter
            thread.Name = "main thread";
            //countup();
            //countdown();
            thread1.Start();
            thread2.Start();
            Console.WriteLine($"{thread.Name} completed");
        }
        public static void countup()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"counter up {i} seconds");
                Thread.Sleep(1000);
            }
        }
        public static void countdown(string countername)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{countername} {i} seconds");
                Thread.Sleep(1000);
            }
        }
    }
}
