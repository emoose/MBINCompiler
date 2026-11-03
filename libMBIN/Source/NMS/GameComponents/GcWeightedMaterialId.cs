namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7715A100DF4BD364, NameHash = 0x8725EEC4)]
    public class GcWeightedMaterialId : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A DecorationId;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A Id;
        [NMS(Index = 0)]
        /* 0x40 */ public float RelativeProbability;
    }
}
