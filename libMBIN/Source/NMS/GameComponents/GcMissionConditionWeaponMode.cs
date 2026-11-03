using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE59C34DE7D133074, NameHash = 0x9FF55E4C)]
    public class GcMissionConditionWeaponMode : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcPlayerWeapons WeaponMode;
    }
}
