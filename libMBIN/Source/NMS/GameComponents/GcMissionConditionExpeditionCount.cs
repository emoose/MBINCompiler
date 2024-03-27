using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x23379BA5EFBE3535, NameHash = 0xA4E47B76AADB4816)]
    public class GcMissionConditionExpeditionCount : NMSTemplate
    {
        /* 0x0 */ public int ExpeditionCount;
        /* 0x4 */ public bool OnlyCountIfActive;
        /* 0x5 */ public bool OnlyCountIfActiveWithRemainingEvents;
        /* 0x6 */ public bool OnlyCountIfFueled;
        /* 0x7 */ public bool OnlyCountAwaitingDebrief;
        /* 0x8 */ public bool ActiveExpeditionsCountAsFueled;
        /* 0xC */ public TkEqualityEnum Test;
    }
}
