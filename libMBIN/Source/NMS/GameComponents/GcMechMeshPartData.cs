using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BBE786F7690B265, NameHash = 0xE4BF25FD)]
    public class GcMechMeshPartData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcMechMeshType.MechMeshTypeEnum))]
        /* 0x0 */ public GcMechMeshPartTypeData[] MeshTypes;
    }
}
