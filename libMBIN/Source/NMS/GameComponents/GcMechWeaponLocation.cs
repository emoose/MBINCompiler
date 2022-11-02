namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC76F3CC1DD7BEEA, NameHash = 0x87D2DB7CF99E11A4)]
    public class GcMechWeaponLocation : NMSTemplate
    {
        // size: 0x4
        public enum MechWeaponLocationEnum {
            TurretExocraft,
            TurretSentinel,
            ArmLeft,
            ArmRight
        }
        /* 0x0 */ public MechWeaponLocationEnum MechWeaponLocation;
    }
}
