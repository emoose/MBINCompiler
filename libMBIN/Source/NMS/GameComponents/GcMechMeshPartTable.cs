using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B4CEEDD24D455A6, NameHash = 0x86EB95060E94C279)]
    public class GcMechMeshPartTable : NMSTemplate
    {
        // size: 0x5
        public enum PartsEnum {
            Scanner,
            Body,
            Legs,
            LeftArm,
            RightArm
        }
        [NMS(Size = 0x5, EnumType = typeof(PartsEnum))]
        /* 0x0 */ public GcMechMeshPartData[] Parts;
    }
}
