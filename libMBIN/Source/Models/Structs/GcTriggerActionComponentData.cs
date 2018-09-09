using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x30, GUID = 0x530AB19BD349A230)]
    public class GcTriggerActionComponentData : NMSTemplate
    {
        /* 0x00 */ public bool HideModel;
        /* 0x01 */ public bool StartInactive;
        [NMS(Size = 0x6, Ignore =true)]
        /* 0x02 */ public byte[] Padding2;
        /* 0x08 */ public List<GcActionTriggerState> States;
        /* 0x18 */ public bool Persistent;
        [NMS(Size = 7, Ignore = true)]
        /* 0x19 */ public byte[] Padding19;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string PersistentState;
    }
}
