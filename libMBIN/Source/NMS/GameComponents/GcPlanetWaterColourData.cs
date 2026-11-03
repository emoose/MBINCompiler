namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB82BD53D6FB710B3, NameHash = 0x16BE3C3E)]
    public class GcPlanetWaterColourData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x00 */ public Colour CausticsColour;
        [NMS(Index = 11)]
        /* 0x10 */ public Colour EmissionColour;
        [NMS(Index = 1)]
        /* 0x20 */ public Colour FoamColour;
        [NMS(Index = 2)]
        /* 0x30 */ public Colour FoamEmission;
        [NMS(Index = 7)]
        /* 0x40 */ public Colour ScatterColour;
        [NMS(Index = 3)]
        /* 0x50 */ public Colour TransmittanceColour;
        [NMS(Index = 9)]
        /* 0x60 */ public float MaxScatterDistance;
        [NMS(Index = 5)]
        /* 0x64 */ public float MaxTransmittanceDistance;
        [NMS(Index = 8)]
        /* 0x68 */ public float MinScatterDistance;
        [NMS(Index = 4)]
        /* 0x6C */ public float MinTransmittanceDistance;
        [NMS(Index = 0)]
        /* 0x70 */ public float SelectionWeighting;
        [NMS(Index = 12)]
        /* 0x74 */ public float SubsurfaceBoost;
        [NMS(Index = 6)]
        /* 0x78 */ public float SurfaceAbsorptionMultiplier;
    }
}
