namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB3316CE08F235B9, NameHash = 0x7EF76B1B)]
    public class GcCostPoliceCargoBribe : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public int Amount;
        [NMS(Index = 0)]
        /* 0x4 */ public bool IncludeNipNip;
        [NMS(Index = 1)]
        /* 0x5 */ public bool OnlyCargoProbeInventories;
    }
}
