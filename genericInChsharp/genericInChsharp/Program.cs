namespace genericInChsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericEg<int> g = new GenericEg<int>();
            g.Additem(1);
            g.Additem(2);
            g.Additem(3);
            g.display();
            g.Clearitem(3);
            g.display();
            g.onevalue();
            GenericEg<string> g1 = new GenericEg<string>();
            g1.Additem("salih");
            g1.Additem("mueen");
            g1.Additem("anas");
            g1.display();
            g1.Clearitem("anas");
            g1.display();
            g1.onevalue();
        }
    }
    public class GenericEg<T>//specifying a generic type in class
    {
       public List<T> list = new List<T>();
        public void Additem(T item)//specifying a generic type in parameter
        {
            list.Add(item);
        }
        public void Clearitem(T item) {
            list.Remove(item);
        }
        public void display()
        {
            foreach(T i  in list)
            {
                Console.WriteLine(i);
            }
        }
        public T onevalue()//specifying a generic type in return type
        {
            return list[0];
        }
    }
}
