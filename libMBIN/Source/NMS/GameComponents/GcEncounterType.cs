namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E5A2CCD93F4130A, NameHash = 0xFF746C1098C0C4DE)]
    public class GcEncounterType : NMSTemplate
    {
        // size: 0x7
        public enum EncounterTypeEnum {
            FactoryGuards,
            HarvesterGuards,
            ScrapHeap,
            Reward,
            CorruptedDroneInteract,
            GroundWorms,
            DroneHiveGuards,
        }
        /* 0x0 */ public EncounterTypeEnum EncounterType;
    }
}
