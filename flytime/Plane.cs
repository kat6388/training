using System;

namespace flytime
{
    class Plane : IFlyable
    {
        private Point _previousPoint;
        private Point _currentPoint;
        public string WhoAmI()
        {
            return nameof(Plane);
        }
        public void FlyTo(Point newPoint)
        {
            _previousPoint = _currentPoint;
            _currentPoint = newPoint;
        }
        public double GetFlyTime()
        {
            double time = 0;
            double distance = Point.Distance(_previousPoint, _currentPoint);
            int speed = 200;
            double lastDistance = distance % 10;
            double iterations = Math.Ceiling((distance/10));


            for (int i = 0; i < iterations; i++)
            {
                if (i < iterations - 1)
                {
                    time += 10 / (speed + 10 * i);
                }

                if (i == iterations -1)
                {
                    time += lastDistance / (speed + 10 * i);
                }
            }            
            return time;
        }
    }
}
