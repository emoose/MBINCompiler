using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x662F041CA7AEA23D, NameHash = 0x1BD168A44ADE2D95)]
    public class GcMissionConditionCreatureSlots : NMSTemplate
    {
        /* 0x0 */ public int CreatureSlots;
        /* 0x4 */ public bool OnlyCountFreeSlots;
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
