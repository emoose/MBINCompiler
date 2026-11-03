namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE69AC4D85EEAE9AD, NameHash = 0xD7C471B8)]
    public class GcDroneControlData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public float DirectionBrake;
        [NMS(Index = 7)]
        /* 0x04 */ public float HeightAdjustDownStrength;
        [NMS(Index = 6)]
        /* 0x08 */ public float HeightAdjustStrength;
        [NMS(Index = 10)]
        /* 0x0C */ public float LeanInMoveDirStrength;
        [NMS(Index = 8)]
        /* 0x10 */ public float LookStrength;
        [NMS(Index = 9)]
        /* 0x14 */ public float LookStrengthVertical;
        [NMS(Index = 4)]
        /* 0x18 */ public float MaxHeight;
        [NMS(Index = 5)]
        /* 0x1C */ public float MaxPitch;
        [NMS(Index = 0)]
        /* 0x20 */ public float MaxSpeed;
        [NMS(Index = 3)]
        /* 0x24 */ public float MinHeight;
        [NMS(Index = 12)]
        /* 0x28 */ public float RepelForce;
        [NMS(Index = 13)]
        /* 0x2C */ public float RepelRange;
        [NMS(Index = 11)]
        /* 0x30 */ public float StopTime;
        [NMS(Index = 1)]
        /* 0x34 */ public float Strength;
    }
}
