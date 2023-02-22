using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB7A82C834E35D0C, NameHash = 0xD90787619164B12C)]
    public class GcPlayerWeaponPropertiesTable : NMSTemplate
    {
        /* 0x00 */ public GcCamouflageData CamouflageData;
        [NMS(Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0xA0 */ public GcPlayerWeaponPropertiesData[] PropertiesData;
    }
}
