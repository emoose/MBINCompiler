namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x6AA447716F6C436)]
    public class GcNPCHabitationComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string NPCSpawnLocator;

        public GcNPCHabitationType NPCHabitationType;
    }
}
