using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x4DEB11EC99BFE346)]
    public class TkMetadataReadMask : NMSTemplate
    {
		public enum MetadataReadMaskEnum { Default, SaveWhenMultiplayerClient, SavePlayerPosition, SavePlayerInventory }
		public MetadataReadMaskEnum MetadataReadMask;
    }
}
