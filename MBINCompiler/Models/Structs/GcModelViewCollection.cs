namespace MBINCompiler.Models.Structs
{
    public class GcModelViewCollection : NMSTemplate // 0x5B0
    {
        [NMS(Size = 13)] // 13 * 0x70 = 0x5B0
        public TkModelRendererData[] ModelViews; // List or Array?
    }
}
