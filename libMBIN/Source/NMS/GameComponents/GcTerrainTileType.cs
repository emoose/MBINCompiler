namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6793437805F634B, NameHash = 0xB5C79582)]
    public class GcTerrainTileType : NMSTemplate
    {
        // size: 0x9
        public enum TileTypeEnum : uint {
            Air,
            Base,
            Rock,
            Mountain,
            Underwater,
            Cave,
            Dirt,
            Liquid,
            Substance,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TileTypeEnum TileType;
    }
}
