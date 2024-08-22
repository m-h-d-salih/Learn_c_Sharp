using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace classAndObjects
{
    public class Humanconstuctor
    {
        string name;
        //constructor creation
        public Humanconstuctor(string name,int age) {
            this.name = name;
            Console.WriteLine($"hii {name} u are {age} old ");
        
        }
        //constructor overload
        public Humanconstuctor(string name)
        {
            Console.WriteLine($"hii {name}");
        }
        public void greet()
        {
            Console.WriteLine(name);
        }
    }
}
