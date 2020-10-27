using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x90, GUID = 0x2850C6AD91A257FE, NameHash = 0x122FE9C1D39C44F6)]
    public class TkIdSceneFilename : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        [NMS(Size = 0x80)]
        /* 0x10 */ public string Filename;
    }
}
