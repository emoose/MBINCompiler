using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
	[NMS( GUID = 0x78E22E9728E307D2 )]
    public class GcPlanetDataResourceHint : NMSTemplate
    {
                     [NMS(Size = 0x10)]
        /* 0x0000 */ public string Hint;
                     [NMS(Size = 0x10)]
        /* 0x0010 */ public string Icon;
    }
}
