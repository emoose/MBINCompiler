using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6B67E740C1EE0F5, NameHash = 0x28C2A854)]
    public class GcProjectorOffsetData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcInWorldUIScreenData Active;
        [NMS(Index = 3)]
        /* 0x30 */ public GcInWorldUIScreenData Inactive;
        [NMS(Index = 1)]
        /* 0x60 */ public Vector2f ScreenScale;
        [NMS(Index = 0)]
        /* 0x68 */ public float Scale;
    }
}
