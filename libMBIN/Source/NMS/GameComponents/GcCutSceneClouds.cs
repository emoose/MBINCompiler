namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5966155BBA1667A7, NameHash = 0x538C4409)]
    public class GcCutSceneClouds : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public Colour BottomColour;
        [NMS(Index = 4)]
        /* 0x10 */ public Vector3f InitialOffsetWorldSpace;
        [NMS(Index = 8)]
        /* 0x20 */ public Colour TopColour;
        [NMS(Index = 3)]
        /* 0x30 */ public Vector2f StratosphereWindOffset;
        [NMS(Index = 2)]
        /* 0x38 */ public Vector2f WindOffset;
        [NMS(Index = 7)]
        /* 0x40 */ public float AbsorbtionFactor;
        [NMS(Index = 1)]
        /* 0x44 */ public float AnimScale;
        [NMS(Index = 11)]
        /* 0x48 */ public float AtmosphereEndHeight;
        [NMS(Index = 10)]
        /* 0x4C */ public float AtmosphereStartHeight;
        [NMS(Index = 5)]
        /* 0x50 */ public float Coverage;
        [NMS(Index = 6)]
        /* 0x54 */ public float Density;
        [NMS(Index = 12)]
        /* 0x58 */ public float StratosphereHeight;
        [NMS(Index = 0)]
        /* 0x5C */ public bool ControlClouds;
    }
}
