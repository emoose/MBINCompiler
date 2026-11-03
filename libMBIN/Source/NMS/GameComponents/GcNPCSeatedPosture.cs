namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x91314D522867E169, NameHash = 0xEE05D99C)]
    public class GcNPCSeatedPosture : NMSTemplate
    {
        // size: 0x2
        public enum NPCSeatedPostureEnum : uint {
            Sofa,
            Sit,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCSeatedPostureEnum NPCSeatedPosture;
    }
}
