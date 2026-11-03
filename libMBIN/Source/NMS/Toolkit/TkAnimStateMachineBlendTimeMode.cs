namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x94AFDFB51FDAAE2B, NameHash = 0x19E3FECA)]
    public class TkAnimStateMachineBlendTimeMode : NMSTemplate
    {
        // size: 0x2
        public enum TimeModeEnum : uint {
            Normalised,
            Seconds,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TimeModeEnum TimeMode;
    }
}
