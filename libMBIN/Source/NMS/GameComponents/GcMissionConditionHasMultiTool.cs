using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A0A16C07A31883, NameHash = 0xF65D2CFF75A05B47)]
    public class GcMissionConditionHasMultiTool : NMSTemplate
    {
        /* 0x0 */ public GcInventoryClass InventoryClass;
        /* 0x4 */ public bool CheckAllTools;
        /* 0x5 */ public bool BetterClassMatches;
        /* 0x6 */ public bool TakeValueFromSeasonData;
        /* 0x7 */ public bool MustMatchWeaponClass;
        /* 0x8 */ public GcWeaponClasses WeaponClass;
    }
}
