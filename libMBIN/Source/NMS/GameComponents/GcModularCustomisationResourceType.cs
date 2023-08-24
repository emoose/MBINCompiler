namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF2C1F8DFFD8F928, NameHash = 0x6D74FB0420E14CEB)]
    public class GcModularCustomisationResourceType : NMSTemplate
    {
        // size: 0x1
        public enum ModularCustomisationResourceTypeEnum : uint {
            MultiToolStaff,
        }
        /* 0x0 */ public ModularCustomisationResourceTypeEnum ModularCustomisationResourceType;
    }
}
