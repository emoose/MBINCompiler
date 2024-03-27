namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F9277F3701200F0, NameHash = 0xFAB38B2DF669FFB3)]
    public class GcMissionSequenceQuickWarp : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 MessageWarping;
        /* 0x080 */ public NMSString0x80 MessageCannotWarp;
        /* 0x100 */ public NMSString0x80 DebugText;
        /* 0x180 */ public NMSString0x20A ScanEventToWarpTo;
        /* 0x1A0 */ public NMSString0x10 CameraShakeID;
        /* 0x1B0 */ public bool DoCameraShake;
        /* 0x1B1 */ public bool DoWhiteout;
        /* 0x1B4 */ public float SequenceTime;
        /* 0x1B8 */ public float EffectTime;
    }
}
