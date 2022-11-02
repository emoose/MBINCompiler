using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF1C8E332BF0AEE74, NameHash = 0x86EB95060E94C279)]
    public class GcMechMeshPartTable : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcMechMeshPart.MechMeshPartEnum))]
        /* 0x0 */ public GcMechMeshPartData[] Parts;
    }
}
