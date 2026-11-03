namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB14253248059CA33, NameHash = 0x28335EB7)]
    public class GcGasGiantAtmosphereSetting : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Colour DiscoveryPlanetColour;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 AtmosphereID;
        [NMS(Index = 1)]
        /* 0x20 */ public GcFilename GradientMapResource;
    }
}
