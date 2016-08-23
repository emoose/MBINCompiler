namespace MBINCompiler.Models.Structs
{
    public class GcInteractionType : NMSTemplate
    {
        public int InteractionType;
        public string[] InteractionTypeValues()
        {
            return new[]
            {
                "None", "Shop", "NPC", "NPC_Secondary", "NPC_Anomaly", "NPC_Anomaly_Secondary", "Ship", "Outpost",
                "SpaceStation", "RadioTower", "Monolith", "Factory", "AbandonedShip", "Harvester", "Observatory", "TradingPost",
                "DistressBeacon", "Portal", "Plaque", "AtlasStation", "AbandonedBuildings", "WeaponTerminal", "SuitTerminal", "SignalScanner"
            };
        }
    }
}
