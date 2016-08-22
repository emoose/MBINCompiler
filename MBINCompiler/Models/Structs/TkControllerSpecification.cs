using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkControllerSpecification : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        public TkButtonImageLookup ImageLookup;
    }
}
