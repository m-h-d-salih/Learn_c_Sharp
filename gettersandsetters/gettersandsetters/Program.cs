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
    }
}
