using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA13AAB76C268D05, NameHash = 0xF3DE406AE480E3E0)]
    public class GcMissionConditionNumberOfShipsOwned : NMSTemplate
    {
        /* 0x0 */ public int NumShips;
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
