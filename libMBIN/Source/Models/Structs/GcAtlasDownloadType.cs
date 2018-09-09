namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8D50AB1EC49C90E8)]
    public class GcAtlasDownloadType : NMSTemplate
    {
		public enum DownloadTypeEnum { Unknown, Discovery, Base, Message }
		public DownloadTypeEnum DownloadType;
    }
}
