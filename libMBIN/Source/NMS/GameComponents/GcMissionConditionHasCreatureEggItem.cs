namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BC8ED1ACF676574, NameHash = 0x6FDB38E1B65AEDCB)]
    public class GcMissionConditionHasCreatureEggItem : NMSTemplate
    {
        // size: 0x2
        public enum EggItemTypeEnum {
            Egg,
            ValidCatalyst
        }
        /* 0x0 */ public EggItemTypeEnum EggItemType;
        /* 0x4 */ public bool IncludeEggMachineInventoryInSearch;
    }
}
