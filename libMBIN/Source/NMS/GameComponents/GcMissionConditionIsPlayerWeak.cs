namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E18159DA19C16C, NameHash = 0x1B69E5D9C1463621)]
    public class GcMissionConditionIsPlayerWeak : NMSTemplate
    {
        // size: 0x3
        public enum ProgressTypeEnum {
            ShipOrWeapon,
            Ship,
            Weapon
        }
        /* 0x0 */ public ProgressTypeEnum ProgressType;
    }
}
