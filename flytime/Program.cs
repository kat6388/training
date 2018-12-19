using System;

namespace flytime
{
    class Program
    {
        static void Fly(IFlyable flyable, Point point)
        {
            Console.WriteLine(flyable.WhoAmI());
            flyable.FlyTo(point);
            Console.WriteLine(flyable.GetFlyTime());
        }
        static void Main(string[] args)
        {
            Point point = new Point(100, 200, 800);
            Bird bird = new Bird();
            Plane plane = new Plane();
            SpaceShip spaceship = new SpaceShip();
            Fly(bird, point);
            Fly(plane, point);
            Fly(spaceship, point);
           
            
        }
    }
}
