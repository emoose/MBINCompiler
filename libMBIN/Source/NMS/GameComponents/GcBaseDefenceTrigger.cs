namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCBDA352215D0A296, NameHash = 0x295BE0CF9BD70B66)]
    public class GcBaseDefenceTrigger : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PerceptionId;
        /* 0x10 */ public bool ActiveWhenIdle;
        /* 0x11 */ public bool ActiveWhenTargetAcquired;
        /* 0x12 */ public bool ActiveWhenSearching;
        /* 0x18 */ public NMSString0x10 LaserEffectId;
    }
}
