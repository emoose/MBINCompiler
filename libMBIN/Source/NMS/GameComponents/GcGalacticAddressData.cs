namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA91AE6D39D9A6AE, NameHash = 0x880E3ABD8848E698)]
    public class GcGalacticAddressData : NMSTemplate
    {
        /* 0x00 */ public int VoxelX;
        /* 0x04 */ public int VoxelY;
        /* 0x08 */ public int VoxelZ;
        /* 0x0C */ public int SolarSystemIndex;
        /* 0x10 */ public int PlanetIndex;
    }
}
