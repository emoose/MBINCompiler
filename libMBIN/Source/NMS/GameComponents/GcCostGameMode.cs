using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95757206A198C, NameHash = 0x5BD84E5380495165)]
    public class GcCostGameMode : NMSTemplate
    {
        /* 0x0 */ public bool InvertMode;
        /* 0x4 */ public GcGameMode Mode;
        /* 0x8 */ public NMSString0x20A CostStringCantAfford;
    }
}
