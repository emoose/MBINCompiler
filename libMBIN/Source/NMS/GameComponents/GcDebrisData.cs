using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0AB4C8333A8CA5D, NameHash = 0x99BAD1E4)]
    public class GcDebrisData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource Filename;
        [NMS(Index = 6)]
        /* 0x20 */ public GcSeed OverrideSeed;
        [NMS(Index = 5)]
        /* 0x30 */ public float AnglularSpeed;
        [NMS(Index = 1)]
        /* 0x34 */ public int Number;
        [NMS(Index = 2)]
        /* 0x38 */ public float Radius;
        [NMS(Index = 3)]
        /* 0x3C */ public float Scale;
        [NMS(Index = 4)]
        /* 0x40 */ public float Speed;
    }
}
