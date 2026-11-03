namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x649DF101D5EA5929, NameHash = 0x1A6CF8BB)]
    public class TkWaveSpectrumData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Chop;
        [NMS(Index = 0)]
        /* 0x4 */ public float Wavelength;
    }
}
