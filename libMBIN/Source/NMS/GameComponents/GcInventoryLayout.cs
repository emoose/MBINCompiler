namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3D242E65CBE3D3D, NameHash = 0x817FD3EB)]
    public class GcInventoryLayout : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcSeed Seed;
        [NMS(Index = 2)]
        /* 0x10 */ public int Level;
        [NMS(Index = 0)]
        /* 0x14 */ public int Slots;
    }
}
