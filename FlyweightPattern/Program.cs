using FlyweightPattern;

RobotFactory myfactory = new RobotFactory();
Console.WriteLine("\n***Flyweight Pattern Example Modified***\n");
Robot shape;
/*Here we are trying to get 3 Small type robots*/
for (int i = 0; i < 3; i++)
{
    shape = (Robot)myfactory.GetRobotFromFactory("Small");
    /*Not required to add sleep(). But it is included to
     increase the probability of getting a new random number
     to see the variations in the output.*/
    Thread.Sleep(1000);
    shape.SetColor(getRandomColor());
    shape.Print();
}
/*Here we are trying to get 3 Large type robots*/
for (int i = 0; i < 3; i++)
{shape = (Robot)myfactory.GetRobotFromFactory("Large");
    /*Not required to add sleep().But it is included to
     increase the probability of getting a new random number
     to see the variations in the output.*/
    Thread.Sleep(1000);
    shape.SetColor(getRandomColor());
    shape.Print();
}
int NumOfDistinctRobots = myfactory.TotalObjectsCreated();
//System.out.println("\nDistinct Robot objects created till now= "+ NumOfDistinctRobots);        
Console.WriteLine("\n Finally no of Distinct Robot objects created: " + NumOfDistinctRobots);
Console.ReadKey();

static string getRandomColor()
{
    Random r = new Random();
    /*You can supply any number of your choice in nextInt argument.
     * we are simply checking the random number generated is an * even number or an odd number. And based on that we are * choosing the color. For simplicity, we'll use only two * color-red and green
     */
    int random = r.Next(100);
    if (random % 2 == 0)
    {
        return "red";
    }
    else
    {
        return "green";
    }
}