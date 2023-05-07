namespace FlyweightPattern
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class LargeRobot : IRobot
    {
        public void Print()
        {
            Console.WriteLine("I am a large Robot");
        }
    }
}