namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA1F78101BF1DC01A, NameHash = 0x6247F06C43E3ADDD)]
    public class GcTerrainTileType : NMSTemplate
    {
        // size: 0x9
        public enum TileTypeEnum {
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
        /* 0x0 */ public TileTypeEnum TileType;
    }
}
