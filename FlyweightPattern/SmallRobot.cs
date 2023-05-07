namespace FlyweightPattern
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class SmallRobot : IRobot
    {
        public void Print()
        {
            Console.WriteLine("This is a small Robot");
        }
    }
}