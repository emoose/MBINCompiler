using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x8, GUID = 0x889A7E6B75959E0E)]
    public class GcTerrainTextureSettings : NMSTemplate      // size: 0x400
    {
        public float Brightness;
        public float Contrast;
    }
}
