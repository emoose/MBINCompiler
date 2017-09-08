namespace libMBIN.Models.Structs
{
    public class GcCostInstalledTech : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
		
        public int InvetoryToCheck;
        public string[] InventoryToCheckValues()
        {
            return new[] { "All", "Suit", "Ship", "Weapon", "Freighter", "Buggy" };
        }
    }
}
