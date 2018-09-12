using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8D50AB1EC49C90E8)]
    public class GcAtlasDownloadType : NMSTemplate
    {
		public enum DownloadTypeEnum { Unknown, Discovery, Base, Message }
		public DownloadTypeEnum DownloadType;
    }
}
