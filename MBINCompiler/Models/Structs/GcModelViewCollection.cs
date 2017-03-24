namespace MBINCompiler.Models.Structs
{
    public class GcModelViewCollection : NMSTemplate // 0x7E0
    {
        [NMS(Size = 0x12)] // 18 * 0x70 = 0x7E0
        public TkModelRendererData[] ModelViews; // List or Array?
    }
}
