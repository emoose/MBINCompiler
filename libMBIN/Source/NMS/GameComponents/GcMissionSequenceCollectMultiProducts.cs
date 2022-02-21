using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x118, GUID = 0x15CA86EBF44028F5, NameHash = 0x114C4232C254BE54)]
    public class GcMissionSequenceCollectMultiProducts : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public List<GcProductToCollect> Products;
        /* 0x90 */ public bool WaitForSelected;
        /* 0x91 */ public NMSString0x80 DebugText;
    }
}
