namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x14894ADD26CACFA4, NameHash = 0x6EB055C3)]
    public class GcCreatureGroupDescription : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Group;
        [NMS(Index = 3)]
        /* 0x10 */ public float GroupsPerSquareKm;
        [NMS(Index = 2)]
        /* 0x14 */ public int MaxGroupSize;
        [NMS(Index = 1)]
        /* 0x18 */ public int MinGroupSize;
    }
}
