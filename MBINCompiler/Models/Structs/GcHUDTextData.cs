using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcHUDTextData : NMSTemplate
    {
        public GcHUDComponent Data;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Text;

        [NMS(Size = 8, Ignore = true)]
        public byte[] PaddingA8;

        public GcTextPreset Preset;
    }
}
