using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x925D47B8943A9949, NameHash = 0xFBB57040)]
    public class GcMissionConditionNPCHabitationHasWorker : NMSTemplate
    {
        // size: 0x3
        public enum WorkerInCurrentBaseEnum : uint {
            DontCare,
            Yes,
            No,
        }
        [NMS(Index = 1)]
        /* 0x0 */ public WorkerInCurrentBaseEnum WorkerInCurrentBase;
        [NMS(Index = 0)]
        /* 0x4 */ public GcNPCHabitationType WorkerType;
    }
}
