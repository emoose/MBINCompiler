namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEDFECED53D39F1A8, NameHash = 0x6FDB38E1B65AEDCB)]
    public class GcMissionConditionHasCreatureEggItem : NMSTemplate
    {
        // size: 0x2
        public enum EggItemTypeEnum : uint {
            Egg,
            ValidCatalyst,
        }
        /* 0x0 */ public EggItemTypeEnum EggItemType;
        /* 0x4 */ public bool IncludeEggMachineInventoryInSearch;
    }
}
