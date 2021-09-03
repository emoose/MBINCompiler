using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xDCDD167D0981262C, NameHash = 0xB4AC262382F5910E)]
    public class GcBuildingSystemTypeEnum : NMSTemplate
    {
        // size: 0x4
        public enum BuildingSystemTypeEnum { Normal, Underwater, AbandonedSystem, AbandonedSystemunderwater }
        public BuildingSystemTypeEnum BuildingSystemType;
    }
}
