namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x67C14B3B9661443F, NameHash = 0x1B69E5D9C1463621)]
    public class GcMissionConditionIsPlayerWeak : NMSTemplate
    {
        // size: 0x3
        public enum ProgressTypeEnum {
            ShipOrWeapon,
            Ship,
            Weapon,
        }
        /* 0x0 */ public ProgressTypeEnum ProgressType;
    }
}
