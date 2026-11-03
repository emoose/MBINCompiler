namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x652032F29C327D35, NameHash = 0x55E4C0EB)]
    public class TkCameraAttachmentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float BaseOffset;
        [NMS(Index = 1)]
        /* 0x4 */ public float OffsetScaler;
    }
}
