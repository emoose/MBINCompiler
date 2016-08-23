using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkLanguagesAllowedData : NMSTemplate
    {
        public List<TkLanguages> Allowed;
        public TkLanguages Language;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [NMSAttribute(Ignore = true)]
        public byte[] Padding14;
    }
}
