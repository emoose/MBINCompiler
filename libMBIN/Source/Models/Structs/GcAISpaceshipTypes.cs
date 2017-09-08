namespace libMBIN.Models.Structs
{
    public class GcAISpaceshipTypes : NMSTemplate
    {
        public int ShipType;
        public string[] ShipTypeValues()
        {
            return new[] { "None", "Pirate", "Police", "Trader", "Freighter" };
        }
    }
}
