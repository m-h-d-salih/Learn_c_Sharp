using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndObjects
{
    public class Human
    {
       public Human() {
            Console.WriteLine("welcome new user");
        
        }
        public string name;
        public int age;
        public void hello()
        {
            Console.WriteLine($"hello {name} you are {age} old");
        }
        public void bye()
        {
            Console.WriteLine($"bye {name}");
        }
        public void thanks()
        {
            Console.WriteLine($"thanks {name} ");
        }
    }
}
