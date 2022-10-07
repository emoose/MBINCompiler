namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47B106C27F5CF01A, NameHash = 0xAC19C9A74178EED8)]
    public class GcRewardUnlockTitle : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TitleID;
        /* 0x10 */ public bool NoMusic;
        /* 0x11 */ public bool ShowEvenIfAlreadyUnlocked;
    }
}
