namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x67E29535EDBA5362, NameHash = 0x1C22335EC8C3634C)]
    public class GcCostStat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Stat;
        /* 0x10 */ public NMSString0x10 StatGroup;
        /* 0x20 */ public int Value;
        /* 0x28 */ public NMSString0x20A CostAsString;
    }
}
