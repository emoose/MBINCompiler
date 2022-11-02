using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF80F8AA6BAD2B5E, NameHash = 0x82C7C611E7625A21)]
    public class GcPulseEncounterSpawnObject : NMSTemplate
    {
        /* 0x00 */ public TkModelResource Object;
        /* 0x84 */ public float SpawnScale;
        /* 0x88 */ public float Pitch;
        /* 0x8C */ public float Yaw;
        /* 0x90 */ public float Roll;
    }
}
