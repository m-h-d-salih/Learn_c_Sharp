namespace classAndObjects
{
     class Program
    {
        static void Main(string[] args)
        {
            //accessing properties of another class using classname
            Messages.hello();
            Messages.thanks();
            Messages.bye();
            //creating object
            Human human = new Human();
           
            //accesiing properties of class usig object 
            human.name = "salih";  
            human.age = 22;
            human.hello();
            human.thanks();
            human.bye();
            //contsructor using parameter
            Humanconstuctor hm = new Humanconstuctor("SALIH", 22);
            //clonstructor overload example
            Humanconstuctor hm1 = new Humanconstuctor("SALIH");
            hm.greet();
            //inheritance
                Car car = new Car();
            car.go();
            Newcar newcar = new Newcar("mustang");
            newcar.go();
            // Array of objects

            Newcar[] garrage = new Newcar[3];
            Newcar car1 = new Newcar("mclaren");
            Newcar car2 = new Newcar("hummer");
            Newcar car3 = new Newcar("bugatti");
            garrage[0] = car1;
            garrage[1] = car2;
            garrage[2] = car3;
            foreach (Newcar carname in garrage)
            {
                Console.WriteLine(carname.modal);
            }
            // Array of objects using anonymous objects
            Newcar[] garrage1 = { new Newcar("lamborghin"), new Newcar("ferrri"), new Newcar("pagani") };
            foreach(Newcar nameofcar in garrage1)
            {
                Console.WriteLine(nameofcar.modal);
            }
            //object as parameter
            changecolor(garrage1[0], "koenigsegg");
            Console.WriteLine(garrage1[0].modal);
            Newcar pagani = copycar(garrage1[1]);
            Console.WriteLine(pagani.modal);
        }
        public static void changecolor(Newcar car,string modalname)
        {
            car.modal = modalname;
        }
        public static Newcar copycar(Newcar car)
        {
            return new Newcar(car.modal);
        }
    }
}
