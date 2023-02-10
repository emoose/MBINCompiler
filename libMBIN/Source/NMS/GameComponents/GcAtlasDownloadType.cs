namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD73BB6ECCA3C950, NameHash = 0x73783FC8636BAB3E)]
    public class GcAtlasDownloadType : NMSTemplate
    {
        // size: 0x4
        public enum DownloadTypeEnum {
            Unknown,
            Discovery,
            Base,
            Message,
        }
        /* 0x0 */ public DownloadTypeEnum DownloadType;
    }
}
