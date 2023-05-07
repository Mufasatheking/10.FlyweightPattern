namespace FlyweightPattern
{
    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    class RobotFactory
    {
        Dictionary<string, IRobot> shapes = new Dictionary<string, IRobot>();
        public int TotalObjectsCreated()
        {
            return shapes.Count;
        }
        public IRobot GetRobotFromFactory(String robotType)
        {
            IRobot robotCategory = null;
            if (shapes.ContainsKey(robotType))
            {
                robotCategory = shapes[robotType];
            }
            else
            {
                switch (robotType)
                {
                    case "Small":
                        Console.WriteLine("We do not have Small Robot at present. So we are creating a Small Robot now.");
                        robotCategory = new Robot("Small");
                        shapes.Add("Small", robotCategory);
                        break;
                    case "Large":
                        Console.WriteLine("We do not have Large Robot at present. So we are creating a Large Robot now.");
                        robotCategory = new Robot("Large");
                        shapes.Add("Large", robotCategory);
                        break;
                    default:
                        throw new Exception("Robot Factory can create only king and queen type robots");
                }
            }
            return robotCategory;
        }
    }
}