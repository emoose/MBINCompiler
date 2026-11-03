namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x759C343561D52A91, NameHash = 0xF0A61E82)]
    public class GcMissionSequenceCraftProduct : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A MessageCanCraft;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x20A MessageLearnPreReqs;
        [NMS(Index = 2)]
        /* 0x40 */ public NMSString0x20A MessageLearnRecipe;
        [NMS(Index = 1)]
        /* 0x60 */ public NMSString0x20A MessageNoIngreds;
        [NMS(Index = 12)]
        /* 0x80 */ public VariableSizeString DebugText;
        [NMS(Index = 4)]
        /* 0x90 */ public NMSString0x10 TargetProductID;
        [NMS(Index = 5)]
        /* 0xA0 */ public int TargetAmount;
        [NMS(Index = 11)]
        /* 0xA4 */ public bool CanSetIcon;
        [NMS(Index = 8)]
        /* 0xA5 */ public bool RecipeTaughtBySeasonMilestone;
        [NMS(Index = 6)]
        /* 0xA6 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 7)]
        /* 0xA7 */ public bool TakeIDFromSeasonData;
        [NMS(Index = 9)]
        /* 0xA8 */ public bool TeachIfNotKnown;
        [NMS(Index = 10)]
        /* 0xA9 */ public bool WaitForSelected;
    }
}
