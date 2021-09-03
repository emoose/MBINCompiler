using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xE95AE1F0427E5459, NameHash = 0x69E9FB65CE773F84)]
    public class GcSettlementConstructionLevel : NMSTemplate
    {
        // size: 0x6
        public enum SettlementConstructionLevelEnum { Start, GroundStorey, RegularStorey, Roof, Decoration, Other }
        public SettlementConstructionLevelEnum SettlementConstructionLevel;
    }
}
