using System.Diagnostics;

namespace stringg;

internal class Program
{
    static void Main(string[] args)
    {
        string str = "salu mon";
        string[] str2 =str.Split(' ');
        foreach(string i in str2)
        Console.WriteLine(i);
        string str3 = str.Substring(3, 3);
        Console.WriteLine(str3);    
        bool contains=str.Contains("salu");
        Console.WriteLine(contains);
        //string interpolation
        Console.WriteLine($"hii {str}");
        Console.WriteLine($"hii {str,10}");
    }
}
