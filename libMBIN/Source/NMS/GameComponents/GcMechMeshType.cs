namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD16EC7423277C21D, NameHash = 0x86E6B8042A598341)]
    public class GcMechMeshType : NMSTemplate
    {
        // size: 0x2
        public enum MechMeshTypeEnum {
            Exocraft,
            Sentinel
        }
        /* 0x0 */ public MechMeshTypeEnum MechMeshType;
    }
}
