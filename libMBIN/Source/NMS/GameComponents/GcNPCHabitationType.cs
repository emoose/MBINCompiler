namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBFC294963DBF2713, NameHash = 0x81850E3C)]
    public class GcNPCHabitationType : NMSTemplate
    {
        // size: 0x5
        public enum NPCHabitationTypeEnum : uint {
            WeaponsExpert,
            Farmer,
            Builder,
            Vehicles,
            Scientist,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCHabitationTypeEnum NPCHabitationType;
    }
}
