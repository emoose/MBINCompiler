namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DC0FEAE3730013D, NameHash = 0x3E4089B3)]
    public class GcMechMeshType : NMSTemplate
    {
        // size: 0x4
        public enum MechMeshTypeEnum : uint {
            Exocraft,
            Sentinel,
            BugHunter,
            Stone,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MechMeshTypeEnum MechMeshType;
    }
}
