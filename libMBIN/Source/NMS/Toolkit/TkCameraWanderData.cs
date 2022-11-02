namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB4BD64034776860E, NameHash = 0xF23D44C69F4360D8)]
    public class TkCameraWanderData : NMSTemplate
    {
        /* 0x0 */ public bool CamWander;
        /* 0x4 */ public float CamWanderPhase;
        /* 0x8 */ public float CamWanderAmplitude;
    }
}
