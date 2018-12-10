namespace flytime
{
    public interface IFlyable
    {
        void FlyTo(Point point);
        string WhoAmI();
        double GetFlyTime();
    }
}
