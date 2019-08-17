using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS( Size = 0x4, Alignment = 0x4, GUID = 0x5CCDC0B70353BB1, SubGUID = 0x0F47FD4328A49A000)]
    public class GcPlayerConflictData : NMSTemplate {

        public enum ConflictLevelEnum { Low, Default, High }
        public ConflictLevelEnum ConflictLevel;

    }

}
