namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C6575C0AA760255, NameHash = 0x2A6BB71EAF092577)]
    public class GcNPCHabitationType : NMSTemplate
    {
        // size: 0x5
        public enum NPCHabitationTypeEnum {
            WeaponsExpert,
            Farmer,
            Builder,
            Vehicles,
            Scientist,
        }
        /* 0x0 */ public NPCHabitationTypeEnum NPCHabitationType;
    }
}
