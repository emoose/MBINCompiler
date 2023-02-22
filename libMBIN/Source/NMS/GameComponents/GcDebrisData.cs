using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD16BDF2B722D86A9, NameHash = 0xC9F6512AC970CD07)]
    public class GcDebrisData : NMSTemplate
    {
        /* 0x00 */ public TkModelResource Filename;
        /* 0x84 */ public int Number;
        /* 0x88 */ public float Radius;
        /* 0x8C */ public float Scale;
        /* 0x90 */ public float Speed;
        /* 0x94 */ public float AnglularSpeed;
        /* 0x98 */ public GcSeed OverrideSeed;
    }
}
