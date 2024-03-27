namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4290FF761007EBBA, NameHash = 0x5EB3ADA9F4E70000)]
    public class GcRewardShipSlot : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Cost;
        /* 0x10 */ public bool AwardCostAndOpenWindow;
        /* 0x14 */ public int NumTokens;
        /* 0x18 */ public bool IsAlien;
        /* 0x19 */ public bool FallbackOpenWindowIfBlocked;
    }
}
