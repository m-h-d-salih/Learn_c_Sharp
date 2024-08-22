namespace accessSpecifierEg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Eachstudent eachstd=new Eachstudent();
            Console.WriteLine(student.name);
            //Console.WriteLine(student.age);
            //Console.WriteLine(student.getAge());
            Console.WriteLine(eachstd.getAge());
            eachstd.hello("salih");
        }
    }
    public class Student
    {
        public string name = "salih";
        private int age = 22;
        public int getAge()
        {
            return age;
        }
        public void hello()
        {
            Console.WriteLine("helllo");
        }
    }
    public class Eachstudent : Student
    {
        
        public int displayage()
        {
            return getAge();
        }
        public void hello(string name)
        {
            Console.WriteLine(name);    
        }
    }
}
