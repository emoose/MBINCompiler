using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7982667F2F1C627D, NameHash = 0xE780BADC17E2668A)]
    public class GcMechMeshPartData : NMSTemplate
    {
        // size: 0x2
        public enum MeshTypesEnum {
            Exocraft,
            Sentinel
        }
        [NMS(Size = 0x2, EnumType = typeof(MeshTypesEnum))]
        /* 0x0 */ public GcMechMeshPartTypeData[] MeshTypes;
    }
}
