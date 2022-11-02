using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x364A34A0E77652B0, NameHash = 0x79BDBA7746F3C796)]
    public class GcMaintenanceElement : NMSTemplate
    {
        /* 0x00 */ public GcMaintenanceElementGroups ItemGroupOverride;
        /* 0x04 */ public GcInventoryType Type;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public float MinRandAmount;
        /* 0x1C */ public float MaxRandAmount;
        /* 0x20 */ public int MaxCapacity;
        /* 0x24 */ public float AmountEmptyTimePeriod;
        // size: 0x3
        public enum UpdateTypeEnum {
            UpdatesAlways,
            UpdateOnlyWhenComplete,
            UpdateOnlyWhenNotComplete
        }
        /* 0x28 */ public UpdateTypeEnum UpdateType;
        /* 0x2C */ public int DamagedAfterTimePeriodMin;
        /* 0x30 */ public int DamagedAfterTimePeriodMax;
        // size: 0x3
        public enum DamageStatusEnum {
            Damaged,
            Repaired,
            Random
        }
        /* 0x34 */ public DamageStatusEnum DamageStatus;
        // size: 0x8
        public enum CompletionRequirementEnum {
            FullyChargedAndRepaired,
            AnyChargeAndRepaired,
            FullyRepaired,
            NotFullyCharged,
            EmptySlot,
            NoRequirement,
            UserInstalls,
            HasIngredients
        }
        /* 0x38 */ public CompletionRequirementEnum CompletionRequirement;
    }
}
