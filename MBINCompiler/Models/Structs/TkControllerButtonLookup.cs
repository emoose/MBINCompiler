using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkControllerButtonLookup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        [NMS(Size = 0x80)]
        public string ButtonImageLookupFilename;
    }
}
