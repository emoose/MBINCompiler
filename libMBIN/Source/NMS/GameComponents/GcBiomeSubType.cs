using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xB6773AD60EFCB088)]
    public class GcBiomeSubType : NMSTemplate
    {
        public enum BiomeSubTypeEnum { None, Standard, HighQuality, Structure, Beam, Hexagon, FractCube, Bubble, Shards, Contour, Shell, BoneSpire, WireCell,
                                       HydroGarden, HugePlant, HugeLush, HugeRing, HugeRock, HugeScorch, HugeToxic }
        public BiomeSubTypeEnum BiomeSubType;
    }
}
