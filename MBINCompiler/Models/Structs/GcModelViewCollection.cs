namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x850)]
    public class GcModelViewCollection : NMSTemplate
    {
        [NMS(Size = 0x13, EnumValue = new string[0x13] {"Exosuit", "Weapon", "Ship", "Exocraft", "Animal", "AnimalThumbnails",
                                                        "Unknown2", "Unknown3","Unknown4","Unknown5","Unknown6","Unknown7",
                                                        "Unknown8","Unknown9", "Freighter", "Unknown10","Unknown11","Unknown12",
                                                        "Unknown13"})]
        public TkModelRendererData[] ModelViews;
    }
}
