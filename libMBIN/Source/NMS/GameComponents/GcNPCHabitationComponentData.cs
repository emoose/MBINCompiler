using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x604F221F03B0371, NameHash = 0x340529EE9BE0F315)]
    public class GcNPCHabitationComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 NPCSpawnLocator;
        /* 0x10 */ public GcNPCHabitationType NPCHabitationType;
    }
}
