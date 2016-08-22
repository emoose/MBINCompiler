using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcNGuiElementData : NMSTemplate
    {
        public NMSString0x10 ID;
        public NMSString0x10 PresetID;

        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0x8 )]
        public byte[] CreationTime;

        public bool IsHidden;

        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0x3 )]
        public byte[] Padding1;

        public GcNGuiLayoutData Layout;
    }
}
