using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkSceneNodeAttributeData : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string AltID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x100)]
        public string Value;
    }
}
