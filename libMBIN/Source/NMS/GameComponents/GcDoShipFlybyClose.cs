namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA50D9C0311420779, NameHash = 0xBFC05C7B)]
    public class GcDoShipFlybyClose : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float LockOffset;
        [NMS(Index = 2)]
        /* 0x4 */ public float LockSpread;
        [NMS(Index = 1)]
        /* 0x8 */ public float LockTime;
        [NMS(Index = 4)]
        /* 0xC */ public bool HailingBehaviour;
        [NMS(Index = 3)]
        /* 0xD */ public bool StayCloseAtLowSpeed;
    }
}
