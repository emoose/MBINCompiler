using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8594081DF97DC91F, NameHash = 0xDC4801D)]
    public class GcUnlockableItemTree : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcUnlockableItemTreeNode Root;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A Title;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x10 CostTypeID;
        [NMS(Index = 2)]
        /* 0x50 */ public bool UseNarrowGaps;
    }
}
