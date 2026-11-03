namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6729EA76D468C6AB, NameHash = 0xE7723C85)]
    public class GcBuildingOverrideData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 0)]
        /* 0x10 */ public GcSeed Seed;
        [NMS(Index = 2)]
        /* 0x20 */ public int Index;
    }
}
