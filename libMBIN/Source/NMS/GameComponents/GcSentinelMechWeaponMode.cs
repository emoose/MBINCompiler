namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x577079D245229A35, NameHash = 0xF404ECE05A6AC5B7)]
    public class GcSentinelMechWeaponMode : NMSTemplate
    {
        // size: 0x3
        public enum SentinelMechWeaponModeEnum {
            Gun,
            Canon,
            Flamethrower
        }
        /* 0x0 */ public SentinelMechWeaponModeEnum SentinelMechWeaponMode;
    }
}
