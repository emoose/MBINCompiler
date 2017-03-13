namespace MBINCompiler.Models.Structs
{
    public class GcNGuiActionData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string LayerID;
        [NMS(Size = 0x80)]
        public string Data;

        public int Action;
        public string[] ActionValues()
        {
            return new[] { "Click", "Hover", "ArrowLeft", "ArrowRight"};
        }
    }
}
