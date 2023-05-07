namespace FlyweightPattern
{
    class Robot : IRobot
    {
        String robotType;
        public String colorOfRobot;
        public Robot(String robotType)
        {
            this.robotType = robotType;
        }
        public void SetColor(String colorOfRobot)
        {
            this.colorOfRobot = colorOfRobot;
        }
        public void Print()
        {
            Console.WriteLine("This is a" + robotType + "type robot with" + colorOfRobot + "color");
        }
    }
}