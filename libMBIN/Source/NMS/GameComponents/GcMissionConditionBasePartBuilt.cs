using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC34477E2A2EDC37, NameHash = 0x75A4AF2BCC689FD2)]
    public class GcMissionConditionBasePartBuilt : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PartID;
        /* 0x10 */ public bool TakeIDFromSeasonData;
        /* 0x14 */ public int Count;
        /* 0x18 */ public GcBuildingPartSearchType Type;
        // size: 0x2
        public enum PartInCurrentBaseEnum {
            DontCare,
            YesAllPlayerOwned,
        }
        /* 0x38 */ public PartInCurrentBaseEnum PartInCurrentBase;
    }
}
