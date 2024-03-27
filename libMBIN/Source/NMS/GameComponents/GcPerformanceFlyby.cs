namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5AD90024C7365E53, NameHash = 0x5384022399CAF09)]
    public class GcPerformanceFlyby : NMSTemplate
    {
        /* 0x00 */ public float Length;
        /* 0x04 */ public float Offset;
        /* 0x08 */ public bool Locked;
        /* 0x0C */ public float LockOffset;
        /* 0x10 */ public float LockTime;
        /* 0x14 */ public float LockSpeed;
    }
}
