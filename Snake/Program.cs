using Snake;

Console.WriteLine("Snake by Szymi94!");
for(int i = 0; i < 18; i++)
{
    Console.Write("*");
    Console.Beep((i + 1) * 100,500);
  //    Thread.Sleep(200);
}
Thread.Sleep(1000);
Console.WriteLine();
Console.WriteLine("Enter your nickname:");
string nickname = Console.ReadLine();
Console.Clear();
int mapSize = 15;
Coordinates staringPoint = new Coordinates(5, 5);
for (int i = 0; i < mapSize; i++)
{
    for (int j = 0; j < mapSize*2; j++)
    {
        if (staringPoint.X == j && staringPoint.Y == i)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    Console.WriteLine();

}

Console.ReadKey();