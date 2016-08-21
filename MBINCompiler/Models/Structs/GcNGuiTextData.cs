using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcNGuiTextData : NMSTemplate
    {
        public GcNGuiElementData Data;
        public TkNGuiTextStyle Style;
        public TkNGuiGraphicStyle GraphicStyle;

        public NMSString0x80 Image;

        [MarshalAs( UnmanagedType.ByValTStr, SizeConst = 0x200 )]
        public string Text;

        public bool Special;
        [MarshalAs( UnmanagedType.ByValArray, SizeConst = 0xF )]
        public byte[] Padding1;
    }
}
