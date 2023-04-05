using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x12457EE20485AFC8, NameHash = 0x79BDBA7746F3C796)]
    public class GcMaintenanceElement : NMSTemplate
    {
        /* 0x00 */ public GcMaintenanceElementGroups ItemGroupOverride;
        /* 0x04 */ public GcInventoryType Type;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public float MinRandAmount;
        /* 0x1C */ public float MaxRandAmount;
        /* 0x20 */ public int MaxCapacity;
        /* 0x24 */ public float AmountEmptyTimePeriod;
        /* 0x28 */ public bool HideWhenComplete;
        /* 0x29 */ public bool BlockDiscardWhenAllowedForParent;
        // size: 0x3
        public enum UpdateTypeEnum : uint {
            UpdatesAlways,
            UpdateOnlyWhenComplete,
            UpdateOnlyWhenNotComplete,
        }
        /* 0x2C */ public UpdateTypeEnum UpdateType;
        /* 0x30 */ public int DamagedAfterTimePeriodMin;
        /* 0x34 */ public int DamagedAfterTimePeriodMax;
        // size: 0x3
        public enum DamageStatusEnum : uint {
            Damaged,
            Repaired,
            Random,
        }
        /* 0x38 */ public DamageStatusEnum DamageStatus;
        // size: 0x9
        public enum CompletionRequirementEnum : uint {
            FullyChargedAndRepaired,
            AnyChargeAndRepaired,
            FullyRepaired,
            NotFullyCharged,
            EmptySlot,
            NoRequirement,
            UserInstalls,
            HasIngredients,
            GroupInstall,
        }
        /* 0x3C */ public CompletionRequirementEnum CompletionRequirement;
    }
}
