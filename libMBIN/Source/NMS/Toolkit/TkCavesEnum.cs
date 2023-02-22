namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x44B15620A5791CDD, NameHash = 0x380AC5FAFC25FE69)]
    public class TkCavesEnum : NMSTemplate
    {
        // size: 0x1
        public enum CaveTypesEnum {
            Underground,
        }
        /* 0x0 */ public CaveTypesEnum CaveTypes;
    }
}
