using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC453AEF09558B7F9, NameHash = 0xDED39C1E)]
    public class GcMissionConditionCreatureSlots : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int CreatureSlots;
        [NMS(Index = 2)]
        /* 0x4 */ public TkEqualityEnum Test;
        [NMS(Index = 1)]
        /* 0x8 */ public bool OnlyCountFreeSlots;
    }
}
