namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA1B26031BC56E03, NameHash = 0x5923C0EE4B9AD427)]
    public class GcCostTableEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public bool DisplayCost;
        /* 0x11 */ public bool DontCharge;
        /* 0x12 */ public bool HideOptionAndDisplayCostOnly;
        /* 0x13 */ public bool DisplayOnlyCostIfCantAfford;
        /* 0x14 */ public bool HideCostStringIfCanAfford;
        /* 0x15 */ public bool RemoveOptionIfCantAfford;
        /* 0x16 */ public bool InvertCanAffordOutcome;
        /* 0x17 */ public bool MustAffordInCreative;
        /* 0x18 */ public bool UseCommunityContributionCap;
        /* 0x20 */ public NMSString0x20A CannotAffordOSDMsg;
        /* 0x40 */ public NMSString0x10 MissionMessageWhenCharged;
        /* 0x50 */ public NMSTemplate Cost;
    }
}
