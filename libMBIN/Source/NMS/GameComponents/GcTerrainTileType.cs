namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0AFB195227CDEA6E2)]
    public class GcTerrainTileType : NMSTemplate
    {

		public enum TileTypeEnum { Air, Base, Rock, Mountain, Underwater, Cave, Dirt, Liquid, Substance }
		public TileTypeEnum TileType;
    }
}
