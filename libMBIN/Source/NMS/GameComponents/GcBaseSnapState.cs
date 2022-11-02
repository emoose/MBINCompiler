namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5C2258B62BDDA7E8, NameHash = 0x1C08FB02D59766DB)]
    public class GcBaseSnapState : NMSTemplate
    {
        // size: 0x2
        public enum SnapStateEnum {
            IsSnapped,
            NotSnapped
        }
        /* 0x0 */ public SnapStateEnum SnapState;
    }
}
