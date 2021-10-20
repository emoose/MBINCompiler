using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x4B5BC2DFD4B2C5D8, NameHash = 0x2A8282CD4FA96596)]
    public class GcMissionConditionHasFuel : NMSTemplate
    {
        public GcStatsTypes TargetStat;
        public int Amount;
        public NMSString0x10 SpecificTechID;
        public bool FormatTextAsPercentage;
    }
}
