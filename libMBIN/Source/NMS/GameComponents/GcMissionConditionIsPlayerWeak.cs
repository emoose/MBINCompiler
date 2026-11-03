namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDDC2BAED59E5FD88, NameHash = 0x569C60B5)]
    public class GcMissionConditionIsPlayerWeak : NMSTemplate
    {
        // size: 0x3
        public enum ProgressTypeEnum : uint {
            ShipOrWeapon,
            Ship,
            Weapon,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ProgressTypeEnum ProgressType;
    }
}
