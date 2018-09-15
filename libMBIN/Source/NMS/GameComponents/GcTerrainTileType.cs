using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAFB195227CDEA6E2)]
    public class GcTerrainTileType : NMSTemplate
    {

		public enum TileTypeEnum { Air, Base, Rock, Mountain, Underwater, Cave, Dirt, Liquid, Substance }
		public TileTypeEnum TileType;
    }
}
