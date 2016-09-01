using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcHUDImageData : NMSTemplate
    {
        public GcHUDComponent Data;

        [NMS(Size = 0x80)]
        public string Image;

        public Colour Colour;
    }
}
