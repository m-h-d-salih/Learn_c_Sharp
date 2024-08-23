namespace gettersandsetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(100);
            Console.WriteLine(car.Speed);
            car.Speed = 100000;
            Console.WriteLine(car.Speed);
            //auto implementaion
            Car car1 = new Car("hummer");
            Console.WriteLine(car1.Model);
            car1.Model = "mclaren";
            Console.WriteLine(car1.Model);
        }
    }
    public class Car
    {
        private int speed;
        public Car(int speed)
        {
            this.speed = speed;
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 3000)

                    speed = 300;
                else
                    speed = value;
            }
        }
        public string Model { get; set; }//auto implementaion => mainly used in if there is no logic required
        public Car(string model)
        {
            this.Model = model;
        }
       
    }
}
