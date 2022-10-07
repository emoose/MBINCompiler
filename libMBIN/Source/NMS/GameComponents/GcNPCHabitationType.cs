namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C36609963787EB4, NameHash = 0x2A6BB71EAF092577)]
    public class GcNPCHabitationType : NMSTemplate
    {
        // size: 0x5
        public enum NPCHabitationTypeEnum {
            WeaponsExpert,
            Farmer,
            Builder,
            Vehicles,
            Scientist
        }
        /* 0x0 */ public NPCHabitationTypeEnum NPCHabitationType;
    }
}
