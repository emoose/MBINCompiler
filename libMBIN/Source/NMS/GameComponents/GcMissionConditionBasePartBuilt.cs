using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x762BDF8150BF8835, NameHash = 0x75A4AF2BCC689FD2)]
    public class GcMissionConditionBasePartBuilt : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PartID;
        /* 0x10 */ public int Count;
        /* 0x18 */ public GcBuildingPartSearchType Type;
        // size: 0x2
        public enum PartInCurrentBaseEnum {
            DontCare,
            YesAllPlayerOwned,
        }
        /* 0x38 */ public PartInCurrentBaseEnum PartInCurrentBase;
    }
}
