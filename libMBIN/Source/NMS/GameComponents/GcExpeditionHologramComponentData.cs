namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E2E4E9836123C36, NameHash = 0xDCBE648F7DED1A9F)]
    public class GcExpeditionHologramComponentData : NMSTemplate
    {
        /* 0x00 */ public float HologramRotationSpeedDegPerSec;
        /* 0x04 */ public float CaptainScale;
        /* 0x08 */ public float FrigateScale;
        /* 0x10 */ public Vector3f SpawnOffset;
    }
}
