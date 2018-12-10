using System;

namespace flytime
{
    class SpaceShip : IFlyable
    {
        private Point _previousPoint;
        private Point _currentPoint;
        public string WhoAmI()
        {
            return (nameof(SpaceShip));
        }
        public void FlyTo(Point newPoint)
        {
            _previousPoint = _currentPoint;
            _currentPoint = newPoint;
        }
        public double GetFlyTime()
        {
            double distance = Point.Distance(_previousPoint, _currentPoint);
            int speed = 8000;
            double time = distance / speed;
            return time;
        }
    }
}