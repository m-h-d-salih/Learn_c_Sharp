namespace exceptionhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers:");
            int a=Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            try { 
                 result = a / b;
                Console.WriteLine(result);

            }
            catch (Exception e)
            {
                Console.WriteLine("error enter correctly"+e);
            }
            finally
            {
                Console.WriteLine("thanks!");


            }
        }
    }
}
