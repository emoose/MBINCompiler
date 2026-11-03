namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8D3612FD556CBF8F, NameHash = 0x8FCECF92)]
    public class TkAnimBlendType : NMSTemplate
    {
        // size: 0x4
        public enum BlendTypeEnum : uint {
            Normal,
            MatchTimes,
            MatchTimesAndPhase,
            OffsetByBlendTime,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BlendTypeEnum BlendType;
    }
}
