using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DDF37AE5820A370, NameHash = 0xDF429D791DD4ED76)]
    public class GcExpeditionDurationValues : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcExpeditionDuration.ExpeditionDurationEnum))]
        /* 0x0 */ public int[] Duration;
    }
}
