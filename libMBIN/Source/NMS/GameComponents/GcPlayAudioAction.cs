namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEDBF2832CB2FDFA6, NameHash = 0x7C82C5EBE3916386)]
    public class GcPlayAudioAction : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Sound;
        /* 0x80 */ public bool UseOcclusion;
        /* 0x84 */ public float OcclusionRadius;
    }
}
