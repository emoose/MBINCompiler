namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x5C2AD9EDC86BBE93)]
    public class GcInventoryType : NMSTemplate
    {
		public enum InventoryTypeEnum { Substance, Technology, Product }
		public InventoryTypeEnum InventoryType;
    }
}
