using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE3A1447498994FC3, NameHash = 0xE421F6E8B9AA4E70)]
    public class TkLanguagesAllowedData : NMSTemplate
    {
        /* 0x00 */ public List<TkLanguages> Allowed;
        /* 0x10 */ public TkLanguages Fallback;
    }
}
