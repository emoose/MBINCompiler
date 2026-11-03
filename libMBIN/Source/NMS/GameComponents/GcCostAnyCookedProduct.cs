namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70BFDBAE5CEB04CB, NameHash = 0x47C80238)]
    public class GcCostAnyCookedProduct : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A CostString;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A CostStringCantAfford;
        [NMS(Index = 2)]
        /* 0x40 */ public int Index;
        [NMS(Index = 4)]
        /* 0x44 */ public bool MixRandomAndBetter;
        [NMS(Index = 3)]
        /* 0x45 */ public bool PreferBetterItems;
    }
}
