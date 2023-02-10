namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x841F2F6F53DF8FDD, NameHash = 0xF404ECE05A6AC5B7)]
    public class GcSentinelMechWeaponMode : NMSTemplate
    {
        // size: 0x3
        public enum SentinelMechWeaponModeEnum {
            Gun,
            Canon,
            Flamethrower,
        }
        /* 0x0 */ public SentinelMechWeaponModeEnum SentinelMechWeaponMode;
    }
}
