namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9FE7D4541526C409, NameHash = 0x7F587FD9)]
    public class TkAnimationMask : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Mask;
        // size: 0x1
        public enum AnimMaskTypeEnum : uint {
            UpperBody,
        }
        [NMS(Index = 0)]
        /* 0x20 */ public AnimMaskTypeEnum AnimMaskType;
    }
}
