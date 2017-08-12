namespace MBINCompiler.Models.Structs
{
    public class GcMissionTextDummy : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Text;
        public GcMissionPageHint PageHint;
    }
}
