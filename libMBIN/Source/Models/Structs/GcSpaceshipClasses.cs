namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0BAADE8803679AD54)]
    public class GcSpaceshipClasses : NMSTemplate
    {
		public enum ShipClassEnum { Freighter, Dropship, Fighter, Scientific, Shuttle, PlayerFreighter, Royal }
		public ShipClassEnum ShipClass;
    }
}
