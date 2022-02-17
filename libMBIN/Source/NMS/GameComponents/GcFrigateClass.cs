using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x84FF8B0985606841, NameHash = 0xA3C86E46D2A8CA67)]
    public class GcFrigateClass : NMSTemplate
    {
        // size: 0x7
        public enum FrigateClassEnum { Combat, Exploration, Mining, Diplomacy, Support, Normandy, DeepSpace }
        public FrigateClassEnum FrigateClass;
    }
}