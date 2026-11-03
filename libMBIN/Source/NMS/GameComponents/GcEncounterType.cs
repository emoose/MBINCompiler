namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC76053992B6EBEFC, NameHash = 0xD22ECCA9)]
    public class GcEncounterType : NMSTemplate
    {
        // size: 0xA
        public enum EncounterTypeEnum : uint {
            FactoryGuards,
            HarvesterGuards,
            ScrapHeap,
            Reward,
            CorruptedDroneInteract,
            GroundWorms,
            DroneHiveGuards,
            CorruptDronePillar,
            Fossil,
            OnFootSwarm,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public EncounterTypeEnum EncounterType;
    }
}
