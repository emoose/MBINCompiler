namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE5A800BDD6C622B8, NameHash = 0x4177D084)]
    public class TkPusherType : NMSTemplate
    {
        // size: 0x2
        public enum PusherTypeEnum : byte {
            Sphere,
            HollowSphere,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PusherTypeEnum PusherType;
    }
}
