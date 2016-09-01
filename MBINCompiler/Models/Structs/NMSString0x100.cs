using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    // todo: maybe get rid of this and just read strings directly into the list, if all strings are the same size?
    public class NMSString0x100 : NMSTemplate
    {
        [NMS(Size = 0x100)]
        public string Value;
    }
}
