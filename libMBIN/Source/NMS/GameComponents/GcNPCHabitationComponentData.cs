using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3267A1FE6946176F, NameHash = 0x340529EE9BE0F315)]
    public class GcNPCHabitationComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 NPCSpawnLocator;
        /* 0x10 */ public GcNPCHabitationType NPCHabitationType;
    }
}
