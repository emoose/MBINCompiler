namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCAC9AF77BBCE4356, NameHash = 0x498BFDCD029948EF)]
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
            Obsolete,
        }
        /* 0x0 */ public ActionUseTypeEnum ActionUseType;
    }
}
