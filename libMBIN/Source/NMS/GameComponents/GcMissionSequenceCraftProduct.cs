namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3A927AFE0D717C5, NameHash = 0xE4A60FB879FE42CD)]
    public class GcMissionSequenceCraftProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A MessageCanCraft;
        /* 0x20 */ public NMSString0x20A MessageNoIngreds;
        /* 0x40 */ public NMSString0x20A MessageLearnRecipe;
        /* 0x60 */ public NMSString0x20A MessageLearnPreReqs;
        /* 0x80 */ public NMSString0x10 TargetProductID;
        /* 0x90 */ public int TargetAmount;
        /* 0x94 */ public bool TakeAmountFromSeasonData;
        /* 0x95 */ public bool TakeIDFromSeasonData;
        /* 0x96 */ public bool WaitForSelected;
        /* 0x97 */ public bool CanSetIcon;
        /* 0x98 */ public NMSString0x80 DebugText;
    }
}
