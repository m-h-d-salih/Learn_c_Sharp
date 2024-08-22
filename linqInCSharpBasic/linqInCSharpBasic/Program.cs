using System.Runtime.InteropServices;

namespace linqInCSharpBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3, 4, 1, 2, 5,6 };
            var evenumbers = from num in list
                             where num % 2 == 0
                             select num;
            foreach(var num in evenumbers)
            {
                Console.WriteLine(num); 
            }
            //int a = 10;
            //double b = 20;\
            //int c  =Convert.ToInt32(a + b);
            //Console.WriteLine(a + b);
            //using parse
            string numberstr = "123";
            int number = int.Parse(numberstr);
            Console.WriteLine(number);
            // using tryparse
            string sttr = "12cd";
            bool result=int.TryParse(sttr, out int numb);
            Console.WriteLine(result? numb : null);
            var  ascend=from num in list
                        orderby num ascending
                        select num;
            foreach (var num in ascend)
            {
                Console.WriteLine(num);
            }
            //bool tr = false;
            //Console.WriteLine(tr);
            Dictionary<int,string> dict = new Dictionary<int, string>() ;
            dict.Add(1, "salih");
            foreach (var num in dict)
            {
                Console.WriteLine(num);
            }
            foreach (char s in dict[1])
            {
                Console.WriteLine(s);
            }
            //var dictOfLists = new Dictionary<string, List<int>>();

            var dic =new Dictionary<int,List<int>>() ;
            dic[1]=new List<int>() { 1,2,3};
            dic[1] = new List<int>() { 1, 2, 3 };
            dic[1] = new List<int>() { 1, 2, 3 };
            Console.WriteLine("dictionary of list");
            foreach(var num in dic)
            {
                Console.WriteLine("key :{0}",num.Key);
               
            }
            var re = from num in dic
                     where num.Key == 1
                     select num;
            Console.WriteLine(re.GetType());
            //foreach (var num in re)
            //{
            //    foreach (var num2 in num.Value)
            //    {
            //        Console.WriteLine(num2);
            //    }
            //}

            Console.ReadKey();
            
        }
        
    }
}
