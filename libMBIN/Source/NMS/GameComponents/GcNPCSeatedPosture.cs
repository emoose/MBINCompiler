namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC4CEC80C64B45F3, NameHash = 0xDE7AA917D5163592)]
    public class GcNPCSeatedPosture : NMSTemplate
    {
        // size: 0x2
        public enum NPCSeatedPostureEnum {
            Sofa,
            Sit,
        }
        /* 0x0 */ public NPCSeatedPostureEnum NPCSeatedPosture;
    }
}
