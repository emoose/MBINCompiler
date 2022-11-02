using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8FCCF1E646E9A2A6, NameHash = 0x4861EEE7B04EAB00)]
    public class GcMissionConditionNumAtlasStationsVisited : NMSTemplate
    {
        /* 0x0 */ public int Count;
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
