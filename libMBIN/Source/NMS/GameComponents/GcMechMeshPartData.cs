using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x881FC4805C71C6EF, NameHash = 0xE780BADC17E2668A)]
    public class GcMechMeshPartData : NMSTemplate
    {
        [NMS(Size = 0x2, EnumType = typeof(GcMechMeshType.MechMeshTypeEnum))]
        /* 0x0 */ public GcMechMeshPartTypeData[] MeshTypes;
    }
}
