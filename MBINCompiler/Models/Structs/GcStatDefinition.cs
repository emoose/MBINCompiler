using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcStatDefinition : NMSTemplate
    {
        public GcStatType Type;
        public GcStatTrackType TrackType;
        public GcStatDisplayType DisplayType;
        public GcStatValueData DefaultValue;

        [NMS(Size = 0x10)]
        public string Id;
    }
}
