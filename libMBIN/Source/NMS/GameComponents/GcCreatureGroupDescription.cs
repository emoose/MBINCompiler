namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF28FCA1E3D439CD9, NameHash = 0x3F92E065272FE2A9)]
    public class GcCreatureGroupDescription : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Group;
        /* 0x10 */ public int MinGroupSize;
        /* 0x14 */ public int MaxGroupSize;
        /* 0x18 */ public float GroupsPerSquareKm;
    }
}
