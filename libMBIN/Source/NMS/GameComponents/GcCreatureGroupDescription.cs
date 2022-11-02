namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEAADE869F546105, NameHash = 0x3F92E065272FE2A9)]
    public class GcCreatureGroupDescription : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Group;
        /* 0x10 */ public int MinGroupSize;
        /* 0x14 */ public int MaxGroupSize;
        /* 0x18 */ public float GroupsPerSquareKm;
    }
}
