namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFDD9F1E5F1524FF4, NameHash = 0xDF429D791DD4ED76)]
    public class GcExpeditionDurationValues : NMSTemplate
    {
        // size: 0x5
        public enum DurationEnum {
            VeryShort,
            Short,
            Medium,
            Long,
            VeryLong
        }
        [NMS(Size = 0x5, EnumType = typeof(DurationEnum))]
        /* 0x0 */ public int[] Duration;
    }
}
