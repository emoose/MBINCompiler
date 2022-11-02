using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD634844F54A6540C, NameHash = 0xA1BAA7B81B1B5EF4)]
    public class GcMissionConditionSquadronSlots : NMSTemplate
    {
        /* 0x0 */ public int PilotSlots;
        /* 0x4 */ public bool OnlyCountFreeSlots;
        /* 0x8 */ public TkEqualityEnum Test;
        /* 0xC */ public bool TakeNumberFromSeasonData;
    }
}
