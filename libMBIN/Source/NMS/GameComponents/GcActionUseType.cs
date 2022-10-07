namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x512A832CC804C05F, NameHash = 0x498BFDCD029948EF)]
    public class GcActionUseType : NMSTemplate
    {
        // size: 0x7
        public enum ActionUseTypeEnum {
            Active,
            ActiveVR,
            ActiveXbox,
            ActivePS4,
            Hidden,
            Debug,
            Obsolete
        }
        /* 0x0 */ public ActionUseTypeEnum ActionUseType;
    }
}
