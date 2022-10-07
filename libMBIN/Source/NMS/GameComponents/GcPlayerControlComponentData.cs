using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x253B9692E0DAFD41, NameHash = 0xE15445D2CE8FD16D)]
    public class GcPlayerControlComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 InitialState;
        /* 0x10 */ public GcPlayerControlInput BaseInput;
        /* 0x48 */ public NMSString0x10 BaseCamera;
        /* 0x58 */ public List<GcPlayerControlState> States;
        /* 0x68 */ public TkBlackboardKey AimDir;
        /* 0x80 */ public TkBlackboardKey TorchDir;
        /* 0x98 */ public TkBlackboardKey CrosshairDir;
    }
}
