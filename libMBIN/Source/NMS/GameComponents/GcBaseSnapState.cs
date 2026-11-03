namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F3B09075006E4D7, NameHash = 0x850752FB)]
    public class GcBaseSnapState : NMSTemplate
    {
        // size: 0x2
        public enum SnapStateEnum : uint {
            IsSnapped,
            NotSnapped,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SnapStateEnum SnapState;
    }
}
