namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1B0)]
    public class GcPlanetWaterData : NMSTemplate
    {
        /* 0x00 */ public Colour WaterColourNear;
        /* 0x10 */ public Colour WaterColourFar;
        /* 0x20 */ public float WaterStrength;
        /* 0x24 */ public float WaterColourStrength;
        /* 0x28 */ public float WaterMultiplyStrength;
        /* 0x2C */ public float WaterMultiplyMax;
        /* 0x30 */ public float WaterRoughness;
        /* 0x34 */ public float FresnelPower;
        /* 0x38 */ public float FresnelMin;
        /* 0x3C */ public float FresnelMax;
        /* 0x40 */ public float Wave1Scale;
        /* 0x44 */ public float Wave1Height;
        /* 0x48 */ public float Wave1Speed;
        /* 0x4C */ public float Wave2Scale;
        /* 0x50 */ public float Wave2Height;
        /* 0x54 */ public float Wave2Speed;
        /* 0x58 */ public float NormalMap1Scale;
        /* 0x5C */ public float NormalMap1Speed;
        /* 0x60 */ public float NormalMap2Scale;
        /* 0x64 */ public float NormalMap2Speed;
        /* 0x68 */ public float FoamFadeHeight;
        /* 0x6C */ public float Foam1Scale;
        /* 0x70 */ public float Foam1Speed;
        /* 0x74 */ public float Foam2Scale;
        /* 0x78 */ public float Foam2Speed;
        /* 0x80 */ public Colour FoamColour;
        /* 0x90 */ public GcPlanetHeavyAirData HeavyAir;
    }
}
