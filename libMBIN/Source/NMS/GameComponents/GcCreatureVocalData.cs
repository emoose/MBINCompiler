using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED0EA1EB716B1C8F, NameHash = 0x505F7128834EAACA)]
    public class GcCreatureVocalData : NMSTemplate
    {
        /* 0x00 */ public float ScaleBias;
        /* 0x08 */ public GcCreatureVocalSoundData IdleVocal;
        /* 0x30 */ public GcCreatureVocalSoundData FleeVocal;
        /* 0x58 */ public GcCreatureVocalSoundData DeathVocal;
        /* 0x80 */ public GcCreatureVocalSoundData AttackVocal;
    }
}
