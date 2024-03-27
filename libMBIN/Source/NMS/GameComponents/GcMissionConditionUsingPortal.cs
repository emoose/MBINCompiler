namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC578ECEEBCAAE131, NameHash = 0x93D7C024B58A671)]
    public class GcMissionConditionUsingPortal : NMSTemplate
    {
        // size: 0x3
        public enum PortalTypeEnum : uint {
            Any,
            Story,
            NotStory,
        }
        /* 0x0 */ public PortalTypeEnum PortalType;
    }
}
