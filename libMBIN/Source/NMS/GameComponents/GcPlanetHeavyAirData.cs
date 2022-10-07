using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD82CD3A91965CEC, NameHash = 0x2E1B1C402A21253)]
    public class GcPlanetHeavyAirData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Filename;
        [NMS(Size = 0x5)]
        /* 0x80 */ public GcHeavyAirColourData[] Colours;
    }
}
