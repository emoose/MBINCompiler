using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34E79E36B5462BA, NameHash = 0xAB111A88D43A92B4)]
    public class GcExoMechWeaponData : NMSTemplate
    {
        /* 0x00 */ public List<GcMechWeaponLocation> LocationPriority;
        /* 0x10 */ public float MaintainFireLocationMinTime;
        [NMS(Size = 0x4, EnumType = typeof(GcMechWeaponLocation.MechWeaponLocationEnum))]
        /* 0x18 */ public NMSString0x10[] MuzzleFlashDataID;
        /* 0x58 */ public float AngleToleranceForArmAiming;
        /* 0x5C */ public float CooldownTimeMin;
        /* 0x60 */ public float CooldownTimeMax;
        /* 0x64 */ public float SelectionWeight;
        /* 0x68 */ public float MinRange;
        /* 0x6C */ public float MaxRange;
        /* 0x70 */ public float AttackAngle;
    }
}
