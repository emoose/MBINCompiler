namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD488F83279CACB83, NameHash = 0x93D7C024B58A671)]
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
