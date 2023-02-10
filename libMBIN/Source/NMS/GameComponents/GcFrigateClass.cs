namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x40AF5F7334FAFE6C, NameHash = 0xA3C86E46D2A8CA67)]
    public class GcFrigateClass : NMSTemplate
    {
        // size: 0x8
        public enum FrigateClassEnum {
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
