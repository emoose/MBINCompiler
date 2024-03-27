using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x64289A7C149B1115, NameHash = 0x18F53DCA811C8E56)]
    public class TkGameSettings : NMSTemplate
    {
        /* 0x00 */ public List<GcInputActionMapping> KeyMapping;
        /* 0x10 */ public List<GcInputActionMapping2> KeyMapping2;
    }
}
