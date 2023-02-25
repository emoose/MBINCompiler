namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD7FC9616F212080A, NameHash = 0xA3C86E46D2A8CA67)]
    public class GcFrigateClass : NMSTemplate
    {
        // size: 0x8
        public enum FrigateClassEnum : uint {
            Combat,
            Exploration,
            Mining,
            Diplomacy,
            Support,
            Normandy,
            DeepSpace,
            DeepSpaceCommon,
        }
        /* 0x0 */ public FrigateClassEnum FrigateClass;
    }
}
