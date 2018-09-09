namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4DEB11EC99BFE346)]
    public class TkMetadataReadMask : NMSTemplate
    {
		public enum MetadataReadMaskEnum { Default, SaveWhenMultiplayerClient, SavePlayerPosition, SavePlayerInventory }
		public MetadataReadMaskEnum MetadataReadMask;
    }
}
