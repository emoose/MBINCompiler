using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x410, GUID = 0xE39DD18EF82E623F, NameHash = 0x4BCC54BC6EF02B80)]
    public class TkMaterialSketchComment : NMSTemplate
    {
        [NMS(Size = 0x400)]
        public string Text;     // Not 100% sure on the data type. It doesn't look to be an array, and nothing else uses it... So I am assuming it's just a huge wall of text...
        public int PosMinX;
        public int PosMinY;
        public int PosMaxX;
        public int PosMaxY;
    }
}
