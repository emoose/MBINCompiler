using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcNGuiElementData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        [NMS(Size = 0x10)]
        public string PresetID;

        public long CreationTime;

        public bool IsHidden;

        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0x3 )]
        [NMSAttribute(Ignore = true)]
        public byte[] Padding29;

        public GcNGuiLayoutData Layout;

        [NMS(Size = 4)]
        public byte[] Padding5C;
    }
}
