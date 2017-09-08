namespace MBINCompiler.Models.Structs
{
    public class GcTeleporterType : NMSTemplate
    {
        public int TeleporterDestinationType;
        public string[] TeleporterDestinationTypeValues()
        {
            return new[] { "Base", "Spacestation", "Atlas", "PlanetAwayFromShip"};
        }
    }
}
