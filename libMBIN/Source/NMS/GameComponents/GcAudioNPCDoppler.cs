using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x48, GUID = 0x9E500EA6450A86B2, NameHash = 0xC02D1C8C9CF91C83)]
    public class GcAudioNPCDoppler : NMSTemplate
    {
        [NMS(Size = 0x6, EnumType = typeof(GcAISpaceshipTypes.ShipTypeEnum))]
        /* 0x0 */ public GcAudio3PointDopplerData[] Config;
    }
}
