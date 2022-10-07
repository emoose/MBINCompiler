namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x265C96B5655DF648, NameHash = 0x458D53EF402BA3C9)]
    public class GcPlanetInfo : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 PlanetDescription;
        /* 0x080 */ public NMSString0x80 PlanetType;
        /* 0x100 */ public NMSString0x80 Weather;
        /* 0x180 */ public NMSString0x80 Resources;
        /* 0x200 */ public NMSString0x80 Flora;
        /* 0x280 */ public NMSString0x80 Fauna;
        /* 0x300 */ public NMSString0x80 Sentinels;
        /* 0x380 */ public bool IsWeatherExtreme;
        /* 0x381 */ public bool AreSentinelsExtreme;
        /* 0x382 */ public bool AreSentinelsModerate;
    }
}
