using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC07AD9C4CF1F6994, NameHash = 0xD0B8CB5F60C6775)]
    public class GcMissionConditionBaseClaimed : NMSTemplate
    {
        /* 0x00 */ public bool Claimed;
        /* 0x04 */ public GcPersistentBaseTypes Base;
        // size: 0x3
        public enum IsOnCurrentSystemEnum {
            DontCare,
            Yes,
            No,
        }
        /* 0x08 */ public IsOnCurrentSystemEnum IsOnCurrentSystem;
        /* 0x0C */ public bool MustBeInBase;
        /* 0x10 */ public int MinParts;
    }
}
