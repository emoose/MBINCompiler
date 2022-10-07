namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4DDC814768F6A7A4, NameHash = 0x5148874790D0404C)]
    public class GcPlanetWaterColourData : NMSTemplate
    {
        /* 0x00 */ public Colour WaterFogColourNear;
        /* 0x10 */ public Colour WaterFogColourFar;
        /* 0x20 */ public Colour WaterColourBase;
        /* 0x30 */ public Colour WaterColourAdd;
        /* 0x40 */ public Colour FoamColour;
    }
}
