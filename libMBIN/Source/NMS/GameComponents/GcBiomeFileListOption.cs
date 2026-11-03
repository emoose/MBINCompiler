using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE2AB976E89F18C1, NameHash = 0x873D6916)]
    public class GcBiomeFileListOption : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcFilename Filename;
        [NMS(Index = 3)]
        /* 0x10 */ public float PurpleSystemWeight;
        [NMS(Index = 0)]
        /* 0x14 */ public GcBiomeSubType SubType;
        [NMS(Index = 2)]
        /* 0x18 */ public float Weight;
    }
}
