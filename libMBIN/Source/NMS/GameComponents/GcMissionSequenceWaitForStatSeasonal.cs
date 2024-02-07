namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AF7D1782CC7092D, NameHash = 0xCEBA3C32BCAF04F6)]
    public class GcMissionSequenceWaitForStatSeasonal : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x10 Stat;
        /* 0x90 */ public NMSString0x10 StatGroup;
        /* 0xA0 */ public int Amount;
        /* 0xA4 */ public bool TakeAmountFromSeasonalData;
        /* 0xA5 */ public bool EncouragesFighting;
        /* 0xA6 */ public NMSString0x80 DebugText;
    }
}
