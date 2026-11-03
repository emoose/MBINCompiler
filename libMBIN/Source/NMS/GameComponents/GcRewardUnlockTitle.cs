namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEBBD9669C503E2B6, NameHash = 0xE758333B)]
    public class GcRewardUnlockTitle : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A SeasonRewardsString;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 TitleID;
        [NMS(Index = 1)]
        /* 0x30 */ public bool NoMusic;
        [NMS(Index = 2)]
        /* 0x31 */ public bool ShowEvenIfAlreadyUnlocked;
    }
}
