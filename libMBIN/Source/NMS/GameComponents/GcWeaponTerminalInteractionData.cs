namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x932A72F34878DEC8, NameHash = 0x2F117A2)]
    public class GcWeaponTerminalInteractionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int RespawnPeriodInSeconds;
        [NMS(Index = 1)]
        /* 0x4 */ public bool UseSentinelWeapon;
    }
}
