using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB720E0FC2450E1E9, NameHash = 0x38A772FD)]
    public class GcMechMeshPartTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcMechMeshPart.MechMeshPartEnum))]
        /* 0x0 */ public GcMechMeshPartData[] Parts;
    }
}
