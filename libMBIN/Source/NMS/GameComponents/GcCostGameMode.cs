using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F65B01044A4F831, NameHash = 0x524F0ABF)]
    public class GcCostGameMode : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A CostStringCantAfford;
        [NMS(Index = 1)]
        /* 0x20 */ public GcGameMode Mode;
        [NMS(Index = 3)]
        /* 0x24 */ public int SpecificSeasonIndex;
        [NMS(Index = 0)]
        /* 0x28 */ public bool InvertMode;
    }
}
