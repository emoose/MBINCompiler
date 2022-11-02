namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA32E07EB511728C1, NameHash = 0x7C82C5EBE3916386)]
    public class GcPlayAudioAction : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Sound;
        /* 0x80 */ public bool UseOcclusion;
        /* 0x84 */ public float OcclusionRadius;
    }
}
