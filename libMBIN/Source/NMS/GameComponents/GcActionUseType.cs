namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x500387DD113032EE, NameHash = 0x1EB61B73)]
    public class GcActionUseType : NMSTemplate
    {
        // size: 0x8
        public enum ActionUseTypeEnum : uint {
            Active,
            ActiveVR,
            ActiveNonVR,
            ActiveXbox,
            ActivePS4,
            Hidden,
            Debug,
            Obsolete,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ActionUseTypeEnum ActionUseType;
    }
}
