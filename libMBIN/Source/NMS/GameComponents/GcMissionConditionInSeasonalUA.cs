using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0xE980B8AD2A23D04D, NameHash = 0x15FCC555BAF3FC21)]
    public class GcMissionConditionInSeasonalUA : NMSTemplate
    {
        public int SpecificRendevousPlanetIndex;
        public bool SpecificIndexOnlyNeedsToMatchSystem;
    }
}
