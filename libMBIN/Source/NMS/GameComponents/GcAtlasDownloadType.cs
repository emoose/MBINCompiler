namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8D50AB1EC49C90E8, NameHash = 0x73783FC8636BAB3E)]
    public class GcAtlasDownloadType : NMSTemplate
    {
        // size: 0x4
        public enum DownloadTypeEnum {
            Unknown,
            Discovery,
            Base,
            Message
        }
        /* 0x0 */ public DownloadTypeEnum DownloadType;
    }
}
