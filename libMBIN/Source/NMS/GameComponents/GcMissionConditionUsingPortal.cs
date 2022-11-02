namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x741739C869CE5E5, NameHash = 0x93D7C024B58A671)]
    public class GcMissionConditionUsingPortal : NMSTemplate
    {
        // size: 0x3
        public enum PortalTypeEnum {
            Any,
            Story,
            NotStory
        }
        /* 0x0 */ public PortalTypeEnum PortalType;
    }
}
