namespace structInCsharp
{
    internal class Program
    {
        struct Student
        {
            public string name;
            public int mark;
            public void display()
            {
                Console.WriteLine($"name {name} mark {mark}");
            }
        }
        struct Employee
        {
            public string name;
            public int id;
            public Employee(string name, int id)
            {
                this.name = name;   
                this.id = id;
            }
            public void greet()
            {
                Console.WriteLine($"hii {name} ur id is {id}");
            }
        }
        static void Main(string[] args)
        {
            Student s1;
            s1.name = "salih";
            s1.mark = 100;
            s1.display();
            Employee employee = new Employee("salih",22);
            employee.greet();
        }
    }
}
