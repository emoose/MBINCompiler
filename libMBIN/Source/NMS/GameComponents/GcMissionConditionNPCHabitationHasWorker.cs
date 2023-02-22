using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B414C643A992848, NameHash = 0x41BFFB2F8544AD51)]
    public class GcMissionConditionNPCHabitationHasWorker : NMSTemplate
    {
        /* 0x0 */ public GcNPCHabitationType WorkerType;
        // size: 0x3
        public enum WorkerInCurrentBaseEnum {
            DontCare,
            Yes,
            No,
        }
        /* 0x4 */ public WorkerInCurrentBaseEnum WorkerInCurrentBase;
    }
}
