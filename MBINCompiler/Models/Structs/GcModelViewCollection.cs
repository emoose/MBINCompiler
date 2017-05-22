namespace MBINCompiler.Models.Structs
{
    public class GcModelViewCollection : NMSTemplate // 0x7E0
    {
        [NMS(Size = 0x12, EnumValue = new string[0x12] {"Exosuit", "Weapon", "Ship", "Exocraft", "Animal", "AnimalThumbnails",
                                                        "Unknown2", "Unknown3","Unknown4","Unknown5","Unknown6","Unknown7",
                                                        "Unknown8","Unknown9", "Freighter", "Unknown10","Unknown11","Unknown12",})] // 18 * 0x70 = 0x7E0
        public TkModelRendererData[] ModelViews; // List or Array?
    }
}
