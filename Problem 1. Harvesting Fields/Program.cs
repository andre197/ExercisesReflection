using System;

public class Program
{
    public static void Main(string[] args)
    {
        Harvester harvester = new Harvester();
        while (true)
        {
            Commands command = (Commands)Enum.Parse(typeof(Commands), Console.ReadLine());
            if (command == Commands.Harvest)
            {
                break;
            }
            Console.WriteLine(harvester.GiveCommand(command));
        }
    }
}

