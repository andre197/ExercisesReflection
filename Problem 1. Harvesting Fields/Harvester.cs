public class Harvester
{
    public string Harvest(IHarvestingStrategy strategy)
    {

        return null;
    }
    public string GiveCommand(Commands command)
    {
        string str;

        switch (command)
        {
            case Commands.Private:
                str = Harvest(new PrivateHarvest());
                return str;
            case Commands.Public:
                str = Harvest(new PublicHarvest());
                return str;
            case Commands.Protected:
                str = Harvest(new ProtectedHarvest());
                return str;
            case Commands.All:
                str = Harvest(new HarvestAll());
                return str;
            default:
                return null;
        }
    }
}

