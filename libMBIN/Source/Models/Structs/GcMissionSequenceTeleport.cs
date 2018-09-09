namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x110)]
    public class GcMissionSequenceTeleport : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string DebugText;
        /* 0x100 */ public GcTeleporterType TeleporterType;
        /* 0x104 */ public bool DoCameraShake;
        /* 0x105 */ public bool DoWhiteout;
        /* 0x108 */ public float SequenceTime;
        /* 0x10C */ public float EffectTime;

    }
}
