namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD7032701D01C6513, NameHash = 0xBDED8073)]
    public class TkNavMeshFlockingParams : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public float InfluenceRange;
        [NMS(Index = 3)]
        /* 0x04 */ public float LookAheadTime;
        [NMS(Index = 5)]
        /* 0x08 */ public float Spacing;
        [NMS(Index = 0)]
        /* 0x0C */ public float WeightAlignment;
        [NMS(Index = 2)]
        /* 0x10 */ public float WeightCoherence;
        [NMS(Index = 1)]
        /* 0x14 */ public float WeightSeparation;
    }
}
