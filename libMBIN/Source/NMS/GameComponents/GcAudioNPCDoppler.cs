using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2637E05B00CA5010, NameHash = 0x308DBEDE)]
    public class GcAudioNPCDoppler : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x8, EnumType = typeof(GcAISpaceshipTypes.ShipTypeEnum))]
        /* 0x0 */ public GcAudio3PointDopplerData[] Config;
    }
}
