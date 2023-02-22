namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA5C5AEF74A763E5, NameHash = 0xACDE6E8DA19EC2E2)]
    public class GcStatsEnum : NMSTemplate
    {
        // size: 0x12
        public enum StatEnumEnum {
            None,
            DEPOTS_BROKEN,
            FPODS_BROKEN,
            PLANTS_PLANTED,
            SALVAGE_LOOTED,
            TREASURE_FOUND,
            QUADS_KILLED,
            WALKERS_KILLED,
            FLORA_KILLED,
            PLANTS_GATHERED,
            BONES_FOUND,
            C_SENT_KILLS,
            STORM_CRYSTALS,
            BURIED_PROPS,
            MINIWORM_KILL,
            POOP_COLLECTED,
            GRAVBALLS,
            EGG_PODS,
        }
        /* 0x0 */ public StatEnumEnum StatEnum;
    }
}
