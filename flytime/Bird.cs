using System;

namespace flytime
{
    class Bird : IFlyable
    {
        private Point _previousPoint;
        private Point _currentPoint;
        public string WhoAmI()
        {
            return nameof(Bird);
        }

        public double GetFlyTime()
        {
            double distance = Point.Distance(_previousPoint,_currentPoint);
            Random rnd = new Random();
            int speed = rnd.Next(0,20);
            double time = distance / speed;
            return time;
        }

        public void FlyTo(Point newPoint)
        {
            _previousPoint = _currentPoint;
            _currentPoint = newPoint;
        }
    }
}
