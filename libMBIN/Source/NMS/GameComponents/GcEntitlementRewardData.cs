namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B5BAE94DCB03B5A, NameHash = 0x748EDC86AFA4F5A3)]
    public class GcEntitlementRewardData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 EntitlementId;
        /* 0x10 */ public NMSString0x10 RewardId;
        /* 0x20 */ public NMSString0x20A Name;
        /* 0x40 */ public NMSString0x20A Error;
    }
}
